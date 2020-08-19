using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Steamship.Tech.Models;
using Steamship.Tech.Services;
using System.Diagnostics;

namespace Steamship.Tech.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISteamshipRepository _steamshipRepository;

        public HomeController(ILogger<HomeController> logger,
            ISteamshipRepository steamshipRepository)
        {
            _logger = logger;
            _steamshipRepository = steamshipRepository;
        }

        public IActionResult Index()
        {
            return View(_steamshipRepository.GetEmployees());
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
