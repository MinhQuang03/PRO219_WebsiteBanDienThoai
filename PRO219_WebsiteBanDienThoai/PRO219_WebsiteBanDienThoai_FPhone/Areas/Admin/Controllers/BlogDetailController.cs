using AppData.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Text;

namespace PRO219_WebsiteBanDienThoai_FPhone.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogDetailController : Controller
    {
        
        public readonly HttpClient _httpClient;
        public BlogDetailController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IActionResult> Index()
        {
            var datajson = await _httpClient.GetStringAsync("api/BlogDetail/get");
            var obj = JsonConvert.DeserializeObject<List<BlogDetail>>(datajson);
            var blogTitle = new Dictionary<Guid, string>();
            foreach (var a in obj)
            {
                if (!blogTitle.ContainsKey(a.IdBlog))
                {
                    var blogTitleData = await _httpClient.GetStringAsync($"api/Phone/getById/{a.IdBlog}");
                    var blog = JsonConvert.DeserializeObject<Blog>(blogTitleData);
                    blogTitle.Add(a.IdBlog, blog.Title);
                }
            }
            ViewBag.Title = blogTitle;
            return View(obj);
        }

        public async Task<IActionResult> Create()
        {
            var blogTitleData = await _httpClient.GetStringAsync("api/Blog/get");
            List<Blog> blog = JsonConvert.DeserializeObject<List<Blog>>(blogTitleData);
            ViewBag.IdBlog = new SelectList(blog, "Id", "Title");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(BlogDetail obj)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("api/BlogDetail/add", obj);
                if (response.IsSuccessStatusCode)
                {
                    TempData["successMessage"] = "Them thanh cong";
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                TempData["errorMessage"] = ex.Message;
                return View();
            }

            return View(obj);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var blogTitleData = await _httpClient.GetStringAsync("api/Blog/get");
            List<Blog> blog = JsonConvert.DeserializeObject<List<Blog>>(blogTitleData);
            ViewBag.IdBlog = new SelectList(blog, "Id", "Title");
            var datajson = await _httpClient.GetStringAsync($"api/BlogDetail/getById/{id}");
            var obj = JsonConvert.DeserializeObject<PhoneDetaild>(datajson);
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, BlogDetail obj)
        {
            var jsonData = JsonConvert.SerializeObject(obj);

            HttpContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync("api/BlogDetail/update", content);
            return RedirectToAction("Index");
        }

    }
}
