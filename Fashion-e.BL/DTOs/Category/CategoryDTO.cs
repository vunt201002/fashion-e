using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion_e.BL.DTOs.Category
{
    /// <summary>
    /// category dto
    /// </summary>
    /// created by: ntvu (20/11/2023)
    public class CategoryDTO
    {
        public Guid Id { get; set; }                                // id

        [StringLength(20)]
        public string? Code { get; set; }                           // mã
        public string Name { get; set; }                            // tên danh mục
        public Guid ParentId { get; set; }                          // id node cha
    }
}
