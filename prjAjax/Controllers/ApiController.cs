using Microsoft.AspNetCore.Mvc;
using System.Text;
using Microsoft.AspNetCore.Cors;

namespace prjAjax.Controllers
{
    public class ApiController : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello, Ajax", "text/plain", Encoding.UTF8);
        }
    }
}
