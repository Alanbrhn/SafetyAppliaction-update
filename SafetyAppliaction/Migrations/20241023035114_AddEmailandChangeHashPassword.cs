using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SafetyAppliaction.Migrations
{
    /// <inheritdoc />
    public partial class AddEmailandChangeHashPassword : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Employees",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

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
                columns: new[] { "CreatedAt", "Email", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(280), "test@gmail.com", new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(281) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(283), "test1@gmail.com", new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(284) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(285), "test2@gmail.com", new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(286) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(287), "test3@gmail.com", new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(287) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(289), "test4@gmail.com", new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(289) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(291), "test5@gmail.com", new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(291) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Email", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(292), "test6@gmail.com", new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(293) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(294), "test7@gmail.com", new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(295) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(296), "test8@gmail.com", new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(296) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(299), "test9@gmail.com", new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(299) });

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
                columns: new[] { "CreatedAt", "PasswordHash", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(326), "AQAAAAIAAYagAAAAED1r9Q/pZTFcRwcyKRzTbWXIFAjSSe2LOIKrZze3LcQs2zSonlnl5NC227nPBNe68A==", new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(326) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PasswordHash", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(328), "AQAAAAIAAYagAAAAED1r9Q/pZTFcRwcyKRzTbWXIFAjSSe2LOIKrZze3LcQs2zSonlnl5NC227nPBNe68A==", new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(329) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PasswordHash", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(330), "AQAAAAIAAYagAAAAED1r9Q/pZTFcRwcyKRzTbWXIFAjSSe2LOIKrZze3LcQs2zSonlnl5NC227nPBNe68A==", new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(330) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "PasswordHash", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(333), "AQAAAAIAAYagAAAAED1r9Q/pZTFcRwcyKRzTbWXIFAjSSe2LOIKrZze3LcQs2zSonlnl5NC227nPBNe68A==", new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(333) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "PasswordHash", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(335), "AQAAAAIAAYagAAAAED1r9Q/pZTFcRwcyKRzTbWXIFAjSSe2LOIKrZze3LcQs2zSonlnl5NC227nPBNe68A==", new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(335) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "PasswordHash", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(337), "AQAAAAIAAYagAAAAED1r9Q/pZTFcRwcyKRzTbWXIFAjSSe2LOIKrZze3LcQs2zSonlnl5NC227nPBNe68A==", new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(337) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "CreatedAt", "PasswordHash", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(338), "AQAAAAIAAYagAAAAED1r9Q/pZTFcRwcyKRzTbWXIFAjSSe2LOIKrZze3LcQs2zSonlnl5NC227nPBNe68A==", new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(339) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "CreatedAt", "PasswordHash", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(340), "AQAAAAIAAYagAAAAED1r9Q/pZTFcRwcyKRzTbWXIFAjSSe2LOIKrZze3LcQs2zSonlnl5NC227nPBNe68A==", new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(341) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "CreatedAt", "PasswordHash", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(342), "AQAAAAIAAYagAAAAED1r9Q/pZTFcRwcyKRzTbWXIFAjSSe2LOIKrZze3LcQs2zSonlnl5NC227nPBNe68A==", new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(342) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "CreatedAt", "PasswordHash", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(344), "AQAAAAIAAYagAAAAED1r9Q/pZTFcRwcyKRzTbWXIFAjSSe2LOIKrZze3LcQs2zSonlnl5NC227nPBNe68A==", new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(344) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Employees");

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
                columns: new[] { "CreatedAt", "PasswordHash", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6135), "Password123", new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6136) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PasswordHash", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6138), "Password123", new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6139) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PasswordHash", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6140), "Password123", new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6140) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "PasswordHash", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6142), "Password123", new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6142) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "PasswordHash", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6144), "Password123", new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6144) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "PasswordHash", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6145), "Password123", new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6146) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "CreatedAt", "PasswordHash", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6148), "Password123", new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6148) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                columns: new[] { "CreatedAt", "PasswordHash", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6150), "Password123", new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6150) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                columns: new[] { "CreatedAt", "PasswordHash", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6151), "Password123", new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6152) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                columns: new[] { "CreatedAt", "PasswordHash", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6153), "Password123", new DateTime(2024, 10, 23, 10, 43, 53, 704, DateTimeKind.Local).AddTicks(6154) });
        }
    }
}
