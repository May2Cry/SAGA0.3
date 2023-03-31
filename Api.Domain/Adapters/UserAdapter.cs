using AutoMapper;
using SAGA0._3.Api.Domain.Models;
using SAGA0._3.Api.Domain.ModelsDTOs;

namespace SAGA0._3.Api.Domain.Adapters
{
    public class UserAdapter
    {
        private readonly IMapper _mapper;
        public UserAdapter(IMapper mapper)
        {
            _mapper = mapper;
        }

        public Usuario UsuarioToResponse(RegistrarUsuario doc)
        {
            var res = _mapper.Map<Usuario>(doc);

            return res;
        }

        public UsuarioResponse UsuarioToResponse(Usuario doc)
        {
            var res = _mapper.Map<UsuarioResponse>(doc);

            return res;
        }

        public IEnumerable<UsuarioResponse> UsuarioToResponseList(IEnumerable<Usuario> doc)
        {
            var res = _mapper.Map<IEnumerable<UsuarioResponse>>(doc);

            return res;
        }

     
    }
}
