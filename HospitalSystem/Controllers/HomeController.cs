using HospitalSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HospitalSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Home()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Treatment()
        {
            return View();
        }

        public IActionResult Doctors()
        {
            return View();
        }
        public IActionResult Signup()
        {
            return View();
        }

        public IActionResult login()
        {
            return View();
        }
        public IActionResult PatientReport()
        {
            return View();
        }
        public IActionResult Book()
        {
            return View();
        }
        public IActionResult AddNewDoctor()
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
