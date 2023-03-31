using Microsoft.EntityFrameworkCore;
using SAGA0._3.Api.Domain.Models;
using SAGA0._3.Api.InfraEstructura.Context;

namespace SAGA0._3.Api.Domain.EntityCQRS.UsuarioCQRS.OUTPUT
{
    public class SearchByIdentificacionOutput
    {
        private readonly BootcampG6Context _context;
        public SearchByIdentificacionOutput(BootcampG6Context context)
        {
            _context = context;
        }

        public async Task<Usuario> SearchByIdentificacion(string identificacion)
        {
            var user = await _context.Usuario.FirstOrDefaultAsync(x => x.Username == identificacion && x.Activo == true);
            return user;
        }
    }
}
