using Microsoft.EntityFrameworkCore.Migrations;

namespace GolfScoreStoringWebApplication.Data.Migrations
{
    public partial class LocationTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlaceLocation", //The actual location of the place
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false, maxLength: 100),
                    Address1 = table.Column<string>(nullable: true, maxLength: 100),
                    Address2 = table.Column<string>(nullable: true, maxLength: 100),
                    Address3 = table.Column<string>(nullable: true, maxLength: 100),
                    PostCode = table.Column<string>(nullable: true, maxLength: 8),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaceLocation", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("PlaceLocation");
        }
    }
}
