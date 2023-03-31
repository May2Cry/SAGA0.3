using AutoMapper;
using SAGA0._3.Api.Domain.Adapters;
using SAGA0._3.Api.Domain.EntityCQRS.UsuarioCQRS.INPUT;
using SAGA0._3.Api.Domain.EntityCQRS.UsuarioCQRS.OUTPUT;
using SAGA0._3.Api.Domain.ModelsDTOs;
using SAGA0._3.Api.InfraEstructura.Context;

namespace SAGA0._3.Api.Domain.Repository
{
    public interface IUsuario
    {
        Task<UsuarioResponse> BuscarPorIdentificacion(string Id);
        Task<bool> InsertUser(RegistrarUsuario usuario);
    }

    public class Usuario : IUsuario {
        private readonly SearchByIdentificacionOutput _userOutput;
        private readonly UserAdapter _adapter;
        private readonly CreateUserInput _userInput;
        public Usuario(BootcampG6Context context, IMapper mapper)
        {
            _userOutput = new(context);
            _adapter = new(mapper);
            _userInput = new(context);
        }
        public async Task<UsuarioResponse> BuscarPorIdentificacion(string identificacion)
        {
            try
            {
                var result = await _userOutput.SearchByIdentificacion(identificacion);

               var res = new UsuarioResponse();
                res.EsAdministradorSistema = result.EsAdministradorSistema;
                res.Username = result.Username;
                res.Nombre = result.Nombre;
                res.Activo= result.Activo;
                res.Clave = result.Clave;   
                res.Identificacion = result.Identificacion;
                res.IdUsuario = result.IdUsuario;

                return res;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> InsertUser(RegistrarUsuario usuario)
        {
            try
            {
                var req = _adapter.UsuarioToResponse(usuario);

                await _userInput.CreateUser(req);

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }

}
