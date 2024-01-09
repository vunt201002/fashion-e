using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Fashion_e.BL.Base;
using Fashion_e.BL.DTOs.Customer;
using Fashion_e.BL.Services.OrderService;
using Fashion_e.Common.Entities.Entities;
using Fashion_e.DL.Constracts;
using Microsoft.IdentityModel.Tokens;

namespace Fashion_e.BL.Services.CustomerService
{
    public class CustomerService : BaseService<Customer, CustomerDTO>, ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;
        private readonly IOrderService _orderService;

        public CustomerService(
            ICustomerRepository customerRepository,
            IMapper mapper,
            IOrderService orderService
        ) : base(customerRepository, mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
            _orderService = orderService;
        }

        /// <summary>
        /// hàm đăng ký người dùng
        /// override từ hàm thêm bản ghi
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public override async Task<int> Add(CustomerDTO item)
        {
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(item.Password);

            Customer customer = _mapper.Map<Customer>( item );
            customer.PasswordHash = passwordHash;

            int res = await _customerRepository.Add( customer );

            return res;
        }

        public async Task<string> Login(CustomerDTO item)
        {
            Customer? customer = await _customerRepository.GetCustomerByEmail(item.Email);

            if (customer == null)
            {
                throw new Exception("Email chưa được đăng ký");
            }
            
            if (!BCrypt.Net.BCrypt.Verify(item.Password, customer.PasswordHash))
            {
                throw new Exception("Sai mật khẩu");
            }

            string token = CreateToken(customer);

            return token;
        }

        public async Task<int> Received(Guid orderId)
        {
            int res = await _orderService.Received(orderId);

            return res;
        }

        private string CreateToken(Customer customer)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim("Id", customer.Id.ToString())
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
                "my top secret key"
            ));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddSeconds(30),
                signingCredentials: creds
            );

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }
    }
}
