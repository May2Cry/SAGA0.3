using SAGA0._3.Api.Domain.EntityCQRS.ProyectosCQRS.INPUT;
using SAGA0._3.Api.Domain.EntityCQRS.ProyectosCQRS.OUTPUT;
using SAGA0._3.Api.Domain.Models;
using SAGA0._3.Api.Domain.ModelsDTOs;
using SAGA0._3.Api.InfraEstructura.Context;

namespace SAGA0._3.Api.Domain.Repository
{
    public interface IProyectoss
    {
        Task<List<Proyectos>> BuscarProyectoss(ProyectoDTO proyec);
        Task<bool> InsertarProyectos(ProyectoDTO proyec);
    }

    public class Proyectoss:IProyectoss
    {
        private readonly SearchProyecto _searchProyecto;
        private readonly InsertProyectos _insertProyectos;

        public Proyectoss(BootcampG6Context context)
        {
            _searchProyecto= new(context);
            _insertProyectos = new(context);
        }

        public async Task<bool> InsertarProyectos(ProyectoDTO proyec)
        {
            try
            {
                var result = await _insertProyectos.Guardar(proyec);
                return result;  
            }
            catch(Exception ex)
            {
                throw;
            }
        }
        public async Task<List<Proyectos>> BuscarProyectoss (ProyectoDTO proyec)
        {
            try
            {
                var result = await _searchProyecto.SearchProyect(proyec);

                return result;
            }
            catch(Exception ex)
            {
                throw;
            }
    
        }
    }
}
