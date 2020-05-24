using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Journey.Migrations
{
    public partial class Changedestinationdatetimevariabletype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "EnjoyableTime",
                table: "Destinations",
                nullable: true,
                oldClrType: typeof(TimeSpan),
                oldType: "time",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeSpan>(
                name: "EnjoyableTime",
                table: "Destinations",
                type: "time",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);
        }
    }
}
