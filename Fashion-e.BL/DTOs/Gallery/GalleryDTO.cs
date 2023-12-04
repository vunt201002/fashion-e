using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion_e.BL.DTOs.Gallery
{
    public class GalleryDTO
    {
        public Guid Id { get; set; }                // id
        public Guid ProductId { get; set; }         // id sản phẩm
        public string Link { get; set; }            // link ảnh
        public string? PublicId { get; set; }       // publicId trên cloundinary
        public int IsThumbnail { get; set; } = 0;   // nền?
    }
}
