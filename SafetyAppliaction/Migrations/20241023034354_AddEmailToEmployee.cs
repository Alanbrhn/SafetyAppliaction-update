using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SafetyAppliaction.Migrations
{
    /// <inheritdoc />
    public partial class AddEmailToEmployee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(5871), new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(5887) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(5888), new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(5889) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(5890), new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6094), new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6095) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6097), new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6097) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6099), new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6099) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6100), new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6101) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6102), new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6102) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6104), new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6104) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6105), new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6106) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6107), new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6107) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6108), new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6109) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6110), new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6111) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6009), new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6009) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6011), new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6011) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6012), new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6013) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6014), new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6014) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6015), new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6015) });

            migrationBuilder.UpdateData(
                table: "StatusTransactions",
                keyColumn: "StatusTransactionId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6039), new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6040) });

            migrationBuilder.UpdateData(
                table: "StatusTransactions",
                keyColumn: "StatusTransactionId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6041), new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6042) });

            migrationBuilder.UpdateData(
                table: "StatusTransactions",
                keyColumn: "StatusTransactionId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6042), new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6043) });

            migrationBuilder.UpdateData(
                table: "StatusTransactions",
                keyColumn: "StatusTransactionId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6044), new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6044) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6135), new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6136) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6138), new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6139) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6140), new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6140) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6142), new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6142) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6144), new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6144) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6145), new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6146) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6148), new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6148) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6150), new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6150) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6151), new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6152) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6153), new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6154) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4186), new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4198) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4199), new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4200) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4201), new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4201) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4375), new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4376) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4377), new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4378) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4382), new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4383) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4384), new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4384) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4385), new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4386) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4387), new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4387) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4412), new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4412) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4413), new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4414) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4415), new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4415) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4416), new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4417) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4315), new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4316) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4317), new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4318) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4319), new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4319) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4320), new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4321) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4321), new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4322) });

            migrationBuilder.UpdateData(
                table: "StatusTransactions",
                keyColumn: "StatusTransactionId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4347), new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4347) });

            migrationBuilder.UpdateData(
                table: "StatusTransactions",
                keyColumn: "StatusTransactionId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4349), new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4350) });

            migrationBuilder.UpdateData(
                table: "StatusTransactions",
                keyColumn: "StatusTransactionId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4350), new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4351) });

            migrationBuilder.UpdateData(
                table: "StatusTransactions",
                keyColumn: "StatusTransactionId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4352), new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4352) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4444), new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4445) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4447), new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4448) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4449), new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4449) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4450), new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4451) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4452), new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4453) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4454), new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4454) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4456), new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4456) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4457), new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4458) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4460), new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4462), new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4462) });
        }
    }
}
