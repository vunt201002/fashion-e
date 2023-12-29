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

        [HttpPost("test"), Authorize]
        public IActionResult Test()
        {
            return Ok("test ok");
        }
    }
}
