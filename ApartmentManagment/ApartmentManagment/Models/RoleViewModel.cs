using System.ComponentModel.DataAnnotations;

namespace ApartmentManagment.Models
{
    public class RoleViewModel
    {
        [Required(ErrorMessage = "Lütfen Rol Adı Giriniz...")]
        public string Name { get; set; }
    }
}
