using AppData.IServices;
using AppData.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppApi.Controllers
{
    public class BlogDetailController : ControllerBase
    {
        private IBlogDetailService _iblogDetailService;
        public BlogDetailController(IBlogDetailService iblogDetailService)
        {
            _iblogDetailService = iblogDetailService;
        }
        [HttpGet("get")]
        public async Task<List<BlogDetail>> GetAll()
        {
            var a = await _iblogDetailService.GetBlogDetailds();
            return a;
        }
        [HttpGet("get-detail/{id}")]
        public async Task<List<BlogDetail>> GetAll(Guid id)
        {
            var a = await _iblogDetailService.GetBlogDetailds(id);
            return a;
        }

        [HttpGet("getById/{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var a = await _iblogDetailService.GetById(id);
            return Ok(a);
        }

        // POST api/<PhoneDetaildController>
        [HttpPost("add")]
        public async Task<IActionResult> Post(BlogDetail obj)
        {
            var a = await _iblogDetailService.Add(obj);
            return Ok(a);
        }

        // PUT api/<PhoneDetaildController>/5
        [HttpPut("update")]
        public async Task<IActionResult> Put(BlogDetail obj)
        {
            var a = await _iblogDetailService.Update(obj);
            return Ok(a);
        }
    }
}
