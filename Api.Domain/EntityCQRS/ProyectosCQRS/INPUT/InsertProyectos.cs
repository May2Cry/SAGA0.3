using Microsoft.EntityFrameworkCore;
using SAGA0._3.Api.Domain.Models;
using SAGA0._3.Api.Domain.ModelsDTOs;
using SAGA0._3.Api.InfraEstructura.Context;

namespace SAGA0._3.Api.Domain.EntityCQRS.ProyectosCQRS.INPUT
{
    public class InsertProyectos
    {
        private readonly BootcampG6Context _context;
        public InsertProyectos(BootcampG6Context context)
        {
            _context = context;
        }

        public async Task<bool> Guardar(ProyectoDTO pro)
        {
            try
            {
                var proye = new Proyectos();
                proye.Id= Guid.NewGuid();
                proye.TituloProyecto = pro.tituloProyeco;
                proye.DescripcionProyecto = pro.descripcionProyecto;
                proye.Anio = pro.anio;
                proye.FechaInicio= pro.fechaInicio;
                proye.FechaFinal = pro.fechaFinal;
                proye.FechaCreacion = pro.fechaCreacion;

                await _context.AddAsync(proye);
                var result = await _context.SaveChangesAsync();

                if(result>0) return true;

                return false;   

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
