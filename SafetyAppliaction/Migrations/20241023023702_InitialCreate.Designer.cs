﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SafetyApplication.Data;

#nullable disable

namespace SafetyAppliaction.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241023023702_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("SafetyAppliaction.Models.ApprovalWorkflow", b =>
                {
                    b.Property<int>("WorkflowId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ApprovalStatusId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ApprovedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("AssignedEmployeeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Comments")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("RequestId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StepNumber")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("WorkflowId");

                    b.HasIndex("ApprovalStatusId");

                    b.HasIndex("AssignedEmployeeId");

                    b.HasIndex("RequestId");

                    b.ToTable("ApprovalWorkflows");
                });

            modelBuilder.Entity("SafetyAppliaction.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AdminId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<int?>("DeptHeadId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ManagerId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SecretaryId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            DepartmentId = 1,
                            CreatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4186),
                            DepartmentName = "HR",
                            UpdatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4198)
                        },
                        new
                        {
                            DepartmentId = 2,
                            CreatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4199),
                            DepartmentName = "IT",
                            UpdatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4200)
                        },
                        new
                        {
                            DepartmentId = 3,
                            CreatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4201),
                            DepartmentName = "Finance",
                            UpdatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4201)
                        });
                });

            modelBuilder.Entity("SafetyAppliaction.Models.RequestTransaction", b =>
                {
                    b.Property<int>("RequestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CounterMeasure")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MostDangerPoint")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<string>("PotentialDangerousPoint")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<string>("RequestTitle")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<int>("StatusId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("RequestId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("StatusId");

                    b.ToTable("RequestTransactions");
                });

            modelBuilder.Entity("SafetyAppliaction.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            RoleId = 1,
                            CreatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4315),
                            RoleName = "User",
                            UpdatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4316)
                        },
                        new
                        {
                            RoleId = 2,
                            CreatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4317),
                            RoleName = "Admin",
                            UpdatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4318)
                        },
                        new
                        {
                            RoleId = 3,
                            CreatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4319),
                            RoleName = "Manager",
                            UpdatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4319)
                        },
                        new
                        {
                            RoleId = 4,
                            CreatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4320),
                            RoleName = "Sekretaris",
                            UpdatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4321)
                        },
                        new
                        {
                            RoleId = 5,
                            CreatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4321),
                            RoleName = "DeptHead",
                            UpdatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4322)
                        });
                });

            modelBuilder.Entity("SafetyAppliaction.Models.StatusTransaction", b =>
                {
                    b.Property<int>("StatusTransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("StatusName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("StatusTransactionId");

                    b.ToTable("StatusTransactions");

                    b.HasData(
                        new
                        {
                            StatusTransactionId = 1,
                            CreatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4347),
                            StatusName = "Checked",
                            UpdatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4347)
                        },
                        new
                        {
                            StatusTransactionId = 2,
                            CreatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4349),
                            StatusName = "Reviewed",
                            UpdatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4350)
                        },
                        new
                        {
                            StatusTransactionId = 3,
                            CreatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4350),
                            StatusName = "Approved",
                            UpdatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4351)
                        },
                        new
                        {
                            StatusTransactionId = 4,
                            CreatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4352),
                            StatusName = "Rejected",
                            UpdatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4352)
                        });
                });

            modelBuilder.Entity("SafetyAppliaction.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("RoleId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            CreatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4444),
                            EmployeeId = 1,
                            IsActive = true,
                            PasswordHash = "Password123",
                            RoleId = 1,
                            UpdatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4445),
                            Username = "jdoe"
                        },
                        new
                        {
                            UserId = 2,
                            CreatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4447),
                            EmployeeId = 9,
                            IsActive = true,
                            PasswordHash = "Password123",
                            RoleId = 1,
                            UpdatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4448),
                            Username = "dmoore"
                        },
                        new
                        {
                            UserId = 3,
                            CreatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4449),
                            EmployeeId = 2,
                            IsActive = true,
                            PasswordHash = "Password123",
                            RoleId = 4,
                            UpdatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4449),
                            Username = "jsmith"
                        },
                        new
                        {
                            UserId = 4,
                            CreatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4450),
                            EmployeeId = 8,
                            IsActive = true,
                            PasswordHash = "Password123",
                            RoleId = 4,
                            UpdatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4451),
                            Username = "slee"
                        },
                        new
                        {
                            UserId = 5,
                            CreatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4452),
                            EmployeeId = 7,
                            IsActive = true,
                            PasswordHash = "Password123",
                            RoleId = 5,
                            UpdatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4453),
                            Username = "dwilson"
                        },
                        new
                        {
                            UserId = 6,
                            CreatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4454),
                            EmployeeId = 6,
                            IsActive = true,
                            PasswordHash = "Password123",
                            RoleId = 5,
                            UpdatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4454),
                            Username = "jmiller"
                        },
                        new
                        {
                            UserId = 7,
                            CreatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4456),
                            EmployeeId = 3,
                            IsActive = true,
                            PasswordHash = "Password123",
                            RoleId = 3,
                            UpdatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4456),
                            Username = "rjohnson"
                        },
                        new
                        {
                            UserId = 8,
                            CreatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4457),
                            EmployeeId = 4,
                            IsActive = true,
                            PasswordHash = "Password123",
                            RoleId = 3,
                            UpdatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4458),
                            Username = "edavis"
                        },
                        new
                        {
                            UserId = 9,
                            CreatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4460),
                            EmployeeId = 5,
                            IsActive = true,
                            PasswordHash = "Password123",
                            RoleId = 2,
                            UpdatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4460),
                            Username = "mbrown"
                        },
                        new
                        {
                            UserId = 10,
                            CreatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4462),
                            EmployeeId = 10,
                            IsActive = true,
                            PasswordHash = "Password123",
                            RoleId = 2,
                            UpdatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4462),
                            Username = "staylor"
                        });
                });

            modelBuilder.Entity("SafetyAppliaction.Models.Worklist", b =>
                {
                    b.Property<int>("WorklistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AssignedEmployeeId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("RequestId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StatusTransactionId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("WorklistId");

                    b.HasIndex("AssignedEmployeeId");

                    b.HasIndex("RequestId");

                    b.HasIndex("StatusTransactionId");

                    b.ToTable("Worklists");
                });

            modelBuilder.Entity("SafetyApplication.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("EmployeeId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            CreatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4375),
                            DepartmentId = 1,
                            EmployeeName = "John Doe",
                            IsActive = true,
                            UpdatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4376)
                        },
                        new
                        {
                            EmployeeId = 2,
                            CreatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4377),
                            DepartmentId = 1,
                            EmployeeName = "Jane Smith",
                            IsActive = true,
                            UpdatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4378)
                        },
                        new
                        {
                            EmployeeId = 3,
                            CreatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4382),
                            DepartmentId = 2,
                            EmployeeName = "Robert Johnson",
                            IsActive = true,
                            UpdatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4383)
                        },
                        new
                        {
                            EmployeeId = 4,
                            CreatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4384),
                            DepartmentId = 2,
                            EmployeeName = "Emily Davis",
                            IsActive = true,
                            UpdatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4384)
                        },
                        new
                        {
                            EmployeeId = 5,
                            CreatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4385),
                            DepartmentId = 2,
                            EmployeeName = "Michael Brown",
                            IsActive = true,
                            UpdatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4386)
                        },
                        new
                        {
                            EmployeeId = 6,
                            CreatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4387),
                            DepartmentId = 3,
                            EmployeeName = "Jessica Miller",
                            IsActive = true,
                            UpdatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4387)
                        },
                        new
                        {
                            EmployeeId = 7,
                            CreatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4412),
                            DepartmentId = 3,
                            EmployeeName = "David Wilson",
                            IsActive = true,
                            UpdatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4412)
                        },
                        new
                        {
                            EmployeeId = 8,
                            CreatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4413),
                            DepartmentId = 3,
                            EmployeeName = "Sarah Lee",
                            IsActive = true,
                            UpdatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4414)
                        },
                        new
                        {
                            EmployeeId = 9,
                            CreatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4415),
                            DepartmentId = 1,
                            EmployeeName = "Daniel Moore",
                            IsActive = true,
                            UpdatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4415)
                        },
                        new
                        {
                            EmployeeId = 10,
                            CreatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4416),
                            DepartmentId = 3,
                            EmployeeName = "Susan Taylor",
                            IsActive = true,
                            UpdatedAt = new DateTime(2024, 10, 23, 9, 37, 0, 346, DateTimeKind.Local).AddTicks(4417)
                        });
                });

            modelBuilder.Entity("SafetyAppliaction.Models.ApprovalWorkflow", b =>
                {
                    b.HasOne("SafetyAppliaction.Models.StatusTransaction", "ApprovalStatus")
                        .WithMany()
                        .HasForeignKey("ApprovalStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SafetyApplication.Models.Employee", "AssignedEmployee")
                        .WithMany("ApprovalWorkflows")
                        .HasForeignKey("AssignedEmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SafetyAppliaction.Models.RequestTransaction", "Request")
                        .WithMany()
                        .HasForeignKey("RequestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApprovalStatus");

                    b.Navigation("AssignedEmployee");

                    b.Navigation("Request");
                });

            modelBuilder.Entity("SafetyAppliaction.Models.RequestTransaction", b =>
                {
                    b.HasOne("SafetyAppliaction.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SafetyApplication.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SafetyAppliaction.Models.StatusTransaction", "Status")
                        .WithMany("Requests")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Employee");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("SafetyAppliaction.Models.User", b =>
                {
                    b.HasOne("SafetyApplication.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SafetyAppliaction.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("SafetyAppliaction.Models.Worklist", b =>
                {
                    b.HasOne("SafetyApplication.Models.Employee", "AssignedEmployee")
                        .WithMany()
                        .HasForeignKey("AssignedEmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SafetyAppliaction.Models.RequestTransaction", "Request")
                        .WithMany()
                        .HasForeignKey("RequestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SafetyAppliaction.Models.StatusTransaction", "StatusTransaction")
                        .WithMany()
                        .HasForeignKey("StatusTransactionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AssignedEmployee");

                    b.Navigation("Request");

                    b.Navigation("StatusTransaction");
                });

            modelBuilder.Entity("SafetyApplication.Models.Employee", b =>
                {
                    b.HasOne("SafetyAppliaction.Models.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("SafetyAppliaction.Models.Department", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("SafetyAppliaction.Models.StatusTransaction", b =>
                {
                    b.Navigation("Requests");
                });

            modelBuilder.Entity("SafetyApplication.Models.Employee", b =>
                {
                    b.Navigation("ApprovalWorkflows");
                });
#pragma warning restore 612, 618
        }
    }
}
