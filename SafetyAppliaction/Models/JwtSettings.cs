using System.ComponentModel.DataAnnotations;

namespace SafetyAppliaction.Models
{
    public class JwtSettings
    {
        public string SecretKey { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public int ExpiryInMinutes { get; set; }
    }
    public class JwtTokenInfo
    {
        [Key]
        public int Id { get; set; }
        public string SecretKey { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public int ExpiryInMinutes { get; set; }
        public DateTime CreatedAt { get; set; }
    }


}
