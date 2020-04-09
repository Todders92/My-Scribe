using Microsoft.EntityFrameworkCore.Migrations;

namespace MyScribe.Migrations
{
    public partial class pinned : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Importance",
                table: "Posts");

            migrationBuilder.AddColumn<bool>(
                name: "Pin",
                table: "Posts",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pin",
                table: "Posts");

            migrationBuilder.AddColumn<int>(
                name: "Importance",
                table: "Posts",
                nullable: false,
                defaultValue: 0);
        }
    }
}
