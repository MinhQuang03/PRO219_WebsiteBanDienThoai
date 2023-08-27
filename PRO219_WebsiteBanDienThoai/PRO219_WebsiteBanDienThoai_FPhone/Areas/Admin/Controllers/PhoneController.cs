using AppData.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

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
    }
}
