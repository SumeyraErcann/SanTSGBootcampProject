using System;
using System.ComponentModel.DataAnnotations;

namespace BootcampProje.Domain.Users
{
    public class User : ISoftDelete
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "UserName is required")]
        [StringLength(50, ErrorMessage = "İsminiz 50 karakterden uzun olamaz")]
        [Display(Name = "Kullanıcı Adı")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, ErrorMessage = "{0} en az {2} karakter veya rakam içermelidir!!", MinimumLength = 8)]
        [DataType(DataType.Password)]
        [Display(Name = "Kullanıcı Şifresi")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        [Display(Name = "Kullanıcı Maili")]
        public string Email { get; set; }
        
        public char RecStatus { get; set; } = 'A'; //for soft delete

        public DateTime RegistrationDate { get; set; } = DateTime.Now;
    }
}
