using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion_e.Common.Entities.Base
{
    /// <summary>
    /// lớp cơ sở
    /// </summary>
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }                                // id

        [StringLength(20)]
        public string Code { get; set; }                            // mã
        public int IsDelete { get; set; } = 0;                      // đã xóa?
        public DateTime CreatedAt { get; set; } = DateTime.Now;     // ngày tạo
        public String CreatedBy { get; set; } = "ntvu";             // người tạo
    }
}
