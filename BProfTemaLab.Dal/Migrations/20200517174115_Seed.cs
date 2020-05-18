using Microsoft.EntityFrameworkCore.Migrations;

namespace BProfTemaLab.Dal.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Supplier",
                columns: new[] { "Id", "Address", "Email", "Name", "PhoneNumber" },
                values: new object[] { 1, "1234 Bp igen u. 35", "valammi@igen.hu", "Személyes feng shui tanácsadó", "06-20-123-4567" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Supplier",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
