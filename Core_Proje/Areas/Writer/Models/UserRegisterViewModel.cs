using System.ComponentModel.DataAnnotations;

namespace Core_Proje.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage ="Lütfen Adınızı giriniz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen Soyadınızı giriniz")]

        public string Surname { get; set; }
        [Required(ErrorMessage = "Lütfen Soyadınızı giriniz")]

        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "Lütfen resim url giriniz")]
         public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi giriniz")]

        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi tekrar giriniz")]
        [Compare ("Password",ErrorMessage ="Şifreler uyumlu değil")]

        public string ConfirmPassword { get; set; }
        public string Mail { get; set; }

    }
}
