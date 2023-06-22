using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using services.service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace api.cuentas.Controllers
{
    [Controller]
    [Route("api/[controller]")]
    public class CuentaController : Controller
    {
        private cuentaService servicio;
        string cadenaConexion = "Server=127.0.0.1;Port=5432;Database=finanoptativo;User Id=postgres;Password=admin;";

        public CuentaController()
        {
            servicio = new cuentaService(cadenaConexion);
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("consultar/{cuenta}")]
        public infraestructure.Models.cuentaModel Get(string cuenta)
        {
            var result = servicio.consultarCuenta(cuenta);
            return result;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

