using System.ComponentModel.DataAnnotations;

namespace ApiAuthentication.Model
{
    public class UserInfo
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public string? DisplayName { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
