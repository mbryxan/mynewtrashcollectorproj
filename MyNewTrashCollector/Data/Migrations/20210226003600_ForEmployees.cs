using Microsoft.EntityFrameworkCore.Migrations;

namespace MyNewTrashCollector.Data.Migrations
{
    public partial class ForEmployees : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true),
                    IdentityUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employee_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0f69055a-4849-4dab-847c-1e5454dc8365", "7ecb7690-eaba-47c0-abae-8438aee20493", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c9f3016d-ebbd-499d-8a11-5cc7fc0609bf", "475c8707-98ba-4e8e-b4b8-c6c336daa5c2", "Employee", "EMPLOYEE" });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_IdentityUserId",
                table: "Employee",
                column: "IdentityUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f69055a-4849-4dab-847c-1e5454dc8365");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9f3016d-ebbd-499d-8a11-5cc7fc0609bf");

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
    }
}
