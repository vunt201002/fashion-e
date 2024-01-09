using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fashion_e.BL.Base;
using Fashion_e.BL.DTOs.Customer;
using Fashion_e.Common.Entities.Entities;

namespace Fashion_e.BL.Services.CustomerService
{
    public interface ICustomerService : IBaseService<Customer, CustomerDTO>
    {
        public Task<string> Login(CustomerDTO item);
        /// <summary>
        /// hàm đã nhận
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        public Task<int> Received(Guid orderId);
    }
}
