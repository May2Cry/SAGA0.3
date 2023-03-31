using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SAGA0._3.Api.Domain.ModelsDTOs;
using SAGA0._3.Api.Domain.Repository;

namespace SAGA0._3.Api.Aplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ProyectoController : Controller
    {
        private readonly IProyectoss _proyecto;

        public ProyectoController(IProyectoss proyecto)
        {
            _proyecto= proyecto;
        }


        [HttpGet]
        public async Task<ActionResult> BuscarProyecto(
            [FromQuery] ProyectoDTO proyecto)
        {
            var result = await _proyecto.BuscarProyectoss(proyecto);

            if(result!=null) return Ok(result);

            return BadRequest();    
        }

        [HttpPost]
        public async Task<ActionResult> GuardarProyecto(
       [FromQuery] ProyectoDTO proyecto)
        {
            var result = await _proyecto.InsertarProyectos(proyecto);

            if (result) return Ok();

            return BadRequest();
        }
    }
}
