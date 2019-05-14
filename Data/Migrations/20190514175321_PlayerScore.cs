using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace GolfScoreStoringWebApplication.Data.Migrations
{
    public partial class PlayerScore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlayerScore", //If a place has multiple courses
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    GameId = table.Column<Guid>(nullable: false),
                    HoleId = table.Column<Guid>(nullable: false),
                    PlayerId = table.Column<string>(nullable: false, maxLength: 450),
                    PlayerStrokes = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerScore", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlrScore_Game",
                        column: x => x.GameId,
                        principalTable: "Game",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PlrScore_Hole",
                        column: x => x.HoleId,
                        principalTable: "HoleInfo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PlrScore_Player",
                        column: x => x.PlayerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("PlayerScore");
        }
    }
}
