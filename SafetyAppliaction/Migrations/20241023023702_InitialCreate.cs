using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SafetyAppliaction.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DepartmentName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    AdminId = table.Column<int>(type: "INTEGER", nullable: true),
                    SecretaryId = table.Column<int>(type: "INTEGER", nullable: true),
                    DeptHeadId = table.Column<int>(type: "INTEGER", nullable: true),
                    ManagerId = table.Column<int>(type: "INTEGER", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "StatusTransactions",
                columns: table => new
                {
                    StatusTransactionId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StatusName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusTransactions", x => x.StatusTransactionId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EmployeeName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    DepartmentId = table.Column<int>(type: "INTEGER", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RequestTransactions",
                columns: table => new
                {
                    RequestId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RequestTitle = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: false),
                    DepartmentId = table.Column<int>(type: "INTEGER", nullable: false),
                    PotentialDangerousPoint = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    MostDangerPoint = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    CounterMeasure = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    StatusId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestTransactions", x => x.RequestId);
                    table.ForeignKey(
                        name: "FK_RequestTransactions_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RequestTransactions_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RequestTransactions_StatusTransactions_StatusId",
                        column: x => x.StatusId,
                        principalTable: "StatusTransactions",
                        principalColumn: "StatusTransactionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: false),
                    Username = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<int>(type: "INTEGER", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApprovalWorkflows",
                columns: table => new
                {
                    WorkflowId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RequestId = table.Column<int>(type: "INTEGER", nullable: false),
                    StepNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    AssignedEmployeeId = table.Column<int>(type: "INTEGER", nullable: false),
                    ApprovalStatusId = table.Column<int>(type: "INTEGER", nullable: false),
                    ApprovedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Comments = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApprovalWorkflows", x => x.WorkflowId);
                    table.ForeignKey(
                        name: "FK_ApprovalWorkflows_Employees_AssignedEmployeeId",
                        column: x => x.AssignedEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApprovalWorkflows_RequestTransactions_RequestId",
                        column: x => x.RequestId,
                        principalTable: "RequestTransactions",
                        principalColumn: "RequestId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApprovalWorkflows_StatusTransactions_ApprovalStatusId",
                        column: x => x.ApprovalStatusId,
                        principalTable: "StatusTransactions",
                        principalColumn: "StatusTransactionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Worklists",
                columns: table => new
                {
                    WorklistId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RequestId = table.Column<int>(type: "INTEGER", nullable: false),
                    AssignedEmployeeId = table.Column<int>(type: "INTEGER", nullable: false),
                    StatusTransactionId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Worklists", x => x.WorklistId);
                    table.ForeignKey(
                        name: "FK_Worklists_Employees_AssignedEmployeeId",
                        column: x => x.AssignedEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Worklists_RequestTransactions_RequestId",
                        column: x => x.RequestId,
                        principalTable: "RequestTransactions",
                        principalColumn: "RequestId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Worklists_StatusTransactions_StatusTransactionId",
                        column: x => x.StatusTransactionId,
                        principalTable: "StatusTransactions",
                        principalColumn: "StatusTransactionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "AdminId", "CreatedAt", "DepartmentName", "DeptHeadId", "ManagerId", "SecretaryId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4186), "HR", null, null, null, new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4198) },
                    { 2, null, new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4199), "IT", null, null, null, new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4200) },
                    { 3, null, new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4201), "Finance", null, null, null, new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4201) }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "CreatedAt", "RoleName", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4315), "User", new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4316) },
                    { 2, new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4317), "Admin", new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4318) },
                    { 3, new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4319), "Manager", new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4319) },
                    { 4, new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4320), "Sekretaris", new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4321) },
                    { 5, new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4321), "DeptHead", new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4322) }
                });

            migrationBuilder.InsertData(
                table: "StatusTransactions",
                columns: new[] { "StatusTransactionId", "CreatedAt", "StatusName", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4347), "Checked", new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4347) },
                    { 2, new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4349), "Reviewed", new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4350) },
                    { 3, new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4350), "Approved", new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4351) },
                    { 4, new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4352), "Rejected", new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4352) }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "CreatedAt", "DepartmentId", "EmployeeName", "IsActive", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4375), 1, "John Doe", true, new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4376) },
                    { 2, new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4377), 1, "Jane Smith", true, new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4378) },
                    { 3, new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4382), 2, "Robert Johnson", true, new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4383) },
                    { 4, new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4384), 2, "Emily Davis", true, new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4384) },
                    { 5, new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4385), 2, "Michael Brown", true, new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4386) },
                    { 6, new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4387), 3, "Jessica Miller", true, new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4387) },
                    { 7, new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4412), 3, "David Wilson", true, new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4412) },
                    { 8, new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4413), 3, "Sarah Lee", true, new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4414) },
                    { 9, new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4415), 1, "Daniel Moore", true, new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4415) },
                    { 10, new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4416), 3, "Susan Taylor", true, new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4417) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreatedAt", "EmployeeId", "IsActive", "PasswordHash", "RoleId", "UpdatedAt", "Username" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4444), 1, true, "Password123", 1, new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4445), "jdoe" },
                    { 2, new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4447), 9, true, "Password123", 1, new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4448), "dmoore" },
                    { 3, new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4449), 2, true, "Password123", 4, new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4449), "jsmith" },
                    { 4, new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4450), 8, true, "Password123", 4, new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4451), "slee" },
                    { 5, new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4452), 7, true, "Password123", 5, new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4453), "dwilson" },
                    { 6, new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4454), 6, true, "Password123", 5, new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4454), "jmiller" },
                    { 7, new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4456), 3, true, "Password123", 3, new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4456), "rjohnson" },
                    { 8, new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4457), 4, true, "Password123", 3, new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4458), "edavis" },
                    { 9, new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4460), 5, true, "Password123", 2, new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4460), "mbrown" },
                    { 10, new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4462), 10, true, "Password123", 2, new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4462), "staylor" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApprovalWorkflows_ApprovalStatusId",
                table: "ApprovalWorkflows",
                column: "ApprovalStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ApprovalWorkflows_AssignedEmployeeId",
                table: "ApprovalWorkflows",
                column: "AssignedEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_ApprovalWorkflows_RequestId",
                table: "ApprovalWorkflows",
                column: "RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestTransactions_DepartmentId",
                table: "RequestTransactions",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestTransactions_EmployeeId",
                table: "RequestTransactions",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestTransactions_StatusId",
                table: "RequestTransactions",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_EmployeeId",
                table: "Users",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Worklists_AssignedEmployeeId",
                table: "Worklists",
                column: "AssignedEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Worklists_RequestId",
                table: "Worklists",
                column: "RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_Worklists_StatusTransactionId",
                table: "Worklists",
                column: "StatusTransactionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApprovalWorkflows");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Worklists");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "RequestTransactions");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "StatusTransactions");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
