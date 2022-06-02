using AppWebInstitute.DataAccess.Modelos;
using AppWebInstitute.Services;
using Microsoft.AspNetCore.Mvc;
namespace AppWebInstitute.ApiInstitute.Controllers
{
    [Route("api/[Controller]")]
    [ApiController] //Indica que un tipo y todos los tipos derivados se usan para atender respuestas de API HTTP.
    public class AlumnosController : ControllerBase
    {

        private readonly IAlumnosServices _servicio;
        public AlumnosController(IAlumnosServices services)
        {
            _servicio = services;
        }
        //GET api/Alumnos
        [HttpGet]
        public async Task<ActionResult<List<Alumno>>> Listar()
        {
            var retorno = await _servicio.Listar();

            if(retorno.Objeto != null)
                return retorno.Objeto;
            else
                return StatusCode(retorno.Status,retorno.Error);

        }
    }
}