using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion_e.BL.DTOs.SizeProduct
{
    public class SizeProductDto
    {
        public Guid Id { get; set; }                                // id
        public int IsDelete { get; set; } = 0;                      // đã xóa?
        public DateTime CreatedAt { get; set; } = DateTime.Now;     // ngày tạo
        public String CreatedBy { get; set; } = "ntvu";             // người tạo
        public string Name { get; set; }                            // tên size
    }
}
