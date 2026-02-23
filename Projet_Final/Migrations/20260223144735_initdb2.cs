using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projet_Final.Migrations
{
    /// <inheritdoc />
    public partial class initdb2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Recettes");

            migrationBuilder.DropColumn(
                name: "Telephone",
                table: "Recettes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Recettes",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "Telephone",
                table: "Recettes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
