using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TestingTesting.Core.Abstractions.Data;
using TestingTesting.Domain;

namespace TestingTesting.WebAPI.Controllers
{
	public class OrdersController : Controller
	{
		private readonly IOrderRepo _orderRepository;
		private readonly IDetailsRepo _detailRepository;

		public OrdersController(IOrderRepo orderRepository, IDetailsRepo detailRepository)
		{
			_orderRepository = orderRepository;
			_detailRepository = detailRepository;
		}

		// GET api/Orders
		[HttpGet("api/Orders")]
		public IActionResult Get()
		{
			var orders = _orderRepository.GetOrders();

			return Json(orders);
		}

		// GET api/Orders/5
		[HttpGet("api/Orders/{orderId:int}")]
		public IActionResult Get(int? orderId)
		{
			if (orderId == null)
			{
				return BadRequest();
			}

			var order = _orderRepository.GetOrder(orderId.Value);

			if (order == null)
			{
				return NotFound();
			}

			return Json(order);
		}

		// POST api/Orders
		[HttpPost("api/Orders")]
		public IActionResult Post([FromBody]Order order)
		{
			order = _orderRepository.CreateOrder(order);

			if (order == null)
			{
				return StatusCode(StatusCodes.Status500InternalServerError);
			}

			return Json(order);
		}

		// Post api/Orders/5/Details
		[HttpPost("api/Orders/{orderId:int}/Details")]
		public IActionResult Post(int? orderId, [FromBody]Detail detail)
		{
			if (orderId == null)
			{
				return BadRequest();
			}

			var order = _orderRepository.GetOrder(orderId.Value);
			if (order == null)
			{
				return NotFound();
			}

			detail.OrderId = orderId.Value;
			detail = _detailRepository.CreateDetail(detail);

			if(detail==null)
			{
				return StatusCode(StatusCodes.Status500InternalServerError);
			}

			return Json(detail);
		}

        // PUT api/Orders/5
        [HttpPut("api/Orders/{orderId:int}")]
        public IActionResult Put([FromBody]Order order)
        {
			order = _orderRepository.UpdateOrder(order);

			if (order == null)
			{
				return StatusCode(StatusCodes.Status500InternalServerError);
			}

			return Json(order);
        }

        // DELETE api/Orders/5
        [HttpDelete("api/Orders/{orderId:int}")]
        public IActionResult Delete(int? orderId)
        {
			if (orderId == null)
			{
				return BadRequest();
			}

			var order = _orderRepository.DeleteOrder(orderId.Value);

			if (order == null)
			{
				return NotFound();
			}

			return StatusCode(StatusCodes.Status204NoContent);
        }
    }
}
