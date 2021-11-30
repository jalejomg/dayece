using ColdChainChecker.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ColdChainChecker.Controllers
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
            var model = new ColdChainCheckModel
            {
                Gps = 1234321,
                Humidity = 432,
                Temperature = 12,
                DoorOpenTimes = 1,
                DeviceCharge = 50,
                ContractFulfilled = true
            };
            return View(model);
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