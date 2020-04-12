using Microsoft.EntityFrameworkCore.Migrations;

namespace Journey.Migrations
{
    public partial class ChangeDBModelchangeUserIdname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Destinations_Users_userId",
                table: "Destinations");

            migrationBuilder.DropForeignKey(
                name: "FK_FollwedBies_Users_UserId",
                table: "FollwedBies");

            migrationBuilder.DropForeignKey(
                name: "FK_UserFeedbacks_Users_UserId",
                table: "UserFeedbacks");

            migrationBuilder.DropForeignKey(
                name: "FK_WishLIsts_Users_UserId",
                table: "WishLIsts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "userId",
                table: "Users",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_Destinations_Users_userId",
                table: "Destinations",
                column: "userId",
                principalTable: "Users",
                principalColumn: "userId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FollwedBies_Users_UserId",
                table: "FollwedBies",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "userId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserFeedbacks_Users_UserId",
                table: "UserFeedbacks",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "userId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WishLIsts_Users_UserId",
                table: "WishLIsts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "userId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Destinations_Users_userId",
                table: "Destinations");

            migrationBuilder.DropForeignKey(
                name: "FK_FollwedBies_Users_UserId",
                table: "FollwedBies");

            migrationBuilder.DropForeignKey(
                name: "FK_UserFeedbacks_Users_UserId",
                table: "UserFeedbacks");

            migrationBuilder.DropForeignKey(
                name: "FK_WishLIsts_Users_UserId",
                table: "WishLIsts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "userId",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Destinations_Users_userId",
                table: "Destinations",
                column: "userId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FollwedBies_Users_UserId",
                table: "FollwedBies",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserFeedbacks_Users_UserId",
                table: "UserFeedbacks",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WishLIsts_Users_UserId",
                table: "WishLIsts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
