using Fashion_e.Base;
using Fashion_e.BL.DTOs.Gallery;
using Fashion_e.BL.Services.GalleryService;
using Fashion_e.BL.Services.PhotoService;
using Fashion_e.Common.Entities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Fashion_e.Controllers
{
    public class GalleryController : BaseController<Gallery, GalleryDTO>
    {
        private readonly IPhotoService _photoService;

        public GalleryController(
            IGallerySevice gallerySevice,
            IPhotoService photoService
        ) : base(gallerySevice)
        {
            _photoService = photoService;
        }

        [HttpPost("photo")]
        public async Task<IActionResult> AddPhotoAsync(IFormFile file)
        {
            var result = await _photoService.AddPhotoAsync(file);

            return Ok(result);
        }
    }
}
