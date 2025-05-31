using System.ComponentModel.DataAnnotations;

namespace MYWEBAPP.Models
{
    public class EditProfileViewModel
    {
        [StringLength(100, ErrorMessage = "Họ tên không được vượt quá 100 ký tự")]
        [Display(Name = "Họ tên đầy đủ")]
        public string? FullName { get; set; }

        [StringLength(20, ErrorMessage = "Số điện thoại không được vượt quá 20 ký tự")]
        [Display(Name = "Số điện thoại")]
        public string? PhoneNumber { get; set; }

        [StringLength(500, ErrorMessage = "Giới thiệu không được vượt quá 500 ký tự")]
        [Display(Name = "Giới thiệu")]
        public string? Bio { get; set; }
    }
}
