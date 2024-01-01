using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fashion_e.Common.Entities.Base;

namespace Fashion_e.Common.Entities.Entities
{
    public class OrderDetail : BaseEntity
    {
        public Guid OrderId { get; set; }               // id order
        public Guid SizeColorProductId { get; set; }    // id sản phẩm
        public int Quantity { get; set; }               // số lượng
        public int Discount { get; set; } = 0;          // giảm giá (%)
        public int UnitPrice { get; set; }              // đơn giá
    }
}
