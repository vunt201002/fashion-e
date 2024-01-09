using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion_e.BL.DTOs.Order
{
    public class OrderDTO
    {
        public Guid CustomerId { get; set; }                                        // id khách hàng
        public Guid ConfirmId { get; set; }                                         // id nhân viên xác nhận
        public Guid PackagedId { get; set; }                                        // id nhân viên đóng gói
        public Guid DeliverdId { get; set; }                                        // id nhân viên giao cho shipper
        public string Name { get; set; }                                            // tên người nhận
        public string Phone { get; set; }                                           // số điện thoại người nhận
        public string Address { get; set; }                                         // địa chỉ
        public string Note { get; set; }                                            // ghi chú
        public DateTime OrderAt { get; set; } = DateTime.Now;                       // thời gian đặt
        public int Freight { get; set; } = 10000;                                   // phí ship
        public DateTime RequiredDate { get; set; } = DateTime.Now.AddDays(5);       // ngày giao dự kiến
        public DateTime ShippedDate { get; set; } = DateTime.Now.AddDays(5);        // ngày giao thực tế
        public Guid ShipId { get; set; } = default;                                 // id shipper
        public int Paid { get; set; } = 0;                                          // đã thanh toán chưa
    }
}
