using SafetyApplication.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SafetyAppliaction.Models
{
    public class ApprovalWorkflow
    {
        [Key]
        public int WorkflowId { get; set; }

        [ForeignKey("RequestTransaction")]
        public int RequestId { get; set; }

        [Range(1, int.MaxValue)]
        public int StepNumber { get; set; }

        [ForeignKey("Employee")]
        public int AssignedEmployeeId { get; set; }

        [ForeignKey("StatusTransaction")]
        public int ApprovalStatusId { get; set; }

        public DateTime? ApprovedAt { get; set; }

        [MaxLength(500)]
        public string Comments { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public DateTime UpdatedAt { get; set; }

        // Navigation properties
        public Employee AssignedEmployee { get; set; }
        public StatusTransaction ApprovalStatus { get; set; }
        public RequestTransaction Request { get; set; }
    }
}
