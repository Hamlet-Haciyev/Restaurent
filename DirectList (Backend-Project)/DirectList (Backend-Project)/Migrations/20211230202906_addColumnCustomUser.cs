using Microsoft.EntityFrameworkCore.Migrations;

namespace DirectList__Backend_Project_.Migrations
{
    public partial class addColumnCustomUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "AspNetUsers",
                type: "nvarchar(3000)",
                maxLength: 3000,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Text",
                table: "AspNetUsers");
        }
    }
}
