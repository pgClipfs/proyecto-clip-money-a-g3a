using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web;
using System.Web.Mvc;
using Clip_Back.Models;

namespace Clip_Back.Controllers
{
    public class DefaultController : ApiController
    {
        // GET: api/Default
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public IEnumerable<Usuario> Get()
        {
            List<Usuario> lista = new List<Usuario>();
            lista.Add(new Usuario() { nombre = "Esteban", apellido = "Quito" });
            return lista;
        }

        // GET: api/Default/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Default
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Default/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Default/5
        public void Delete(int id)
        {
        }
    }
}