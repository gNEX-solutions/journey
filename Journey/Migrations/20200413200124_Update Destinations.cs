using Microsoft.EntityFrameworkCore.Migrations;

namespace Journey.Migrations
{
    public partial class UpdateDestinations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Destinations_Users_userId",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "CatagoryId",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "TravellingModeId",
                table: "Destinations");

            migrationBuilder.AlterColumn<int>(
                name: "userId",
                table: "Destinations",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Destinations_Users_userId",
                table: "Destinations",
                column: "userId",
                principalTable: "Users",
                principalColumn: "userId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Destinations_Users_userId",
                table: "Destinations");

            migrationBuilder.AlterColumn<int>(
                name: "userId",
                table: "Destinations",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatagoryId",
                table: "Destinations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TravellingModeId",
                table: "Destinations",
                type: "int",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Destinations_Users_userId",
                table: "Destinations",
                column: "userId",
                principalTable: "Users",
                principalColumn: "userId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
