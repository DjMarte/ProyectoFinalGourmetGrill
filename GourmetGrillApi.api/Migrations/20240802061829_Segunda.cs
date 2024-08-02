using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GourmetGrillApi.api.Migrations
{
    /// <inheritdoc />
    public partial class Segunda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "Ordenes",
                newName: "Observacion");

            migrationBuilder.AddColumn<float>(
                name: "ITBIS",
                table: "Ordenes",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Monto",
                table: "Ordenes",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ITBIS",
                table: "Ordenes");

            migrationBuilder.DropColumn(
                name: "Monto",
                table: "Ordenes");

            migrationBuilder.RenameColumn(
                name: "Observacion",
                table: "Ordenes",
                newName: "Descripcion");
        }
    }
}
