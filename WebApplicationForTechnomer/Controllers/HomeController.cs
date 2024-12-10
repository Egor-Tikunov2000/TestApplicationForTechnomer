using System.Data.Common;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplicationForTechnomer.Models;

namespace WebApplicationForTechnomer.Controllers
{
    public class HomeController : Controller
    {
        ApplicationContext db;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ApplicationContext context)
        {
            //bd = context;
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
    }
}
