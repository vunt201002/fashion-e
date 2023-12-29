using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Fashion_e.BL.Base;
using Fashion_e.BL.DTOs.Employee;
using Fashion_e.Common.Entities.Entities;
using Fashion_e.DL.Constracts;
using Fashion_e.DL.Repositories;
using Microsoft.IdentityModel.Tokens;

namespace Fashion_e.BL.Services.EmployeeService
{
    public class EmployeeService : BaseService<Employee, EmployeeDTO>, IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;

        public EmployeeService(
            IEmployeeRepository employeeRepository,
            IMapper mapper
        ) : base( employeeRepository, mapper )
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        public override async Task<int> Add(EmployeeDTO item)
        {
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(item.Password);

            Employee employee = _mapper.Map<Employee>(item);
            employee.PasswordHash = passwordHash;

            int res = await _employeeRepository.Add(employee);

            return res;
        }

        public async Task<string> Login(EmployeeDTO item)
        {
            Employee? employee = await _employeeRepository.GetEmployeeByEmail(item.Email);

            if (employee == null)
            {
                throw new Exception("Email chưa được đăng ký");
            }

            if (!BCrypt.Net.BCrypt.Verify(item.Password, employee.PasswordHash))
            {
                throw new Exception("Sai mật khẩu");
            }

            string token = CreateToken(employee.Id);

            return token;
        }

        private string CreateToken(Guid Id)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim("Id", Id.ToString())
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
