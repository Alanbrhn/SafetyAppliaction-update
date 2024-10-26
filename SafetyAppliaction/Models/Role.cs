using System.ComponentModel.DataAnnotations;

namespace SafetyAppliaction.Models
{
    //public class Role
    //{
    //    [Key]
    //    public int RoleId { get; set; }

    //    [Required]
    //    [MaxLength(100)]
    //    public string RoleName { get; set; }

    //    [Required]
    //    public DateTime CreatedAt { get; set; }

    //    [Required]
    //    public DateTime UpdatedAt { get; set; }
    //}

    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateBy { get; set; }

        // Relasi ke User
        public ICollection<User> Users { get; set; }
    }

}
