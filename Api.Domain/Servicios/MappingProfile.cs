using AutoMapper;
using SAGA0._3.Api.Domain.Models;
using SAGA0._3.Api.Domain.ModelsDTOs;

namespace SAGA0._3.Api.Domain.Servicios
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<RegistrarUsuario, Usuario>()
           .ForMember(d => d.IdUsuario, x => x.MapFrom(model => Guid.NewGuid()))
           .ForMember(d => d.Activo, x => x.MapFrom(model => true))
           .ForMember(d => d.EsAdministradorSistema, x => x.MapFrom(model => false));

          
        }
    }
}
