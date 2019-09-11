using Microsoft.EntityFrameworkCore.Migrations;

namespace Demo.Migrations
{
    public partial class init201909061104 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo.Pb");

            migrationBuilder.RenameTable(
                name: "PhoneNumber",
                schema: "Pb",
                newName: "PhoneNumber",
                newSchema: "dbo.Pb");

            migrationBuilder.RenameTable(
                name: "Person",
                schema: "Pb",
                newName: "Person",
                newSchema: "dbo.Pb");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Pb");

            migrationBuilder.RenameTable(
                name: "PhoneNumber",
                schema: "dbo.Pb",
                newName: "PhoneNumber",
                newSchema: "Pb");

            migrationBuilder.RenameTable(
                name: "Person",
                schema: "dbo.Pb",
                newName: "Person",
                newSchema: "Pb");
        }
    }
}
