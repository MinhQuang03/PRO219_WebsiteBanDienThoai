using AppData.FPhoneDbContexts;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PRO219_WebsiteBanDienThoai_FPhone.Models;
using System.Diagnostics;

namespace PRO219_WebsiteBanDienThoai_FPhone.Controllers
{
    public class HomeController : Controller
    {
       
        HttpClient _client;
        FPhoneDbContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(HttpClient client,ILogger<HomeController> logger )
        {
            _client = client;
           
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            string datajson = await _client.GetStringAsync("/api/Product");
            List<Product> ctsp = JsonConvert.DeserializeObject<List<Product>>(datajson);
            return View(ctsp);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> ShowPhone()
        {
            string datajson = await _client.GetStringAsync("api/Product");
            List<Product> ctsp = JsonConvert.DeserializeObject<List<Product>>(datajson);
            return View(ctsp);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}