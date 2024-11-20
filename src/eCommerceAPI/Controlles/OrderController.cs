using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCommerceAPI.Models;
using eCommerceAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceAPI.Controlles
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController:ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        [HttpGet]
        public async Task<IActionResult>GetAllOrders()
        {
            var orders = await _orderService.GetAllOrderAsync();
            return Ok(orders);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrderById(int id)
        {
            var order = await _orderService.GetOrderByIdAsync(id);
            if(order ==null)return NotFound();
            return Ok(order);
        }
        [HttpGet("customer/[controller]")]
        public async Task<IActionResult>AddOrder([FromBody] OrderModel order)
        {
            if(!ModelState.IsValid)return BadRequest();
            await _orderService.AddOrderAsync(order);
            return CreatedAtAction(nameof(GetOrderById), new { id = order.OrderId }, order);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateOrder(int id, [FromBody] OrderModel order)
        {
            if(!ModelState.IsValid)return BadRequest();
            if(id != order.OrderId)
            {
                return NotFound();
            }
            await _orderService.UpdateOrderAsync(order);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult>DeleteOrder(int id)
        {
            await _orderService.DeleteOrderAsync(id);
            return NoContent();
        }
    }
}