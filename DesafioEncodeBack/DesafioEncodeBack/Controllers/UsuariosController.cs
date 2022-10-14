using DesafioEncodeBack.Datos;
using DesafioEncodeBack.Modelos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DesafioEncodeBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly AccesoDB acceso;

        public UsuariosController(AccesoDB acceso)
        {
            this.acceso = acceso;
        }

        // GET: api/<UsuariosController>
        [HttpGet]
        public IEnumerable<UsuarioDTO> Get()
        {
            return acceso.Usuarios.ToList();
        }

        // GET api/<UsuariosController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UsuariosController>
        [HttpPost]
        public ActionResult Post([FromBody] UsuarioDTO usuario)
        {
            try
            {
                acceso.Usuarios.Add(usuario);
                acceso.SaveChanges();
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
            
        }

        // PUT api/<UsuariosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsuariosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
