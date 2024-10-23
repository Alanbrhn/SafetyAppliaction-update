using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SafetyAppliaction.Migrations
{
    /// <inheritdoc />
    public partial class AddJWTSaveService : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JwtTokenInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SecretKey = table.Column<string>(type: "TEXT", nullable: false),
                    Issuer = table.Column<string>(type: "TEXT", nullable: false),
                    Audience = table.Column<string>(type: "TEXT", nullable: false),
                    ExpiryInMinutes = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JwtTokenInfos", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(2569), new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(2593) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(2598), new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(2599) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(2601), new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(2602) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(3142), new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(3144) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(3148), new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(3149) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(3152), new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(3153) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(3156), new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(3157) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(3160), new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(3161) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(3163), new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(3164) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(3166), new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(3167) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(3170), new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(3171) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(3173), new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(3174) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(3178), new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(3178) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(2905), new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(2907) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(3003), new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(3005) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(3008), new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(3009) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(3011), new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(3012) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(3013), new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(3014) });

            migrationBuilder.UpdateData(
                table: "StatusTransactions",
                keyColumn: "StatusTransactionId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(3075), new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(3077) });

            migrationBuilder.UpdateData(
                table: "StatusTransactions",
                keyColumn: "StatusTransactionId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(3081), new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(3082) });

            migrationBuilder.UpdateData(
                table: "StatusTransactions",
                keyColumn: "StatusTransactionId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(3084), new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(3085) });

            migrationBuilder.UpdateData(
                table: "StatusTransactions",
                keyColumn: "StatusTransactionId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(3087), new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(3088) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(3256), new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(3258) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(3263), new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(3264) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(3268), new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(3269) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(3272), new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(3273) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(3276), new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(3277) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(3280), new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(3281) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(3284), new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(3285) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(3288), new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(3289) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(3293), new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(3294) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(3297), new DateTime(2024, 10, 23, 20, 23, 34, 531, DateTimeKind.Local).AddTicks(3298) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JwtTokenInfos");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(97), new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(111) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(113), new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(113) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(114), new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(115) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(280), new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(281) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(283), new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(284) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(285), new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(286) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(287), new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(287) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(289), new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(289) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(291), new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(291) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(292), new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(293) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(294), new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(295) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(296), new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(296) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(299), new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(299) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(224), new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(224) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(226), new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(226) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(227), new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(228) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(229), new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(229) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(230), new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(231) });

            migrationBuilder.UpdateData(
                table: "StatusTransactions",
                keyColumn: "StatusTransactionId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(253), new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(254) });

            migrationBuilder.UpdateData(
                table: "StatusTransactions",
                keyColumn: "StatusTransactionId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(256), new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(257) });

            migrationBuilder.UpdateData(
                table: "StatusTransactions",
                keyColumn: "StatusTransactionId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(258), new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(258) });

            migrationBuilder.UpdateData(
                table: "StatusTransactions",
                keyColumn: "StatusTransactionId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(259), new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(260) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(326), new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(326) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(328), new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(329) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(330), new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(330) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(333), new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(333) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(335), new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(335) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(337), new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(337) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(338), new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(339) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(340), new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(341) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(342), new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(342) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(344), new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(344) });
        }
    }
}
