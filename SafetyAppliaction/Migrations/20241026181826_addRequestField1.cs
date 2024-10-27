using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SafetyAppliaction.Migrations
{
    /// <inheritdoc />
    public partial class addRequestField1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NextApprover",
                table: "Requests",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 10, 27, 1, 18, 24, 563, DateTimeKind.Local).AddTicks(5126));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 10, 27, 1, 18, 24, 563, DateTimeKind.Local).AddTicks(5142));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 10, 27, 1, 18, 24, 563, DateTimeKind.Local).AddTicks(5143));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 10, 27, 1, 18, 24, 563, DateTimeKind.Local).AddTicks(5312));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 10, 27, 1, 18, 24, 563, DateTimeKind.Local).AddTicks(5313));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 10, 27, 1, 18, 24, 563, DateTimeKind.Local).AddTicks(5315));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 10, 27, 1, 18, 24, 563, DateTimeKind.Local).AddTicks(5316));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 10, 27, 1, 18, 24, 563, DateTimeKind.Local).AddTicks(5317));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 10, 27, 1, 18, 24, 563, DateTimeKind.Local).AddTicks(5318));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NextApprover",
                table: "Requests");

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
    }
}
