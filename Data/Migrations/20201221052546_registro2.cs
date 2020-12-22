using Microsoft.EntityFrameworkCore.Migrations;

namespace Ing.soft_I.Data.Migrations
{
    public partial class registro2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cliente",
                columns: table => new
                {
                    documento = table.Column<string>(type: "text", nullable: false),
                    nombre = table.Column<string>(type: "text", nullable: true),
                    apepaterno = table.Column<string>(type: "text", nullable: true),
                    apematerno = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cliente", x => x.documento);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cliente");
        }
    }
}
