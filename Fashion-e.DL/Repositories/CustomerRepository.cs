
using Fashion_e.Common.Entities.Entities;
using Fashion_e.DL.Base;
using Fashion_e.DL.Constracts;
using Fashion_e.DL.Context;
using Microsoft.EntityFrameworkCore;

namespace Fashion_e.DL.Repositories
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        private readonly DataContext _context;

        public CustomerRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Customer?> GetCustomerByEmail(string email)
        {
            Customer? customer = await _context.Customer
                .FirstOrDefaultAsync(c => c.Email == email);

            return customer;
        }

    }
}
