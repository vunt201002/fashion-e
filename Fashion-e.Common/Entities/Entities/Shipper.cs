using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fashion_e.Common.Entities.Base;

namespace Fashion_e.Common.Entities.Entities
{
    public class Shipper : BaseEntity
    {
        public string? Name { get; set; }            // tên
        public string? Phone { get; set; }           // sdt
        public string? CompanyName { get; set; }     // tên công ty
        public string? IdNumber { get; set; }        // số cccd
    }
}
