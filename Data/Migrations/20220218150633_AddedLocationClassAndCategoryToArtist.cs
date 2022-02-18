using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class AddedLocationClassAndCategoryToArtist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArtistId",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ArtistId",
                table: "Categories",
                column: "ArtistId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Artists_ArtistId",
                table: "Categories",
                column: "ArtistId",
                principalTable: "Artists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Artists_ArtistId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_ArtistId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ArtistId",
                table: "Categories");
        }
    }
}
