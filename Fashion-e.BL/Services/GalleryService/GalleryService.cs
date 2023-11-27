using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CloudinaryDotNet.Actions;
using Fashion_e.BL.Base;
using Fashion_e.BL.DTOs.Gallery;
using Fashion_e.BL.Services.PhotoService;
using Fashion_e.Common.Entities.Entities;
using Fashion_e.DL.Constracts;
using Microsoft.AspNetCore.Http;

namespace Fashion_e.BL.Services.GalleryService
{
    public class GalleryService : BaseService<Gallery, GalleryDTO>, IGallerySevice
    {
        public GalleryService(
            IGalleryRepository galleryRepository,
            IMapper mapper
        ) : base( galleryRepository, mapper )
        {
        }
    }
}
