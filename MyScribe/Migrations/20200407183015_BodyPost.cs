using Microsoft.EntityFrameworkCore.Migrations;

namespace MyScribe.Migrations
{
    public partial class BodyPost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Links",
                table: "Posts",
                newName: "Link");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Posts",
                newName: "Body");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Link",
                table: "Posts",
                newName: "Links");

            migrationBuilder.RenameColumn(
                name: "Body",
                table: "Posts",
                newName: "Description");
        }
    }
}
