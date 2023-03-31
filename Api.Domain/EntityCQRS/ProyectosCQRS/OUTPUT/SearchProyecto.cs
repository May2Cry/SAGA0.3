using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SAGA0._3.Api.Domain.Models;
using SAGA0._3.Api.Domain.ModelsDTOs;
using SAGA0._3.Api.InfraEstructura.Context;

namespace SAGA0._3.Api.Domain.EntityCQRS.ProyectosCQRS.OUTPUT
{
    public class SearchProyecto
    {
        private readonly BootcampG6Context _context;
        public SearchProyecto(BootcampG6Context context)
        {
            _context = context;
        }

        public async Task<List<Proyectos>> SearchProyect(ProyectoDTO pro)
        {
            try
            {
                string SqlQuery = $"SELECT * FROM [dbo].[Proyectos] where ";

                if (pro.tituloProyeco != null && pro.tituloProyeco != "") SqlQuery += $"tituloProyecto='{pro.tituloProyeco}' AND ";
                if (pro.descripcionProyecto != null && pro.descripcionProyecto != "") SqlQuery += $" descripcionProyecto LIKE '%{pro.descripcionProyecto}%' AND ";
                if (pro.anio != null && pro.anio != 0) SqlQuery += $" ani ='{pro.anio}'";
                if (pro.fechaCreacion != null && pro.fechaCreacion != null) SqlQuery += $" fechaCreacion ='{pro.fechaCreacion}'";

                var data = await _context.Proyectos.FromSqlRaw(SqlQuery)
                 .OrderByDescending(x => x.FechaCreacion).ToListAsync();

                return data;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
