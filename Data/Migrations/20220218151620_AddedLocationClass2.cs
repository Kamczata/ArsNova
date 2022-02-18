using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class AddedLocationClass2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "Artists");

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Artists",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Artists_LocationId",
                table: "Artists",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Artists_Location_LocationId",
                table: "Artists",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artists_Location_LocationId",
                table: "Artists");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropIndex(
                name: "IX_Artists_LocationId",
                table: "Artists");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Artists");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Artists",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
