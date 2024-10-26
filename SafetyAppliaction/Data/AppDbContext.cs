using Microsoft.EntityFrameworkCore;
using SafetyAppliaction.Models;
using SafetyApplication.Models;

namespace SafetyApplication.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Departement> Departements { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Worklist> Worklists { get; set; }
        public DbSet<JwtTokenInfo> JwtTokens { get; set; }
      

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Relationship configurations
            modelBuilder.Entity<Request>()
                .HasMany(r => r.Instructors)
                .WithMany()
                .UsingEntity(j => j.ToTable("RequestInstructors"));

            modelBuilder.Entity<Request>()
                .HasMany(r => r.Attendants)
                .WithMany()
                .UsingEntity(j => j.ToTable("RequestAttendants"));

            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Departements)
                .WithMany(d => d.Employees)
                .HasForeignKey(e => e.DepartmentId);

            modelBuilder.Entity<User>()
                .HasOne(u => u.Employee)
                .WithMany()
                .HasForeignKey(u => u.EmployeeId);

            modelBuilder.Entity<User>()
                .HasOne(u => u.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(u => u.RoleId);

            modelBuilder.Entity<Request>()
                .HasOne(r => r.Status)
                .WithMany(s => s.Requests)
                .HasForeignKey(r => r.StatusId);

            modelBuilder.Entity<Worklist>()
                .HasOne(w => w.Request)
                .WithMany()
                .HasForeignKey(w => w.RequestId);

            modelBuilder.Entity<Worklist>()
                .HasOne(w => w.Status)
                .WithMany()
                .HasForeignKey(w => w.StatusId);

            // Seeding data for Role
            modelBuilder.Entity<Role>().HasData(
                new Role { RoleId = 1, RoleName = "User", CreateDate = DateTime.Now, CreateBy = "System" },
                new Role { RoleId = 2, RoleName = "Admin", CreateDate = DateTime.Now, CreateBy = "System" },
                new Role { RoleId = 3, RoleName = "Manager", CreateDate = DateTime.Now, CreateBy = "System" }
            );

            // Seeding data for Status
            modelBuilder.Entity<Status>().HasData(
                new Status { StatusId = 1, StatusName = "waiting Checking", CreateDate = DateTime.Now, CreateBy = "System" },
                new Status { StatusId = 2, StatusName = "Checked", CreateDate = DateTime.Now, CreateBy = "System" },
                new Status { StatusId = 3, StatusName = "Reviewed", CreateDate = DateTime.Now, CreateBy = "System" },
                new Status { StatusId = 4, StatusName = "Approved DeptHead", CreateDate = DateTime.Now, CreateBy = "System" },
                new Status { StatusId = 5, StatusName = "Approved Manager", CreateDate = DateTime.Now, CreateBy = "System" },
                new Status { StatusId = 6, StatusName = "Rejected", CreateDate = DateTime.Now, CreateBy = "System" }
            );
            

           

            base.OnModelCreating(modelBuilder);
        }
    }

}
