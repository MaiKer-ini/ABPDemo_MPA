using Demo.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Web.Controllers
{
    public class PersonController : DemoControllerBase
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}