using SafetyApplication.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SafetyAppliaction.Models
{
    public class Worklist
    {
        [Key]
        public int WorklistId { get; set; }

        [ForeignKey("RequestTransaction")]
        public int RequestId { get; set; }

        [ForeignKey("Employee")]
        public int AssignedEmployeeId { get; set; }

        [ForeignKey("StatusTransaction")]
        public int StatusTransactionId { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public DateTime UpdatedAt { get; set; }

        // Navigation properties
        public RequestTransaction Request { get; set; }
        public Employee AssignedEmployee { get; set; }
        public StatusTransaction StatusTransaction { get; set; }
    }
}
