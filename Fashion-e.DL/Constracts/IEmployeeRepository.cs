using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fashion_e.Common.Entities.Entities;
using Fashion_e.DL.Base;

namespace Fashion_e.DL.Constracts
{
    public interface IEmployeeRepository : IBaseRepository<Employee>
    {
        public Task<Employee?> GetEmployeeByEmail(string email);
    }
}
