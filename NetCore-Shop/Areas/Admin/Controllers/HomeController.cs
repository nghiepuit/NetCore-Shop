using Microsoft.AspNetCore.Mvc;
using NetCore_Shop.Extensions;

namespace NetCore_Shop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}