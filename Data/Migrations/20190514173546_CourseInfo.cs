using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace GolfScoreStoringWebApplication.Data.Migrations
{
    public partial class CourseInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CourseInfo", //If a place has multiple courses
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    LocationId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false, maxLength: 100)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseInfo_PlaceLocation",
                        column: x => x.LocationId,
                        principalTable: "PlaceLocation",
                        principalColumn: "Id");
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("CourseInfo");
        }
    }
}
