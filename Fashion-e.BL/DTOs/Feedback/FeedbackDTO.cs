using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion_e.BL.DTOs.Feedback
{
    public class FeedbackDTO
    {
        public Guid CustomerId { get; set; }                    // id khách hàng
        public Guid SizeColorProductId { get; set; }            // id sản phẩm
        public string? Subject { get; set; } = String.Empty;    // tiêu đề
        public string? Content { get; set; } = String.Empty;    // nội dung đánh giá
    }
}
