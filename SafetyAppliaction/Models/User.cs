
using SafetyApplication.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SafetyAppliaction.Models
{
    //public class User
    //{
    //    [Key]
    //    public int UserId { get; set; }

    //    [ForeignKey("Employee")]
    //    public int EmployeeId { get; set; }

    //    [Required]
    //    [MaxLength(100)]
    //    public string Username { get; set; }

    //    [Required]
    //    public string PasswordHash { get; set; }

    //    [ForeignKey("Role")]
    //    public int RoleId { get; set; }

    //    public bool IsActive { get; set; }

    //    [Required]
    //    public DateTime CreatedAt { get; set; }

    //    [Required]
    //    public DateTime UpdatedAt { get; set; }

    //    // Navigation properties
    //    public Employee Employee { get; set; }
    //    public Role Role { get; set; }
    //}

    public class User
    {
        [Key]
        public int UserId { get; set; }

        // Relasi ke Employee
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public bool IsActive { get; set; }

        // Relasi ke Role
        public int RoleId { get; set; }
        public Role Role { get; set; }

        public DateTime? CreateDate { get; set; }
        public string? CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateBy { get; set; }
    }
}

