using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fashion_e.Common.Entities.Entities;
using Fashion_e.DL.Base;
using Fashion_e.DL.Constracts;
using Fashion_e.DL.Context;
using Microsoft.EntityFrameworkCore;

namespace Fashion_e.DL.Repositories
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        private readonly DataContext _context;

        public EmployeeRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Employee?> GetEmployeeByEmail(string email)
        {
            Employee? employee = await _context.Employee
                .FirstOrDefaultAsync(c => c.Email == email);

            return employee;
        }
    }
}
