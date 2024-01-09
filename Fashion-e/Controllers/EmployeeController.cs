using Fashion_e.Base;
using Fashion_e.BL.DTOs.Customer;
using Fashion_e.BL.DTOs.Employee;
using Fashion_e.BL.Services.EmployeeService;
using Fashion_e.Common.Entities.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Fashion_e.Controllers
{
    public class EmployeeController : BaseController<Employee, EmployeeDTO>
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService) : base(employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(EmployeeDTO employee)
        {
            string res = await _employeeService.Login(employee);

            return Ok(res);
        }

        [HttpPost("confirm/{orderId}")]
        public async Task<IActionResult> ConfirmOrder(Guid orderId, Guid employeeId)
        {
            int res = await _employeeService.ConfirmOrder(orderId, employeeId);

            return Ok(res);
        }

        [HttpPost("packaged/{orderId}")]
        public async Task<IActionResult> PackageOrder(Guid orderId, Guid employeeId)
        {
            int res = await _employeeService.PackageOrder(orderId, employeeId);

            return Ok(res);
        }

        [HttpPost("deliverd/{orderId}")]
        public async Task<IActionResult> DeliverdOrder(Guid orderId, Guid employeeId, Guid shipId)
        {
            int res = await _employeeService.DeliverdOrder(orderId, employeeId, shipId);

            return Ok(res);
        }
    }
}
