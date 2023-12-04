using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fashion_e.Common.Entities.Base;

namespace Fashion_e.Common.Entities.Entities
{
    public class ColorProduct : BaseEntity
    {
        public string Name { get; set; }            // tên màu
        public string ColorCode { get; set; }       // mã màu: #000, #ccc
        public string LinkImageColor { get; set; }  // link ảnh của màu
    }
}
