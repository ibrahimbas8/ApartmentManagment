using System.ComponentModel.DataAnnotations;

namespace ApartmentManagment.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage = "Lütfen Kullanıcı Adını Giriniz...")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen Kullanıcı Şifreyi Giriniz...")]
        public string Password { get; set; }
    }
}
