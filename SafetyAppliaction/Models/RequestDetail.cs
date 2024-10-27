namespace SafetyAppliaction.Models
{
    public class RequestDetail
    {
        public int RequestId { get; set; }
        public string Title { get; set; }
        public string PotentialDangerousPoint { get; set; }
        public string TheMostDangerPoint { get; set; }
        public string KeyWord { get; set; }
        public string FormNo { get; set; }
        public string Departement { get; set; }
        public string Section { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string Company { get; set; }
        public int StatusId { get; set; }
        public int ApprovalStage { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateBy { get; set; }
        public List<EmployeeDto> Instructors { get; set; }
        public List<EmployeeDto> Attendants { get; set; }
    }
    public class EmployeeDto
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
    }
}
