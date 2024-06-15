using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Laboratorio13.Migrations
{
    /// <inheritdoc />
    public partial class v2agregarlosestadosalosmodelos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Activo",
                table: "Students",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Activo",
                table: "Grades",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Activo",
                table: "Enrollments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Activo",
                table: "Courses",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Activo",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Activo",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "Activo",
                table: "Enrollments");

            migrationBuilder.DropColumn(
                name: "Activo",
                table: "Courses");
        }
    }
}
