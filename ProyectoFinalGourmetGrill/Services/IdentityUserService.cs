using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ProyectoFinalGourmetGrill.Data;

namespace ProyectoFinalGourmetGrill.Services;

public class IdentityUserService
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager; // Añadir SignInManager
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly ApplicationDbContext _contexto;

    public IdentityUserService(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<IdentityRole> roleManager, ApplicationDbContext contexto) {
        _userManager = userManager;
        _signInManager = signInManager; // Inicializar SignInManager
        _roleManager = roleManager;
        _contexto = contexto;
    }

    public async Task<IdentityResult> CreateUserAsync(ApplicationUser user, string password) {
        user.EmailConfirmed = true;
        var result = await _userManager.CreateAsync(user, password);

        if (!result.Succeeded)
            return result;

        var adminRole = await _roleManager.FindByNameAsync("Admin");
        if (adminRole == null) {
            await _roleManager.CreateAsync(new IdentityRole("Admin"));
            await _userManager.AddToRoleAsync(user, "Admin");
            return result;
        }

        var clienteRole = await _roleManager.FindByNameAsync("Cliente");
        if (clienteRole == null) {
            await _roleManager.CreateAsync(new IdentityRole("Cliente"));
        }
        await _userManager.AddToRoleAsync(user, "Cliente");
        return result;
    }

    public async Task<bool> EmailExisteAsync(string email) {
        var user = await _userManager.FindByEmailAsync(email);
        return user != null;
    }

    public async Task<bool> CheckPasswordAsync(ApplicationUser user, string password) {
        return await _userManager.CheckPasswordAsync(user, password);
    }

    public async Task<bool> GetNickNameAsync(string user) {
        return await _contexto.Users.AnyAsync(x => x.NickName == user);
    }

    public async Task<bool> CedulaExistAsync(string user) {
        return await _contexto.Users.AnyAsync(x => x.Cedula == user);
    }

    public async Task<IdentityRole> GetRoleAsync(ApplicationUser user) {
        var roles = await _contexto.UserRoles.FirstOrDefaultAsync(x => x.UserId == user.Id);
        if (roles != null) {
            return await _contexto.Roles.FirstOrDefaultAsync(r => r.Id == roles.RoleId);
        }
        else {
            return null;
        }
    }

    public async Task<bool> ChangeUserRoleAsync(ApplicationUser user, string newRoleName) {
        var existingRoles = await _userManager.GetRolesAsync(user);
        foreach (var existingRole in existingRoles) {
            await _userManager.RemoveFromRoleAsync(user, existingRole);
        }

        var role = await _contexto.Roles.FirstOrDefaultAsync(x => x.Name == newRoleName);
        if (role == null) {
            await _roleManager.CreateAsync(new IdentityRole(newRoleName));
            role = await _contexto.Roles.FirstOrDefaultAsync(x => x.Name == newRoleName);
        }

        _contexto.UserRoles.Add(new IdentityUserRole<string> { UserId = user.Id, RoleId = role.Id });
        return await _contexto.SaveChangesAsync() > 0;
    }

    // Método para iniciar sesión sin persistencia
    public async Task<bool> SignInUserAsync(string email, string password, bool isPersistent) {
        var result = await _signInManager.PasswordSignInAsync(email, password, isPersistent, lockoutOnFailure: false);
        return result.Succeeded;
    }
}
