using SafetyApplication.Models;
using System.ComponentModel.DataAnnotations;

namespace SafetyAppliaction.Models
{
    //public class Department
    //{
    //    [Key]
    //    public int DepartmentId { get; set; }

    //    [Required]
    //    [MaxLength(100)]
    //    public string DepartmentName { get; set; }

    //    public int? AdminId { get; set; }
    //    public int? SecretaryId { get; set; }
    //    public int? DeptHeadId { get; set; }
    //    public int? ManagerId { get; set; }

    //    [Required]
    //    public DateTime CreatedAt { get; set; }

    //    [Required]
    //    public DateTime UpdatedAt { get; set; }

    //    // Navigation properties
    //    public ICollection<Employee> Employees { get; set; }
    //}
    //public class Departement
    //{
    //    [Key]
    //    public int DepartmentId { get; set; }
    //    public string DepartmentName { get; set; }
    //    public int AdminId { get; set; }
    //    public int SecretaryId { get; set; }
    //    public int DeptHeadId { get; set; }
    //    public int ManagerId { get; set; }

    //    public DateTime CreateDate { get; set; }
    //    public string CreateBy { get; set; }
    //    public DateTime? UpdateDate { get; set; }
    //    public string? UpdateBy { get; set; }

    //    // Relasi ke Employee
    //    public ICollection<Employee> Employees { get; set; }
    //}

    public class Departement
    {
        [Key]
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        // Foreign Keys ke Employee
        public int AdminId { get; set; }
        public Employee Admin { get; set; }

        public int SecretaryId { get; set; }
        public Employee Secretary { get; set; }

        public int DeptHeadId { get; set; }
        public Employee DeptHead { get; set; }

        public int ManagerId { get; set; }
        public Employee Manager { get; set; }

        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateBy { get; set; }

        // Relasi ke Employee (untuk departemen ini)
        public ICollection<Employee> Employees { get; set; }
    }

}
