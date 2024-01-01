using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion_e.BL.DTOs.OrderDetail
{
    public class OrderDetailDTO
    {
        public Guid OrderId { get; set; }               // id order
        public Guid SizeColorProductId { get; set; }    // id sản phẩm
        public int Quantity { get; set; }               // số lượng
        public int Discount { get; set; } = 0;          // giảm giá (%)
        public int UnitPrice { get; set; }              // đơn giá
    }
}
