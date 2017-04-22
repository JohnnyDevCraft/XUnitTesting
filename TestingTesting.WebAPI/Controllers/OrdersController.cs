using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TestingTesting.WebAPI.Controllers
{
    public class OrdersController : Controller
    {
        // GET api/Orders
        [Route("api/Orders")]
        [HttpGet]
        public IActionResult Get()
        {
            throw new NotImplementedException();
        }

        // GET api/Orders/5
        [Route("api/Orders/{orderId:int}")]
        [HttpGet]
        public IActionResult Get(int orderId)
        {
            throw new NotImplementedException();
        }

        // POST api/Orders
        [Route("api/Orders")]
        [HttpPost]
        public void Post()
        {
            throw new NotImplementedException();
        }

        // Post api/Orders/5/Details
        [Route("api/Orders/{orderId:int}/Details")]
        [HttpPost]
        public void Post(int orderId)
        {
            throw new NotImplementedException();
        }

        // PUT api/Orders/5
        [Route("api/Orders/{orderId:int}")]
        [HttpPut]
        public void Put(int orderId)
        {
            throw new NotImplementedException();
        }

        // DELETE api/Orders/5
        [Route("api/Orders/{orderId:int}")]
        [HttpDelete]
        public void Delete(int orderId)
        {
            throw new NotImplementedException();
        }
    }
}
