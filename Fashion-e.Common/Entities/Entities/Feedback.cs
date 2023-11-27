using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fashion_e.Common.Entities.Base;

namespace Fashion_e.Common.Entities.Entities
{
    public class Feedback : BaseEntity
    {
        public Guid CustomerId { get; set; }                    // id khách hàng
        public Guid SizeColorProductId { get; set; }            // id sản phẩm
        public string? Subject { get; set; } = String.Empty;    // tiêu đề
        public string? Content { get; set; } = String.Empty;    // nội dung đánh giá
    }
}
