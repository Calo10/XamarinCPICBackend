using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProyectoXamarinCPICBackend.Models;

namespace ProyectoXamarinCPICBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        public static List<CustomerModel> lstAllCustomers = new List<CustomerModel>();

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<CustomerModel>> Get()
        {

            return lstAllCustomers;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public ActionResult<bool> Post([FromBody] CustomerModel customer)
        {
            lstAllCustomers.Add(customer);

            return true;
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
