using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NetCore_Shop.Controllers;
using NetCore_Shop.Models.AccountViewModels;
using ShopOnline.Data.Entities;
using ShopOnline.Utilities.Dtos;
using System.Threading.Tasks;

namespace NetCore_Shop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly ILogger _logger;

        public LoginController(
            SignInManager<AppUser> signInManager,
            ILogger<AccountController> logger
        )
        {
            _signInManager = signInManager;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Authen(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Username, model.Password, model.RememberMe, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User logged in.");
                    return new OkObjectResult(new GenericResult(true));
                }
                if (result.IsLockedOut)
                {
                    _logger.LogInformation("User account locked out.");
                    return new OkObjectResult(new GenericResult(false, "Tài khoản đã bị khóa!"));
                }
                else
                {
                    return new OkObjectResult(new GenericResult(false, "Đăng nhập thất bại!"));
                }
            }
            return new OkObjectResult(new GenericResult(false, model));
        }
    }
}