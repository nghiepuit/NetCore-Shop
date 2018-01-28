using Microsoft.AspNetCore.Mvc;
using NetCore_Shop.Extensions;

namespace NetCore_Shop.Areas.Admin.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}