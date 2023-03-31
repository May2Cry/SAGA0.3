namespace SAGA0._3.Api.Domain.ModelsDTOs
{
    public class UsuarioResponse
    {
        public Guid IdUsuario { get; set; }
        public string? Username { get; set; }
        public string? Clave { get; set; }
        public bool? Activo { get; set; }
        public bool? EsAdministradorSistema { get; set; }
        public string? Identificacion { get; set; }
        public string? Nombre { get; set; }
    }
}
