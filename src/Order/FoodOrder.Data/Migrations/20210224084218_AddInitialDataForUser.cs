using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodOrder.Data.Migrations
{
    public partial class AddInitialDataForUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "clients",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Test1" });

            migrationBuilder.InsertData(
                table: "clients",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Test2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "clients",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
