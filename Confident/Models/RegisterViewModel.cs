using System.ComponentModel.DataAnnotations;

namespace Confident.Models
{
    public class RegisterViewModel
    {
        [Display(Name = "İsim")]
        [Required(ErrorMessage = "İsim boş geçilemez")]
        public string? Name { get; set; }

        [Display(Name = "Soyisim")]
        [Required(ErrorMessage = "Soyisim boş geçilemez")]
        public string? Surname { get; set; }

        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Şifre boş geçilemez")]
        public string? Password { get; set; }

        [Display(Name = "Şifre Tekrar")]
        [Required(ErrorMessage = "Şifre tekrar boş geçilemez")]
        public string? ConfirmPassword { get; set; }

        [Display(Name = "Mail Adresi")]
        [Required(ErrorMessage = "Mail adresi boş geçilemez")]
        public string? Email { get; set; }

        [Display(Name = "Kullanıcı Adı")]
        public string? UserName { get; set; }

        [Display(Name = "Telefon Numarası")]
        [Required(ErrorMessage = "Telefon Numarası boş geçilemez")]
        public string? Phone { get; set; }

        public bool IsAcceptTheContract { get; set; }
    }
}
