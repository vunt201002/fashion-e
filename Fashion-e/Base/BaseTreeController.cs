using Fashion_e.BL.Base;
using Microsoft.AspNetCore.Mvc;

namespace Fashion_e.Base
{
    public class BaseTreeController<T, TDto> : BaseController<T,TDto>
        where TDto : class
        where T : class
    {
        protected readonly IBaseTreeService<T, TDto> _baseTreeService;

        public BaseTreeController(IBaseTreeService<T, TDto> baseTreeService) : base(baseTreeService) 
        {
            _baseTreeService = baseTreeService;
        }

        /// <summary>
        /// lấy về danh sách dạng cây
        /// </summary>
        /// <returns>Task<IActionResult></returns>
        /// created by: ntvu (20/11/2023)
        [HttpGet("tree")]
        public virtual async Task<IActionResult> GetTree()
        {
            var entities = await _baseTreeService.GetTree();

            return Ok(entities);
        }
    }
}
