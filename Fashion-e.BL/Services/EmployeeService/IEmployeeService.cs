using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fashion_e.BL.Base;
using Fashion_e.BL.DTOs.Customer;
using Fashion_e.BL.DTOs.Employee;
using Fashion_e.Common.Entities.Entities;

namespace Fashion_e.BL.Services.EmployeeService
{
    public interface IEmployeeService : IBaseService<Employee, EmployeeDTO>
    {
        public Task<string> Login(EmployeeDTO item);
    }
}
