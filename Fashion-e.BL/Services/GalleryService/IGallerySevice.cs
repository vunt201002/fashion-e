using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudinaryDotNet.Actions;
using Fashion_e.BL.Base;
using Fashion_e.BL.DTOs.Gallery;
using Fashion_e.Common.Entities.Entities;
using Microsoft.AspNetCore.Http;

namespace Fashion_e.BL.Services.GalleryService
{
    public interface IGallerySevice : IBaseService<Gallery, GalleryDTO>
    {
    }
}
