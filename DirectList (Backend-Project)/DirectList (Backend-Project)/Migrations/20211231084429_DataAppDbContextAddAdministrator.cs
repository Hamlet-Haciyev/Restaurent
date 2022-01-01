using Microsoft.EntityFrameworkCore.Migrations;

namespace DirectList__Backend_Project_.Migrations
{
    public partial class DataAppDbContextAddAdministrator : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Administrator_Restaurants_RestaurantId",
                table: "Administrator");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Administrator",
                table: "Administrator");

            migrationBuilder.RenameTable(
                name: "Administrator",
                newName: "Administrators");

            migrationBuilder.RenameIndex(
                name: "IX_Administrator_RestaurantId",
                table: "Administrators",
                newName: "IX_Administrators_RestaurantId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Administrators",
                table: "Administrators",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Administrators_Restaurants_RestaurantId",
                table: "Administrators",
                column: "RestaurantId",
                principalTable: "Restaurants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Administrators_Restaurants_RestaurantId",
                table: "Administrators");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Administrators",
                table: "Administrators");

            migrationBuilder.RenameTable(
                name: "Administrators",
                newName: "Administrator");

            migrationBuilder.RenameIndex(
                name: "IX_Administrators_RestaurantId",
                table: "Administrator",
                newName: "IX_Administrator_RestaurantId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Administrator",
                table: "Administrator",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Administrator_Restaurants_RestaurantId",
                table: "Administrator",
                column: "RestaurantId",
                principalTable: "Restaurants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
