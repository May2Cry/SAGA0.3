using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SAGA0._3.Api.Domain.hateos;
using SAGA0._3.Api.Domain.Models;
using SAGA0._3.Api.Domain.ModelsDTOs;
using SAGA0._3.Api.Domain.Repository;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SAGA0._3.Api.Aplication.Controllers
{
    [ApiController]
    [Route("api/cuentas")]
    public class CuentasController : ControllerBase
    {
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly UserManager<IdentityUser> userManager;
        private readonly IUsuario IUsuario;
        private readonly IConfiguration configuration;
        public CuentasController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, IConfiguration configuration,
            IUsuario iUsuario)
        {
            this.signInManager = signInManager;
            this.configuration = configuration;
            this.IUsuario = iUsuario;
            this.userManager = userManager;
        }

        [HttpPost("registrar")] // api/cuentas/registrar
        public async Task<ActionResult<string>> Registrar(RegistrarUsuario credencialesUsuario)
        {

            var usuario = new IdentityUser
            {
                UserName = credencialesUsuario.Username,
                Email = credencialesUsuario.Email
            };

            var repetido = await userManager.FindByNameAsync(credencialesUsuario.Identificacion);

            if (repetido != null)
            {
                return "repetido";

            }
            var resultado = await userManager.CreateAsync(usuario, credencialesUsuario.Clave);

            if (resultado.Succeeded)
            {
                // poner codigo de crear tabla usuario
                await IUsuario.InsertUser(credencialesUsuario);

                var user = new CredencialesUsuario();
                user.Usuario = credencialesUsuario.Username;
                user.Password = credencialesUsuario.Clave;
                await ConstruirToken(user);
                return "ok";
            }

            return "error";



        }

        [HttpPost("login")]
        public async Task<ActionResult<Recurso<RespuestaAutenticacion>>> Login(CredencialesUsuario credencialesUsuario)
        {
            try
            {
                var resultado = await signInManager.PasswordSignInAsync(credencialesUsuario.Usuario,
                credencialesUsuario.Password, isPersistent: false, lockoutOnFailure: false);

                if (resultado.Succeeded)
                {
                    return await ConstruirToken(credencialesUsuario);
                }
                else
                {
                    return BadRequest("Login incorrecto");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return BadRequest();
            }
        }

        private async Task<Recurso<RespuestaAutenticacion>> ConstruirToken(CredencialesUsuario credencialesUsuario)
        {
            try
            {
                var usuario = await IUsuario.BuscarPorIdentificacion(credencialesUsuario.Usuario);

                if (usuario == null)
                {
                    return new Recurso<RespuestaAutenticacion>();
                }

                var claims = new List<Claim>()
                {
                    new Claim("identificacion", usuario.Identificacion),
                    new Claim("usuario", usuario.IdUsuario.ToString())
                };


                /*
                var usuario = await userManager.FindByEmailAsync(credencialesUsuario.Usuario);
                var claimsDB = await userManager.GetClaimsAsync(usuario);
                */
                //claims.AddRange(claimsDB);

                var llave = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["llavejwt"]));
                var creds = new SigningCredentials(llave, SecurityAlgorithms.HmacSha256);

                var expiracion = DateTime.UtcNow.AddYears(1);

                var securityToken = new JwtSecurityToken(issuer: null, audience: null, claims: claims,
                    expires: expiracion, signingCredentials: creds);

                Recurso<RespuestaAutenticacion> resp = new Recurso<RespuestaAutenticacion>();

                resp._embedded = new RespuestaAutenticacion()
                {
                    Token = new JwtSecurityTokenHandler().WriteToken(securityToken),
                    Expiracion = expiracion,
                    //Usuario = usuario
                };

                resp._links.Add(new DatoHATEOAS(
                    enlace: Url.Link("obtenerUsuario", new { }),
                    descripcion: "obtener-usuario",
                    metodo: "GET")
                    );
                resp._links.Add(new DatoHATEOAS(
                    enlace: Url.Link("obtenerEmpresaPorUsuario", new { }),
                    descripcion: "obtener-empresas-usuario",
                    metodo: "GET")
                    );

                return resp;
                /*return new RespuestaAutenticacion()
                {
                    Token = new JwtSecurityTokenHandler().WriteToken(securityToken),
                    Expiracion = expiracion,
                    Usuario = usuario
                };*/
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
