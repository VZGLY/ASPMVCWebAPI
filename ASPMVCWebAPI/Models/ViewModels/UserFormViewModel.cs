using System.ComponentModel.DataAnnotations;

namespace ASPMVCWebAPI.Models
{
    public class UserFormViewModel
    {

        [Required(ErrorMessage = "C'est requis baraki.")]
        [EmailAddress(ErrorMessage = "C'est pas un mail, Voila quoi...")]
        [MinLength(5, ErrorMessage = "C'est pas assez long, on vaait dis 5 avec chantal de la conmpta...")]
        public string Email { get; set; }


        [Required]
        [MinLength(2)]
        public string Firstname { get; set; }

        public string Lastname { get; set; }
    }
}
