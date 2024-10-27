using SafetyApplication.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SafetyAppliaction.Models
{
    //public class Worklist
    //{
    //    [Key]
    //    public int WorklistId { get; set; }

    //    [ForeignKey("RequestTransaction")]
    //    public int RequestId { get; set; }

    //    [ForeignKey("Employee")]
    //    public int AssignedEmployeeId { get; set; }

    //    [ForeignKey("StatusTransaction")]
    //    public int StatusTransactionId { get; set; }

    //    [Required]
    //    public DateTime CreatedAt { get; set; }

    //    [Required]
    //    public DateTime UpdatedAt { get; set; }

    //    // Navigation properties
    //    public RequestTransaction Request { get; set; }
    //    public Employee AssignedEmployee { get; set; }
    //    public StatusTransaction StatusTransaction { get; set; }
    //}

    public class Worklist
    {
        [Key]
        public int WorklistId { get; set; }

        // Relasi ke Request
        public int RequestId { get; set; }
        public Request Request { get; set; }

        public string Approver { get; set; }
        public int EmployeeId { get; set; }

        // Relasi ke Status
        public int StatusId { get; set; }
        public Status Status { get; set; }

        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateBy { get; set; }
        public int ApprovalStage { get; set; }
    }
}
