using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EUMusic.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Winner",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    HostCity = table.Column<string>(nullable: true),
                    WinnerCountry = table.Column<string>(nullable: true),
                    SongTitle = table.Column<string>(nullable: true),
                    Performer = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true),
                    Points = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Winner", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Winner");
        }
    }
}
