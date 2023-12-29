using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion_e.BL.DTOs.Product
{
    public class ProductDto
    {

        [StringLength(20)]
        public string? Code { get; set; }                           // mã
        public Guid CategoryId { get; set; }                        // id danh muc
        public string? Title { get; set; }                          // tên sản phẩm
        public int UnitPrice { get; set; }                          // giá
        public string? Description { get; set; } = string.Empty;    // mô tả
        public string? Material { get; set; } = string.Empty;       // chất liệu
        public string? Instruction { get; set; } = string.Empty;    // hướng dẫn sử dụng
    }
}
