using Microsoft.EntityFrameworkCore.Migrations;

namespace FreeBelarus.Server.Data.Migrations
{
    public partial class SeedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "87a159ea-b04c-4b12-9341-46c5cf4f8ef8", "4c97fdfe-460c-493b-893b-0fa4232f55df", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fa13afcd-91b2-4d00-94de-ad22945a0585", "a2ef848a-ca98-49ff-90be-d442a813e6a9", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "87a159ea-b04c-4b12-9341-46c5cf4f8ef8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa13afcd-91b2-4d00-94de-ad22945a0585");
        }
    }
}
