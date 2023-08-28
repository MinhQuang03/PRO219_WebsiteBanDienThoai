using AppData.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Text;

namespace PRO219_WebsiteBanDienThoai_FPhone.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PhoneController : Controller
    {
        public readonly HttpClient _httpClient;
        public PhoneController(HttpClient httpClient)
        {

            _httpClient = httpClient;

        }
        public async Task<IActionResult> Index()
        {
            var datajson = await _httpClient.GetStringAsync("api/Phone/get");
            var obj = JsonConvert.DeserializeObject<List<Phone>>(datajson);
            return View(obj);
        }
        public async Task<IActionResult> Create()
        {
            var datajson = await _httpClient.GetStringAsync("api/ProductionCompany/get");
            List<ProductionCompany> obj = JsonConvert.DeserializeObject<List<ProductionCompany>>(datajson);
            ViewBag.IdProductionCompany = new SelectList(obj, "Id","Name");
            return View();
        }


        [HttpPost] 
        public async Task<IActionResult> Create(Phone obj, IFormFile file)
        {
            if (file != null && file.Length > 0) // khong null va khong trong 
            {
                var fileName = Path.GetFileName(file.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", fileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                obj.Image = "~/img/" + fileName;
            }
            var jsonData = JsonConvert.SerializeObject(obj);
            HttpContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("api/Phone/add", content);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View(jsonData);
        }
    }
}
