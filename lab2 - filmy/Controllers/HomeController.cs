using lab2___filmy.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace lab2___filmy.Controllers
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Form(Dane dane)
        {
            if(ModelState.IsValid)
            {
                return View("Wynik", dane);
            }
            else return View();
        }
        public IActionResult Wynik(Dane dane)
        {
            return View(dane);
        }
    }
}
