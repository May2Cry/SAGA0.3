using System.ComponentModel.DataAnnotations;

namespace SAGA0._3.Api.Domain.ModelsDTOs
{
    public class CredencialesUsuario
    {
        [Required]
        //[EmailAddress]
        public string Usuario { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
