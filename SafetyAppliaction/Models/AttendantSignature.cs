using SafetyAppliaction.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SafetyApplication.Models
{
    public class AttendantSignature
    {
        [Key]
        public int SignatureId { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }

        [ForeignKey("RequestTransaction")]
        public int RequestId { get; set; }

        [Required]
        public DateTime SignedAt { get; set; }

        // Navigation properties
        public Employee Employee { get; set; }
        public RequestTransaction Request { get; set; }
    }
}
