using Fashion_e.BL.Base;
using Microsoft.AspNetCore.Mvc;

namespace Fashion_e.Base
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class BaseController<T> : ControllerBase where T : class
    {
        protected readonly IBaseService<T> _baseService;

        public BaseController(IBaseService<T> baseService)
        {
            _baseService = baseService;
        }

        [HttpGet]
        public virtual async Task<IActionResult> GetList()
        {
            IEnumerable<T> entities = await _baseService.GetList();

            return Ok(entities.ToList());
        }

        [HttpGet("tree")]
        public virtual async Task<IActionResult> GetTree()
        {
            var entities = await _baseService.GetTree();

            return Ok(entities);
        }

        [HttpGet("{id}")]
        public virtual async Task<IActionResult> GetById(Guid id)
        {
            T entity = await _baseService.GetById(id);

            return Ok(entity);
        }

        [HttpPost]
        public virtual async Task<IActionResult> Add([FromBody] T item)
        {
            int res = await _baseService.Add(item);

            return Ok(res);
        }

        [HttpPut("{id}")]
        public virtual async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] T item)
        {
            int res = await _baseService.Update(id, item);

            return Ok(res);
        }

        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> Delete(Guid id)
        {
            int res = await _baseService.Delete(id);

            return Ok(res);
        }
    }
}
