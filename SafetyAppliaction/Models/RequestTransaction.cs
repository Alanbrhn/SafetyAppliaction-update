using SafetyApplication.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SafetyAppliaction.Models
{
    public class RequestTransaction
    {
        [Key]
        public int RequestId { get; set; }

        [Required]
        [MaxLength(200)]
        public string RequestTitle { get; set; }

        // Foreign key untuk Employee
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }

        [MaxLength(500)]
        public string PotentialDangerousPoint { get; set; }

        [MaxLength(500)]
        public string MostDangerPoint { get; set; }

        [MaxLength(500)]
        public string CounterMeasure { get; set; }

        public string Keyword { get; set; }

        // InstructorId sebagai properti biasa (bukan Foreign Key)
        public int InstructorId { get; set; } // Tetap disimpan tapi tidak digunakan sebagai foreign key

        // Koleksi untuk menyimpan peserta yang hadir
        public ICollection<AttendantSignature> AttendantSignatures { get; set; }

        // Foreign key untuk StatusTransaction
        public int StatusId { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public DateTime UpdatedAt { get; set; }

        // Navigation properties

        // Properti navigasi untuk Employee
        public Employee Employee { get; set; }

        // Properti navigasi untuk StatusTransaction
        public StatusTransaction Status { get; set; }

        // Properti navigasi untuk Instructor (jika dibutuhkan di logika aplikasi)
        public Employee Instructor { get; set; } // Tidak lagi dianggap sebagai foreign key
    }
}
