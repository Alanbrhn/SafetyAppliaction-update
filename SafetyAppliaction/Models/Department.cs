using SafetyApplication.Models;
using System.ComponentModel.DataAnnotations;

namespace SafetyAppliaction.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }

        [Required]
        [MaxLength(100)]
        public string DepartmentName { get; set; }

        public int? AdminId { get; set; }
        public int? SecretaryId { get; set; }
        public int? DeptHeadId { get; set; }
        public int? ManagerId { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public DateTime UpdatedAt { get; set; }

        // Navigation properties
        public ICollection<Employee> Employees { get; set; }
    }
}
