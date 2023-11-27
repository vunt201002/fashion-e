using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fashion_e.Common.Entities.Base;

namespace Fashion_e.Common.Entities.Entities
{
    public class Gallery : BaseEntity
    {
        public Guid ProductId { get; set; }         // id sản phẩm
        public string Link { get; set; }            // link ảnh
        public string? PublicId { get; set; }       // publicId trên cloundinary
        public int IsThumbnail { get; set; } = 0;   // nền?
    }
}
