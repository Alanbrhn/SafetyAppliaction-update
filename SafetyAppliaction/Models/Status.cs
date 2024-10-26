using System.ComponentModel.DataAnnotations;

namespace SafetyAppliaction.Models
{
    public class Status
    {
        [Key]
        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateBy { get; set; }

        // Relasi ke Request
        public ICollection<Request> Requests { get; set; }
    }
}
