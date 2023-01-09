using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect_Dicui_Florin.Migrations
{
    public partial class qwe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NetworkID",
                table: "Shop",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Network",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NetworkName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Network", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Shop_NetworkID",
                table: "Shop",
                column: "NetworkID");

            migrationBuilder.AddForeignKey(
                name: "FK_Shop_Network_NetworkID",
                table: "Shop",
                column: "NetworkID",
                principalTable: "Network",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shop_Network_NetworkID",
                table: "Shop");

            migrationBuilder.DropTable(
                name: "Network");

            migrationBuilder.DropIndex(
                name: "IX_Shop_NetworkID",
                table: "Shop");

            migrationBuilder.DropColumn(
                name: "NetworkID",
                table: "Shop");
        }
    }
}
