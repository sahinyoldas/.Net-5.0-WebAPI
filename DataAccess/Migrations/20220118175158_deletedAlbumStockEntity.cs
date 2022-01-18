using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class deletedAlbumStockEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlbumStocks");

            migrationBuilder.AddColumn<int>(
                name: "AlbumType",
                table: "Albums",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "Stock",
                table: "Albums",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlbumType",
                table: "Albums");

            migrationBuilder.DropColumn(
                name: "Stock",
                table: "Albums");

            migrationBuilder.CreateTable(
                name: "AlbumStocks",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlbumId = table.Column<long>(type: "bigint", nullable: false),
                    AlbumType = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlbumStocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AlbumStocks_Albums_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Albums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlbumStocks_AlbumId",
                table: "AlbumStocks",
                column: "AlbumId");
        }
    }
}
