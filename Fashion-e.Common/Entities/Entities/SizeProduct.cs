using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fashion_e.Common.Entities.Base;

namespace Fashion_e.Common.Entities.Entities
{
    /// <summary>
    /// size của sản phẩm
    /// </summary>
    /// created by: ntvu (21/11/2023)
    public class SizeProduct : BaseEntity
    {
        public string Name { get; set; }        // tên size: S, M, L,...
        public int Level { get; set; }       // 90, 100, 110,...
    }
}
