using Microsoft.EntityFrameworkCore.Migrations;

namespace BProfTemaLab.Dal.Migrations
{
    public partial class ProductDatas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Name", "SupplierId", "UnitPrice" },
                values: new object[] { 1, "Coca Cola", 1, 250 });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Name", "SupplierId", "UnitPrice" },
                values: new object[] { 2, "Soproni classic", 2, 350 });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Name", "SupplierId", "UnitPrice" },
                values: new object[] { 3, "Soproni Demon", 2, 450 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
