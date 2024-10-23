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
    [Migration("20241023035114_AddEmailandChangeHashPassword")]
    partial class AddEmailandChangeHashPassword
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
                            CreatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(97),
                            DepartmentName = "HR",
                            UpdatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(111)
                        },
                        new
                        {
                            DepartmentId = 2,
                            CreatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(113),
                            DepartmentName = "IT",
                            UpdatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(113)
                        },
                        new
                        {
                            DepartmentId = 3,
                            CreatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(114),
                            DepartmentName = "Finance",
                            UpdatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(115)
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
                            CreatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(224),
                            RoleName = "User",
                            UpdatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(224)
                        },
                        new
                        {
                            RoleId = 2,
                            CreatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(226),
                            RoleName = "Admin",
                            UpdatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(226)
                        },
                        new
                        {
                            RoleId = 3,
                            CreatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(227),
                            RoleName = "Manager",
                            UpdatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(228)
                        },
                        new
                        {
                            RoleId = 4,
                            CreatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(229),
                            RoleName = "Sekretaris",
                            UpdatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(229)
                        },
                        new
                        {
                            RoleId = 5,
                            CreatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(230),
                            RoleName = "DeptHead",
                            UpdatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(231)
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
                            CreatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(253),
                            StatusName = "Checked",
                            UpdatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(254)
                        },
                        new
                        {
                            StatusTransactionId = 2,
                            CreatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(256),
                            StatusName = "Reviewed",
                            UpdatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(257)
                        },
                        new
                        {
                            StatusTransactionId = 3,
                            CreatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(258),
                            StatusName = "Approved",
                            UpdatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(258)
                        },
                        new
                        {
                            StatusTransactionId = 4,
                            CreatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(259),
                            StatusName = "Rejected",
                            UpdatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(260)
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
                            CreatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(326),
                            EmployeeId = 1,
                            IsActive = true,
                            PasswordHash = "AQAAAAIAAYagAAAAED1r9Q/pZTFcRwcyKRzTbWXIFAjSSe2LOIKrZze3LcQs2zSonlnl5NC227nPBNe68A==",
                            RoleId = 1,
                            UpdatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(326),
                            Username = "jdoe"
                        },
                        new
                        {
                            UserId = 2,
                            CreatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(328),
                            EmployeeId = 9,
                            IsActive = true,
                            PasswordHash = "AQAAAAIAAYagAAAAED1r9Q/pZTFcRwcyKRzTbWXIFAjSSe2LOIKrZze3LcQs2zSonlnl5NC227nPBNe68A==",
                            RoleId = 1,
                            UpdatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(329),
                            Username = "dmoore"
                        },
                        new
                        {
                            UserId = 3,
                            CreatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(330),
                            EmployeeId = 2,
                            IsActive = true,
                            PasswordHash = "AQAAAAIAAYagAAAAED1r9Q/pZTFcRwcyKRzTbWXIFAjSSe2LOIKrZze3LcQs2zSonlnl5NC227nPBNe68A==",
                            RoleId = 4,
                            UpdatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(330),
                            Username = "jsmith"
                        },
                        new
                        {
                            UserId = 4,
                            CreatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(333),
                            EmployeeId = 8,
                            IsActive = true,
                            PasswordHash = "AQAAAAIAAYagAAAAED1r9Q/pZTFcRwcyKRzTbWXIFAjSSe2LOIKrZze3LcQs2zSonlnl5NC227nPBNe68A==",
                            RoleId = 4,
                            UpdatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(333),
                            Username = "slee"
                        },
                        new
                        {
                            UserId = 5,
                            CreatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(335),
                            EmployeeId = 7,
                            IsActive = true,
                            PasswordHash = "AQAAAAIAAYagAAAAED1r9Q/pZTFcRwcyKRzTbWXIFAjSSe2LOIKrZze3LcQs2zSonlnl5NC227nPBNe68A==",
                            RoleId = 5,
                            UpdatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(335),
                            Username = "dwilson"
                        },
                        new
                        {
                            UserId = 6,
                            CreatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(337),
                            EmployeeId = 6,
                            IsActive = true,
                            PasswordHash = "AQAAAAIAAYagAAAAED1r9Q/pZTFcRwcyKRzTbWXIFAjSSe2LOIKrZze3LcQs2zSonlnl5NC227nPBNe68A==",
                            RoleId = 5,
                            UpdatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(337),
                            Username = "jmiller"
                        },
                        new
                        {
                            UserId = 7,
                            CreatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(338),
                            EmployeeId = 3,
                            IsActive = true,
                            PasswordHash = "AQAAAAIAAYagAAAAED1r9Q/pZTFcRwcyKRzTbWXIFAjSSe2LOIKrZze3LcQs2zSonlnl5NC227nPBNe68A==",
                            RoleId = 3,
                            UpdatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(339),
                            Username = "rjohnson"
                        },
                        new
                        {
                            UserId = 8,
                            CreatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(340),
                            EmployeeId = 4,
                            IsActive = true,
                            PasswordHash = "AQAAAAIAAYagAAAAED1r9Q/pZTFcRwcyKRzTbWXIFAjSSe2LOIKrZze3LcQs2zSonlnl5NC227nPBNe68A==",
                            RoleId = 3,
                            UpdatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(341),
                            Username = "edavis"
                        },
                        new
                        {
                            UserId = 9,
                            CreatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(342),
                            EmployeeId = 5,
                            IsActive = true,
                            PasswordHash = "AQAAAAIAAYagAAAAED1r9Q/pZTFcRwcyKRzTbWXIFAjSSe2LOIKrZze3LcQs2zSonlnl5NC227nPBNe68A==",
                            RoleId = 2,
                            UpdatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(342),
                            Username = "mbrown"
                        },
                        new
                        {
                            UserId = 10,
                            CreatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(344),
                            EmployeeId = 10,
                            IsActive = true,
                            PasswordHash = "AQAAAAIAAYagAAAAED1r9Q/pZTFcRwcyKRzTbWXIFAjSSe2LOIKrZze3LcQs2zSonlnl5NC227nPBNe68A==",
                            RoleId = 2,
                            UpdatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(344),
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

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

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
                            CreatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(280),
                            DepartmentId = 1,
                            Email = "test@gmail.com",
                            EmployeeName = "John Doe",
                            IsActive = true,
                            UpdatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(281)
                        },
                        new
                        {
                            EmployeeId = 2,
                            CreatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(283),
                            DepartmentId = 1,
                            Email = "test1@gmail.com",
                            EmployeeName = "Jane Smith",
                            IsActive = true,
                            UpdatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(284)
                        },
                        new
                        {
                            EmployeeId = 3,
                            CreatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(285),
                            DepartmentId = 2,
                            Email = "test2@gmail.com",
                            EmployeeName = "Robert Johnson",
                            IsActive = true,
                            UpdatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(286)
                        },
                        new
                        {
                            EmployeeId = 4,
                            CreatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(287),
                            DepartmentId = 2,
                            Email = "test3@gmail.com",
                            EmployeeName = "Emily Davis",
                            IsActive = true,
                            UpdatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(287)
                        },
                        new
                        {
                            EmployeeId = 5,
                            CreatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(289),
                            DepartmentId = 2,
                            Email = "test4@gmail.com",
                            EmployeeName = "Michael Brown",
                            IsActive = true,
                            UpdatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(289)
                        },
                        new
                        {
                            EmployeeId = 6,
                            CreatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(291),
                            DepartmentId = 3,
                            Email = "test5@gmail.com",
                            EmployeeName = "Jessica Miller",
                            IsActive = true,
                            UpdatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(291)
                        },
                        new
                        {
                            EmployeeId = 7,
                            CreatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(292),
                            DepartmentId = 3,
                            Email = "test6@gmail.com",
                            EmployeeName = "David Wilson",
                            IsActive = true,
                            UpdatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(293)
                        },
                        new
                        {
                            EmployeeId = 8,
                            CreatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(294),
                            DepartmentId = 3,
                            Email = "test7@gmail.com",
                            EmployeeName = "Sarah Lee",
                            IsActive = true,
                            UpdatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(295)
                        },
                        new
                        {
                            EmployeeId = 9,
                            CreatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(296),
                            DepartmentId = 1,
                            Email = "test8@gmail.com",
                            EmployeeName = "Daniel Moore",
                            IsActive = true,
                            UpdatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(296)
                        },
                        new
                        {
                            EmployeeId = 10,
                            CreatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(299),
                            DepartmentId = 3,
                            Email = "test9@gmail.com",
                            EmployeeName = "Susan Taylor",
                            IsActive = true,
                            UpdatedAt = new DateTime(2024, 10, 23, 10, 51, 14, 188, DateTimeKind.Local).AddTicks(299)
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