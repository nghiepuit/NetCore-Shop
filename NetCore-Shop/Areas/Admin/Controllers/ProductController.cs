using Microsoft.AspNetCore.Mvc;
using ShopOnline.Service.Interfaces;

namespace NetCore_Shop.Areas.Admin.Controllers
{
    public class ProductController : BaseController
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }

        #region AJAX API ALL PRODUCT

        [HttpGet]
        public IActionResult GetAll()
        {
            var model = _productService.GetAll();
            return new OkObjectResult(model);
        }

        #endregion AJAX API ALL PRODUCT
    }
}