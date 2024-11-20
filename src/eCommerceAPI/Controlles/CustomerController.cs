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
    public class CustomerController:ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpGet]
        public async Task<IActionResult>GetAllCustomers()
        {
            var customers = await _customerService.GetAllCustomersAsync();
            return Ok(customers);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomerById(int id)
        {
            var customer = await _customerService.GetCustomerByIdAsync(id);
            if(customer== null)return NotFound();
            return Ok(customer); 
        }
        [HttpGet("email/{email}")]
        public async Task<IActionResult> GetCustomerByEmail(string email)
        {
            var customer = await _customerService.GetCustomerByEmailAsync(email);
            if(customer ==null)return NotFound();
            return Ok(customer);
        }
        [HttpPost]
        public async Task<IActionResult>AddCustomer([FromBody] UserModel user)
        {
            if(!ModelState.IsValid)return BadRequest(ModelState);
            await _customerService.AddCustomerAsync(user);
            return CreatedAtAction(nameof(GetCustomerById), new { id = user.UserId }, user);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult>UpdateCustomer(int id , [FromBody] UserModel customer )
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (id != customer.UserId) return BadRequest("ID mismatch");

            await _customerService.UpdateCustomerAsync(customer);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            await _customerService.DeleteCustomerAsync(id);
            return NoContent();
        }
    }
}