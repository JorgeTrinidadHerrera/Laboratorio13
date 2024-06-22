using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Laboratorio13.Migrations
{
    /// <inheritdoc />
    public partial class v2_secreolabasededatos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Activo",
                table: "Courses",
                newName: "Active");

            migrationBuilder.AlterColumn<int>(
                name: "Credit",
                table: "Courses",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Active",
                table: "Courses",
                newName: "Activo");

            migrationBuilder.AlterColumn<string>(
                name: "Credit",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
