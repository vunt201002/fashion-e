using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fashion_e.DL.Base;

namespace Fashion_e.BL.DTOs.SizeColorProduct
{
    public class SizeColorProductDTO
    {
        public Guid Id { get; set; }                    // id
        public Guid ProductId { get; set; }             // id sản phẩm
        public Guid SizeProductId { get; set; }         // id size
        public Guid ColorProductId { get; set; }        // id màu
        public int Quantity { get; set; }               // số lượng sản phẩm
        public int UnitInOrder { get; set; } = 0;       // số lượng sản phẩm đang được order
    }
}
