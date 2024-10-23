using SafetyAppliaction.Models;
using SafetyApplication.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SafetyAppliaction.Models
{
    public class RequestTransaction
    {
        [Key]
        public int RequestId { get; set; }

        [Required]
        [MaxLength(200)]
        public string RequestTitle { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }

        [MaxLength(500)]
        public string PotentialDangerousPoint { get; set; }

        [MaxLength(500)]
        public string MostDangerPoint { get; set; }

        [MaxLength(500)]
        public string CounterMeasure { get; set; }

        [ForeignKey("StatusTransaction")]
        public int StatusId { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public DateTime UpdatedAt { get; set; }

        // Navigation properties
        public Employee Employee { get; set; }
        public Department Department { get; set; }
        public StatusTransaction Status { get; set; }
    }
}
   
