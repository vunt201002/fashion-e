using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fashion_e.Common.Entities.Base;

namespace Fashion_e.Common.Entities.Entities
{
    public class Product : BaseEntity
    {
        public Guid CategoryId { get; set; }                        // id danh muc
        public string? Title { get; set; }                          // tên sản phẩm
        public int UnitPrice { get; set; }                          // giá
        public string? Description { get; set; } = string.Empty;    // mô tả
        public string? Material { get; set; } = string.Empty;       // chất liệu
        public string? Instruction { get; set; } = string.Empty;    // hướng dẫn sử dụng

    }
}
