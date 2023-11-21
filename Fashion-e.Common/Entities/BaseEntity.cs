using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion_e.Common.Entities
{
    /// <summary>
    /// lớp cơ sở
    /// </summary>
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }                // id
        public string Code { get; set; }            // mã
        public int IsDelete { get; set; } = 0;      // đã xóa?
        public DateTime CreatedAt { get; set; }     // ngày tạo
        public DateTime CreatedBy { get; set; }     // người tạo
    }
}
