using Microsoft.EntityFrameworkCore.Migrations;

namespace MyScribe.Migrations
{
    public partial class modelUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Posts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Posts",
                nullable: false,
                defaultValue: 0);
        }
    }
}
