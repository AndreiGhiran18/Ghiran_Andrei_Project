using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ghiran_Andrei_Project.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Game_Genre_GenreID",
                table: "Game");

            migrationBuilder.DropTable(
                name: "Genre");

            migrationBuilder.DropIndex(
                name: "IX_Game_GenreID",
                table: "Game");

            migrationBuilder.DropColumn(
                name: "GenreID",
                table: "Game");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GenreID",
                table: "Game",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenreName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Game_GenreID",
                table: "Game",
                column: "GenreID");

            migrationBuilder.AddForeignKey(
                name: "FK_Game_Genre_GenreID",
                table: "Game",
                column: "GenreID",
                principalTable: "Genre",
                principalColumn: "ID");
        }
    }
}
