using AppData.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace PRO219_WebsiteBanDienThoai_FPhone.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChargingportTypeController : Controller
    {
        public readonly HttpClient _httpClient;
        public ChargingportTypeController(HttpClient httpClient)
        {
            _httpClient = httpClient;

        }

        public async Task<IActionResult> Index()
        {
            var datajson = await _httpClient.GetStringAsync("api/ChargingportType/get");
            var obj = JsonConvert.DeserializeObject<List<ChargingportType>>(datajson);
            return View(obj);
        }


    }
}
