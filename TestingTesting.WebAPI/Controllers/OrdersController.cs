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
        [HttpGet("api/Orders")]
        public IActionResult Get()
        {
            throw new NotImplementedException();
        }

        // GET api/Orders/5
        [HttpGet("api/Orders/{orderId:int}")]
        public IActionResult Get(int orderId)
        {
            throw new NotImplementedException();
        }

        // POST api/Orders
        [HttpPost("api/Orders")]
        public void Post()
        {
            throw new NotImplementedException();
        }

        // Post api/Orders/5/Details
        [HttpPost("api/Orders/{orderId:int}/Details")]
        public void Post(int orderId)
        {
            throw new NotImplementedException();
        }

        // PUT api/Orders/5
        [HttpPut("api/Orders/{orderId:int}")]
        public void Put(int orderId)
        {
            throw new NotImplementedException();
        }

        // DELETE api/Orders/5
        [HttpDelete("api/Orders/{orderId:int}")]
        public void Delete(int orderId)
        {
            throw new NotImplementedException();
        }
    }
}
