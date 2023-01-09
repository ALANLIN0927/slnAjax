using Microsoft.AspNetCore.Mvc;
using prjAjax.Models;
using System.Diagnostics;

namespace prjAjax.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DemoContext _conetxt;


        public HomeController(ILogger<HomeController> logger, DemoContext conetxt)
        {
            _logger = logger;
            _conetxt = conetxt;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult test()
        {
            var member = _conetxt.Members;
            return View(member);
        }
        public IActionResult firstAjax()
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