using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SafetyAppliaction.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTableWorklist : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Worklists",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 10, 26, 21, 17, 16, 1, DateTimeKind.Local).AddTicks(4956));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 10, 26, 21, 17, 16, 1, DateTimeKind.Local).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 10, 26, 21, 17, 16, 1, DateTimeKind.Local).AddTicks(4975));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 10, 26, 21, 17, 16, 1, DateTimeKind.Local).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 10, 26, 21, 17, 16, 1, DateTimeKind.Local).AddTicks(5134));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 10, 26, 21, 17, 16, 1, DateTimeKind.Local).AddTicks(5135));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 10, 26, 21, 17, 16, 1, DateTimeKind.Local).AddTicks(5137));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 10, 26, 21, 17, 16, 1, DateTimeKind.Local).AddTicks(5138));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 10, 26, 21, 17, 16, 1, DateTimeKind.Local).AddTicks(5139));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Worklists");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 10, 25, 14, 26, 24, 573, DateTimeKind.Local).AddTicks(2107));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 10, 25, 14, 26, 24, 573, DateTimeKind.Local).AddTicks(2122));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 10, 25, 14, 26, 24, 573, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 10, 25, 14, 26, 24, 573, DateTimeKind.Local).AddTicks(2267));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 10, 25, 14, 26, 24, 573, DateTimeKind.Local).AddTicks(2269));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 10, 25, 14, 26, 24, 573, DateTimeKind.Local).AddTicks(2270));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 10, 25, 14, 26, 24, 573, DateTimeKind.Local).AddTicks(2271));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 10, 25, 14, 26, 24, 573, DateTimeKind.Local).AddTicks(2272));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 10, 25, 14, 26, 24, 573, DateTimeKind.Local).AddTicks(2273));
        }
    }
}
