using Microsoft.EntityFrameworkCore.Migrations;

namespace EmerseTest.Migrations
{
    public partial class SeedApplicationTypeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ApplicationType",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "ComputerScience" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApplicationType",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
