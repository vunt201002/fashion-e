using Fashion_e.Base;
using Fashion_e.BL.DTOs.Customer;
using Fashion_e.BL.Services.CustomerService;
using Fashion_e.Common.Entities.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Fashion_e.Controllers
{
    public class CustomerController : BaseController<Customer, CustomerDTO>
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService) : base(customerService)
        {
            _customerService = customerService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(CustomerDTO customer)
        {
            string res = await _customerService.Login(customer);

            return Ok(res);
        }

        [HttpPost("received/{orderId}")]
        public async Task<IActionResult> Received(Guid orderId)
        {
            int res = await _customerService.Received(orderId);

            return Ok(res);
        }
    }
}
