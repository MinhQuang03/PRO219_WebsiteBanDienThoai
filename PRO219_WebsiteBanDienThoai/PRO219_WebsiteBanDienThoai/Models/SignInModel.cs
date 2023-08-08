using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PRO219_WebsiteBanDienThoai.Models
{
    public class SignInModel
    {
        [EmailAddress]
        public string Email { get; set; }     
        [Required]
        public string UserName { get; set; } = null!;
        [PasswordPropertyText,Required]
        public string Password { get; set; } = null!;

    }
}
