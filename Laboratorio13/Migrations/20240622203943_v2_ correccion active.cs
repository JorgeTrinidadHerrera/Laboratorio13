using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Laboratorio13.Migrations
{
    /// <inheritdoc />
    public partial class v2_correccionactive : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Activo",
                table: "Grades",
                newName: "Active");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Active",
                table: "Grades",
                newName: "Activo");
        }
    }
}
