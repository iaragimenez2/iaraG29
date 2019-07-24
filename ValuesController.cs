using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ejercicio.Model;
using ejercicio.Services;
using Microsoft.AspNetCore.Mvc;


namespace ejercicio_LU.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class valuesController : ControllerBase
    {
        private alumnosService alumnosService = new alumnosService();

        public valuesController(alumnosService alumnosService) 
        {
            this.alumnosService = alumnosService;
        }

        // GET api/values
        [HttpGet]
        public IList<alumnos> Get()
        {
            return alumnosService.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<alumnos> Get(int id)
        {
            return alumnosService.Get(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] alumnos alumnos)
        {
            alumnosService.Save(alumnos);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] alumnos alumnos)
        {
            alumnosService.Save(alumnos);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            alumnosService.Delete(id);
        }    
    }
}
