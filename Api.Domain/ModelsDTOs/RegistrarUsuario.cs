using System.ComponentModel.DataAnnotations;

namespace SAGA0._3.Api.Domain.ModelsDTOs
{
    public class RegistrarUsuario
    {
        [Required]
        //[EmailAddress]
        public string Identificacion { get; set; }
        [Required]
        public string Clave { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
