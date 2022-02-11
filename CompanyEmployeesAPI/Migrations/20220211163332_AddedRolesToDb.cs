using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyEmployeesAPI.Migrations
{
    public partial class AddedRolesToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6f21f75f-963c-46ee-bf51-997e151f5a12", "cb3c787b-d611-4e95-8c55-2980ba0df1c4", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e4db4c95-0c99-43f9-9a3e-26992c0bd420", "8d519d68-ff83-468a-85ad-d23ed279b05a", "Administrator", "ADMINiSTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6f21f75f-963c-46ee-bf51-997e151f5a12");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4db4c95-0c99-43f9-9a3e-26992c0bd420");
        }
    }
}
