using Microsoft.EntityFrameworkCore;
using SafetyAppliaction.Models;
using SafetyApplication.Models;

namespace SafetyApplication.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<ApprovalWorkflow> ApprovalWorkflows { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<RequestTransaction> RequestTransactions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<StatusTransaction> StatusTransactions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Worklist> Worklists { get; set; }
        public DbSet<JwtTokenInfo> JwtTokenInfos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Departments
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 1, DepartmentName = "HR", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Department { DepartmentId = 2, DepartmentName = "IT", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Department { DepartmentId = 3, DepartmentName = "Finance", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now }
            );

            // Seed Roles
            modelBuilder.Entity<Role>().HasData(
                new Role { RoleId = 1, RoleName = "User", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Role { RoleId = 2, RoleName = "Admin", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Role { RoleId = 3, RoleName = "Manager", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Role { RoleId = 4, RoleName = "Sekretaris", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Role { RoleId = 5, RoleName = "DeptHead", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now }
            );

            // Seed StatusTransactions
            modelBuilder.Entity<StatusTransaction>().HasData(
                new StatusTransaction { StatusTransactionId = 1, StatusName = "Checked", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new StatusTransaction { StatusTransactionId = 2, StatusName = "Reviewed", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new StatusTransaction { StatusTransactionId = 3, StatusName = "Approved", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new StatusTransaction { StatusTransactionId = 4, StatusName = "Rejected", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now }
            );

            // Seed Employees
            modelBuilder.Entity<Employee>().HasData(
                new Employee { EmployeeId = 1, EmployeeName = "John Doe", DepartmentId = 1, IsActive = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, Email = "test@gmail.com" },
                new Employee { EmployeeId = 2, EmployeeName = "Jane Smith", DepartmentId = 1, IsActive = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, Email = "test1@gmail.com" },
                new Employee { EmployeeId = 3, EmployeeName = "Robert Johnson", DepartmentId = 2, IsActive = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, Email = "test2@gmail.com" },
                new Employee { EmployeeId = 4, EmployeeName = "Emily Davis", DepartmentId = 2, IsActive = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now , Email = "test3@gmail.com" },
                new Employee { EmployeeId = 5, EmployeeName = "Michael Brown", DepartmentId = 2, IsActive = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now , Email = "test4@gmail.com" },
                new Employee { EmployeeId = 6, EmployeeName = "Jessica Miller", DepartmentId = 3, IsActive = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, Email = "test5@gmail.com" },
                new Employee { EmployeeId = 7, EmployeeName = "David Wilson", DepartmentId = 3, IsActive = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, Email = "test6@gmail.com" },
                new Employee { EmployeeId = 8, EmployeeName = "Sarah Lee", DepartmentId = 3, IsActive = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, Email = "test7@gmail.com" },
                new Employee { EmployeeId = 9, EmployeeName = "Daniel Moore", DepartmentId = 1, IsActive = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, Email = "test8@gmail.com" },
                new Employee { EmployeeId = 10, EmployeeName = "Susan Taylor", DepartmentId = 3, IsActive = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, Email = "test9@gmail.com" }
            );

            // Seed Users with assigned r
            modelBuilder.Entity<User>().HasData(
                // Users with Role 'User'
                new User { UserId = 1, EmployeeId = 1, Username = "jdoe", PasswordHash = "AQAAAAIAAYagAAAAED1r9Q/pZTFcRwcyKRzTbWXIFAjSSe2LOIKrZze3LcQs2zSonlnl5NC227nPBNe68A==", RoleId = 1, IsActive = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new User { UserId = 2, EmployeeId = 9, Username = "dmoore", PasswordHash = "AQAAAAIAAYagAAAAED1r9Q/pZTFcRwcyKRzTbWXIFAjSSe2LOIKrZze3LcQs2zSonlnl5NC227nPBNe68A==", RoleId = 1, IsActive = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },

                // Users with Role 'Sekretaris'
                new User { UserId = 3, EmployeeId = 2, Username = "jsmith", PasswordHash = "AQAAAAIAAYagAAAAED1r9Q/pZTFcRwcyKRzTbWXIFAjSSe2LOIKrZze3LcQs2zSonlnl5NC227nPBNe68A==", RoleId = 4, IsActive = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new User { UserId = 4, EmployeeId = 8, Username = "slee", PasswordHash = "AQAAAAIAAYagAAAAED1r9Q/pZTFcRwcyKRzTbWXIFAjSSe2LOIKrZze3LcQs2zSonlnl5NC227nPBNe68A==", RoleId = 4, IsActive = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },

                // Users with Role 'DeptHead'
                new User { UserId = 5, EmployeeId = 7, Username = "dwilson", PasswordHash = "AQAAAAIAAYagAAAAED1r9Q/pZTFcRwcyKRzTbWXIFAjSSe2LOIKrZze3LcQs2zSonlnl5NC227nPBNe68A==", RoleId = 5, IsActive = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new User { UserId = 6, EmployeeId = 6, Username = "jmiller", PasswordHash = "AQAAAAIAAYagAAAAED1r9Q/pZTFcRwcyKRzTbWXIFAjSSe2LOIKrZze3LcQs2zSonlnl5NC227nPBNe68A==", RoleId = 5, IsActive = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },

                // Users with Role 'Manager'
                new User { UserId = 7, EmployeeId = 3, Username = "rjohnson", PasswordHash = "AQAAAAIAAYagAAAAED1r9Q/pZTFcRwcyKRzTbWXIFAjSSe2LOIKrZze3LcQs2zSonlnl5NC227nPBNe68A==", RoleId = 3, IsActive = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new User { UserId = 8, EmployeeId = 4, Username = "edavis", PasswordHash = "AQAAAAIAAYagAAAAED1r9Q/pZTFcRwcyKRzTbWXIFAjSSe2LOIKrZze3LcQs2zSonlnl5NC227nPBNe68A==", RoleId = 3, IsActive = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },

                // Users with Role 'Admin'
                new User { UserId = 9, EmployeeId = 5, Username = "mbrown", PasswordHash = "AQAAAAIAAYagAAAAED1r9Q/pZTFcRwcyKRzTbWXIFAjSSe2LOIKrZze3LcQs2zSonlnl5NC227nPBNe68A==", RoleId = 2, IsActive = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new User { UserId = 10, EmployeeId = 10, Username = "staylor", PasswordHash = "AQAAAAIAAYagAAAAED1r9Q/pZTFcRwcyKRzTbWXIFAjSSe2LOIKrZze3LcQs2zSonlnl5NC227nPBNe68A==", RoleId = 2, IsActive = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now }
            );
        }

    }
}
