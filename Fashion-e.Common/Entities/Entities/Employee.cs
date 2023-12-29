    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fashion_e.Common.Entities.Base;

namespace Fashion_e.Common.Entities.Entities
{
    public class Employee : BaseEntity
    {
        public string? Name { get; set; }                           // tên
        public string? Email { get; set; }                          // email
        public string? Phone { get; set; }                          // sdt
        public string? Address { get; set; }                        // địa chỉ
        public string PasswordHash { get; set; } = String.Empty;    // mật khẩu được hash
    }
}
