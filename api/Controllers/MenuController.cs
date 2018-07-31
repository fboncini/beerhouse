using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using New_folder.Model;

namespace New_folder.Controllers
{
    [Route("[controller]")]
    [EnableCors("AllowSpecificOrigin")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<List<Product>> Get()
        {
            var ps = new ProductService();
            var result = ps.GetAll();
            return result;
        }

        // GET api/values/5
        [HttpGet("id/{id}")]
        public ActionResult<Product> Get(int id)
        {
            var ps = new ProductService();
            return ps.GetById(id);
        }

        [HttpGet("category/{category}")]
        public ActionResult<List<Product>> Get(string category)
        {
            var ps = new ProductService();
            return ps.GetByCategory(category);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
