using Aplication.Interfaces;
using Aplication.Models;
using Aplication.Models.Request;
using Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Tpi_Ecommerce.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        [HttpGet]
        public ActionResult<List<OrderDTO>> GetOrders()
        {
            return Ok(_orderService.GetAll());
        }
        [HttpGet("{id}")]
        public ActionResult<OrderDTO> GetOrder(int id)
        {
            var order = _orderService.GetOrderById(id);
            if (order == null)
            {
                return NotFound();
            }
            return Ok(order);   
        }
        [HttpPost]
        public ActionResult CreateOrder(AddOrderRequest orders)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values.ToList());
            }
            var create = _orderService.CreateOrder(orders);
            if (create == false) { return BadRequest(); }
            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult UpdateOrder(int id, UpdateOrderRequest order) 
        {
            if (id != order.Id)
            {
                return BadRequest();
            }

            var ord = _orderService.UpdateOrder(order);
            if (ord == false) return NotFound("Order not found");

            return NoContent();
        }
        [HttpDelete]
        public IActionResult DeleteOrder(int id)
        {
            var delete = _orderService.DeleteOrder(id);
            if (delete == false) { return NotFound();}
            return NoContent();
        }
    }
}
