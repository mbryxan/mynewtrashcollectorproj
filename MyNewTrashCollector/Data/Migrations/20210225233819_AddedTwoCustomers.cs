using Microsoft.EntityFrameworkCore.Migrations;

namespace MyNewTrashCollector.Data.Migrations
{
    public partial class AddedTwoCustomers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "10e621ac-2dda-4461-87e9-243c64002dba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65e2cce3-55e3-4b59-87dc-4fac56ad0fc7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e08c8249-db63-4dde-a064-e29685c33e61");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6ac3852e-b6db-403a-a32b-b0228e9627a7", "4a2af33b-ffb6-40c5-90da-fb260d90c110", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6118a1c0-dd01-4fde-9af8-75abf77ef652", "fe5d9c93-b5cf-4404-ab10-708bf77f88e0", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "185f4a1d-d357-44ac-bed2-08a327f903df", "2916739a-0d01-422d-b7bf-060ccbcb5e73", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "185f4a1d-d357-44ac-bed2-08a327f903df");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6118a1c0-dd01-4fde-9af8-75abf77ef652");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ac3852e-b6db-403a-a32b-b0228e9627a7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "65e2cce3-55e3-4b59-87dc-4fac56ad0fc7", "ab742c8c-d4f3-444a-bc07-96376ac43a7f", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e08c8249-db63-4dde-a064-e29685c33e61", "7dba14d8-c462-4705-b88f-21e86483453a", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "10e621ac-2dda-4461-87e9-243c64002dba", "94b23dc1-60c2-4be8-86f1-7cf609114cfc", "Employee", "EMPLOYEE" });
        }
    }
}
