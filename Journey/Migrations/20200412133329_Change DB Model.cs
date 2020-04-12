using Microsoft.EntityFrameworkCore.Migrations;

namespace Journey.Migrations
{
    public partial class ChangeDBModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PuBlisherId",
                table: "Destinations");

            migrationBuilder.AddColumn<int>(
                name: "AdminId",
                table: "Destinations",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "userId",
                table: "Destinations",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Destinations_AdminId",
                table: "Destinations",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Destinations_userId",
                table: "Destinations",
                column: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_Destinations_Admins_AdminId",
                table: "Destinations",
                column: "AdminId",
                principalTable: "Admins",
                principalColumn: "AdminId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Destinations_Users_userId",
                table: "Destinations",
                column: "userId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Destinations_Admins_AdminId",
                table: "Destinations");

            migrationBuilder.DropForeignKey(
                name: "FK_Destinations_Users_userId",
                table: "Destinations");

            migrationBuilder.DropIndex(
                name: "IX_Destinations_AdminId",
                table: "Destinations");

            migrationBuilder.DropIndex(
                name: "IX_Destinations_userId",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "AdminId",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "userId",
                table: "Destinations");

            migrationBuilder.AddColumn<int>(
                name: "PuBlisherId",
                table: "Destinations",
                type: "int",
                nullable: true);
        }
    }
}
