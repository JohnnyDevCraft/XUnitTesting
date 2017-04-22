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
        [Route("api/Details/{detailId:int}")]
        [HttpPut]
        public void Put(int detailId)
        {
            throw new NotImplementedException();
        }

        // DELETE api/Details/5
        [Route("api/Details/{detailId:int}")]
        [HttpDelete]
        public void Delete(int detailId)
        {
            throw new NotImplementedException();
        }
    }
}
