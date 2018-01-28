using Microsoft.AspNetCore.Mvc;
using NetCore_Shop.Extensions;
using ShopOnline.Service.Interfaces;
using ShopOnline.Service.ViewModels.System;
using ShopOnline.Utilities.Constants;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace NetCore_Shop.Areas.Admin.Components
{
    public class SideBarViewComponent : ViewComponent
    {
        private IFunctionService _functionService;

        public SideBarViewComponent(IFunctionService functionService)
        {
            _functionService = functionService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var roles = ((ClaimsPrincipal)User).GetSpecificClaim("Roles");
            List<FunctionViewModel> functions;
            if (roles.Split(";").Contains(CommonConstants.AdminRole))
            {
                functions = await _functionService.GetAll();
            }
            else
            {
                // TODO : Get by permission
                functions = new List<FunctionViewModel>();
            }
            return View(functions);
        }
    }
}