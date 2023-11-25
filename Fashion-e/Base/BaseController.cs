using Fashion_e.BL.Base;
using Microsoft.AspNetCore.Mvc;

namespace Fashion_e.Base
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class BaseController<T, TDto> : ControllerBase
        where T : class
        where TDto : class
    {
        protected readonly IBaseService<T, TDto> _baseService;      // base service

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="baseService"></param>
        public BaseController(IBaseService<T, TDto> baseService)
        {
            _baseService = baseService;
        }

        /// <summary>
        /// lấy về danh sách record
        /// </summary>
        /// <returns>Task<IActionResult></returns>
        /// created by: ntvu (20/11/2023)
        [HttpGet]
        public virtual async Task<IActionResult> GetList()
        {
            IEnumerable<T> entities = await _baseService.GetList();

            return Ok(entities.ToList());
        }

        /// <summary>
        /// lấy về record theo id
        /// </summary>
        /// <param name="id">id bản ghi</param>
        /// <returns>record</returns>
        /// created by: ntvu (20/11/2023)
        [HttpGet("{id}")]
        public virtual async Task<IActionResult> GetById(Guid id)
        {
            T entity = await _baseService.GetById(id);

            return Ok(entity);
        }

        /// <summary>
        /// thêm bản ghi
        /// </summary>
        /// <param name="item">thông tin thêm</param>
        /// <returns>số dòng bị ảnh hưởng</returns>
        /// created by: ntvu (20/11/2023)
        [HttpPost]
        public virtual async Task<IActionResult> Add([FromBody] TDto item)
        {
            int res = await _baseService.Add(item);

            return Ok(res);
        }

        /// <summary>
        /// sửa thông tin
        /// </summary>
        /// <param name="id">id bản ghi</param>
        /// <param name="item">thông itn sửa</param>
        /// <returns>số dòng bị ảnh hưởng</returns>
        /// created by: ntvu (20/11/2023)
        [HttpPut("{id}")]
        public virtual async Task<IActionResult> Update
        (
            [FromRoute] Guid id,
            [FromBody] TDto item
        )
        {
            int res = await _baseService.Update(id, item);

            return Ok(res);
        }

        /// <summary>
        /// xóa bản ghi
        /// </summary>
        /// <param name="id">id cần xóa</param>
        /// <returns>số dòng bị ảnh hưởng</returns>
        /// created by: ntvu (20/11/2023)
        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> Delete(Guid id)
        {
            int res = await _baseService.Delete(id);

            return Ok(res);
        }
    }
}
