using System.ComponentModel.DataAnnotations;

namespace SafetyAppliaction.Models
{
    public class StatusTransaction
    {
        [Key]
        public int StatusTransactionId { get; set; }

        [Required]
        [MaxLength(100)]
        public string StatusName { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public DateTime UpdatedAt { get; set; }

        // Navigation properties
        public ICollection<RequestTransaction> Requests { get; set; }
    }

}
