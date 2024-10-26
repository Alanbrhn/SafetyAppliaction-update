using SafetyApplication.Models;

namespace SafetyAppliaction.Models
{
    public class RequestViewModel
    {
        public int RequestId { get; set; } // Auto increment
        public string Title { get; set; } // Free text
        public string PotentialDangerousPoint { get; set; } // Free text
        public string TheMostDangerPoint { get; set; } // Free text
        public string KeyWord { get; set; } // Free text
        public List<int> InstructorIds { get; set; } // Dropdown dari Employee, max 2
        public List<int> AttendantIds { get; set; } // Dropdown dari Employee, multi select
        public string FormNo { get; set; } // Format xxx-zz-00, xx-Feb-24
        public string Departement { get; set; } // Diambil dari user login
        public string Section { get; set; } // Shift 1, Shift 2, Shift 3
        public DateTime Date { get; set; } // Tanggal
        public TimeSpan Time { get; set; } // Waktu create
        public string Company { get; set; } // Nama company dari user login
        public string Status { get; set; } // Diambil dari tabel status
        public int ApprovalStage { get; set; } // Approval stage dari proses
        public DateTime CreateDate { get; set; } // Auto populate waktu create
        public string CreateBy { get; set; } // Diambil dari user login
        public DateTime? UpdateDate { get; set; } // Auto populate waktu update
        public string UpdateBy { get; set; } // Diambil dari user login saat update
    }

}
