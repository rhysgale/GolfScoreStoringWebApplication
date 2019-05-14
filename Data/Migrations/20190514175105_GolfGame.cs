using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace GolfScoreStoringWebApplication.Data.Migrations
{
    public partial class GolfGame : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Game", //If a place has multiple courses
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CourseId = table.Column<Guid>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Game", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Game_Course",
                        column: x => x.CourseId,
                        principalTable: "CourseInfo",
                        principalColumn: "Id");
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Game");
        }
    }
}
