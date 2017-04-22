using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TestingTesting.WebAPI.Controllers
{
    public class DetailsController:Controller
    {
        // PUT api/Details/5
        [HttpPut("api/Details/{detailId:int}")]
        public void Put(int detailId)
        {
            throw new NotImplementedException();
        }

        // DELETE api/Details/5
        [HttpDelete("api/Details/{detailId:int}")]
        public void Delete(int detailId)
        {
            throw new NotImplementedException();
        }
    }
}
