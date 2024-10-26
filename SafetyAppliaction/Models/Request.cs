using SafetyApplication.Models;
using System.ComponentModel.DataAnnotations;

namespace SafetyAppliaction.Models
{
    public class Request
    {
        [Key]
        public int RequestId { get; set; }
        public string Title { get; set; }
        public string PotentialDangerousPoint { get; set; }
        public string TheMostDangerPoint { get; set; }
        public string KeyWord { get; set; }

        public ICollection<Employee> Instructors { get; set; }
        public ICollection<Employee> Attendants { get; set; }

        public string FormNo { get; set; }
        public string Departement { get; set; }
        public string Section { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string Company { get; set; }

        public int StatusId { get; set; }
        public Status Status { get; set; }

        public int ApprovalStage { get; set; }

        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateBy { get; set; }
    }
}
