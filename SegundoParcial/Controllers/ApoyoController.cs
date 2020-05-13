using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using Logica;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SegundoParcial.Models;


namespace SegundoParcial.Controllers
{
    [Route("api/apoyo")]
    [ApiController]
    public class ApoyoController: ControllerBase
    {
        private readonly ApoyoService _apyService;
        public IConfiguration Configuration { get; }
        public ApoyoController(IConfiguration configuration, GeneralContext _GContext)
        {
            Configuration = configuration;
            //string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            _apyService = new ApoyoService(_GContext);
        }
        // GET: api/Apoyo
        [HttpGet]
        public IEnumerable<ApoyoViewModel> Gets()
        {
            var apys = _apyService.ConsultarTodos().Select(p=> new ApoyoViewModel(p));
            return apys;
        }

        // POST: api/Apoyo
        [HttpPost]
        public ActionResult<ApoyoViewModel> Post(ApoyoInputModel apyInput)
        {
            Apoyo apy = MapearApoyo(apyInput);
            var response = _apyService.Guardar(apy);
            if (response == null)
            {
                return BadRequest("No se permiten guardar identificaciones repetidas");
            }
            return Ok(response);
        }

        private Apoyo MapearApoyo(ApoyoInputModel apyInput)
        {
            var apy = new Apoyo
            {
                Persona = apyInput.Persona,
                Valor = apyInput.Valor,
                Tipo = apyInput.Tipo,
                Fecha = apyInput.Fecha
            };
            return apy;
        }
    }

}