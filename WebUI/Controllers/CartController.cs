
using Entitites;
using Microsoft.AspNetCore.Mvc;
using Services;
using Web.ViewModels;
using WebUI.ViewModels;

namespace Web.Controllers
{
    public class CartController : Controller
    {

        private readonly ComboService _comboService;
        private readonly ProductService _productService;

        public CartController(ComboService comboService, ProductService productService)
        {
            _comboService = comboService;
            _productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            var cookieData = Request.Cookies["myCookie"];

            if (cookieData != null && cookieData!="")
            {

                List<int> productIds = cookieData.Split("-").Select(x => int.Parse(x)).ToList();
                List<Combo> productList = await _comboService.GetByIds(productIds.Distinct());
                List<Product> cartList = await _productService.GetByIds(productIds.Distinct());
                CartVM vm = new()
                {
                    ProIds = productIds,
                    CartItems = productList,
                    ProductItems = cartList,
                };
                return View(vm);
            }





            return View();
        }
    }
}
