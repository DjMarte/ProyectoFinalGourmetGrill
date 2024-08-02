using GourmetGrillApi.api.DAL;
using GourmetGrillApi.api.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ProyectoFinalGourmetGrill.Services;
using Shared.Interfaces;
using Shared.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var ConStr = builder.Configuration.GetConnectionString("ConStr") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(ConStr));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Data Protection
builder.Services.AddDataProtection();

/*El m�todo builder.Services.AddDataProtection() agrega los servicios necesarios para la protecci�n de datos a la colecci�n de
 * servicios de ASP.NET Core. Este mecanismo es fundamental para varias funcionalidades de seguridad en ASP.NET Core, como la 
 * protecci�n de cookies de autenticaci�n, tokens antifalsificaci�n y almacenamiento seguro de datos sensibles.*/


//Cors

builder.Services.AddCors(options => {
    options.AddPolicy("AllowAnyOrigin",
        builder => builder.AllowAnyOrigin() // Allow any origin
                          .AllowAnyMethod()
                          .AllowAnyHeader());
});

// Identity services
builder.Services.AddIdentityCore<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();

// Services
builder.Services.AddScoped<IServerAsp<ApplicationUser>, UsersService>();
builder.Services.AddScoped<IServerAsp<IdentityRole>, RolesService>();
builder.Services.AddScoped<IServerAsp<IdentityUserRole<string>>, UserRolesService>();
builder.Services.AddScoped<IServer<CategoriaProductos>, CategoriaProductosService>();
builder.Services.AddScoped<IServer<Productos>, ProductosService>();
builder.Services.AddScoped<IServer<Ordenes>, OrdenesService>();
builder.Services.AddScoped<IServer<Ventas>, VentasService>();
builder.Services.AddScoped<IServer<MetodoPagos>, MetodosPagosService>();
builder.Services.AddScoped<IServer<Estados>, EstadosService>();
builder.Services.AddScoped<IdentityUserService>();
builder.Services.AddScoped<ProductosService>();
builder.Services.AddScoped<MetodoPagos>();
builder.Services.AddScoped<UsersService>();

// TimeProvider service
builder.Services.AddSingleton<System.TimeProvider>(System.TimeProvider.System);

/*System.TimeProvider es un nuevo tipo en .NET que proporciona una abstracci�n sobre las fuentes 
 * de tiempo del sistema. Esta abstracci�n puede ser �til para pruebas y para obtener 
 * diferentes representaciones del tiempo.*/

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("AllowAnyOrigin"); // Use the CORS policy
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
