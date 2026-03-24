using ApiPersonas.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiPersonas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        private List<Persona> personas;
        public PersonasController()
        {
            this.personas = new List<Persona>
            {
                new Persona { IdPersona = 1, Nombre = "Juan", Email = "juan@example.com", Edad = 30 },
                new Persona { IdPersona = 2, Nombre = "Maria", Email = "maria@example.com", Edad = 25 },
                new Persona { IdPersona = 3, Nombre = "Pedro", Email = "pedro@example.com", Edad = 40 },
                new Persona { IdPersona = 4, Nombre = "Lucia", Email = "lucia@example.com", Edad = 22 }
            };
        }
        [HttpGet]
        public ActionResult<List<Persona>> Get()
        {
            return this.personas;

        }
        [HttpGet("{id}")]
        public ActionResult<Persona> GetPersonaById(int id)
        {
            return this.personas.FirstOrDefault(p => p.IdPersona == id);

        }
    }
}
