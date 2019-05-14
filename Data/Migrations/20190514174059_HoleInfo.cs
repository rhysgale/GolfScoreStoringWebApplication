using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace GolfScoreStoringWebApplication.Data.Migrations
{
    public partial class HoleInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HoleInfo", //If a place has multiple courses
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CourseId = table.Column<Guid>(nullable: false),
                    Par = table.Column<int>(nullable: false),
                    Distance = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoleInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoleInfo_CourseInfo",
                        column: x => x.CourseId,
                        principalTable: "CourseInfo",
                        principalColumn: "Id");
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("HoleInfo");
        }
    }
}
