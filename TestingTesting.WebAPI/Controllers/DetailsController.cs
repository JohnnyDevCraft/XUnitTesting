using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestingTesting.Core.Abstractions.Data;
using TestingTesting.Domain;

namespace TestingTesting.WebAPI.Controllers
{
    public class DetailsController : Controller
    {
		private readonly IDetailsRepo _detailRepository;

		public DetailsController(IDetailsRepo detailRepository)
		{
			_detailRepository = detailRepository;
		}

        // PUT api/Details/5
        [HttpPut("api/Details/{detailId:int}")]
        public IActionResult Put([FromBody]Detail detail)
        {
			detail = _detailRepository.UpdateDetail(detail);

			if (detail == null)
			{
				return StatusCode(StatusCodes.Status500InternalServerError);
			}

			return Json(detail);
        }

        // DELETE api/Details/5
        [HttpDelete("api/Details/{detailId:int}")]
        public IActionResult Delete(int? detailId)
        {
			if (detailId == null)
			{
				return BadRequest();
			}

			var detail = _detailRepository.DeleteOrder(detailId.Value);

			if (detail == null)
			{
				return NotFound();
			}

			return StatusCode(StatusCodes.Status204NoContent);
        }
    }
}
