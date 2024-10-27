using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SafetyAppliaction.Migrations
{
    /// <inheritdoc />
    public partial class addRequestField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 10, 27, 1, 10, 26, 394, DateTimeKind.Local).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 10, 27, 1, 10, 26, 394, DateTimeKind.Local).AddTicks(4981));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 10, 27, 1, 10, 26, 394, DateTimeKind.Local).AddTicks(4982));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 10, 27, 1, 10, 26, 394, DateTimeKind.Local).AddTicks(5092));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 10, 27, 1, 10, 26, 394, DateTimeKind.Local).AddTicks(5093));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 10, 27, 1, 10, 26, 394, DateTimeKind.Local).AddTicks(5094));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 10, 27, 1, 10, 26, 394, DateTimeKind.Local).AddTicks(5095));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 10, 27, 1, 10, 26, 394, DateTimeKind.Local).AddTicks(5096));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 10, 27, 1, 10, 26, 394, DateTimeKind.Local).AddTicks(5097));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
