using maritimoSampa.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace maritimoSampa.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Santos()
        {
            return View();
        }
        public IActionResult Guaruja()
        {
            return View();
        }
        public IActionResult SaoSebastiao()
        {
            return View();
        }
        public IActionResult Itanhaem()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
