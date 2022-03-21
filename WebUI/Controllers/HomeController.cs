using Microsoft.AspNetCore.Mvc;
using Services;
using System.Diagnostics;
using WebUI.Models;
using WebUI.ViewModels;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SliderService _sliderService;
        private readonly CategoryService _categoryService;
        private readonly ProductService _productService;

        public HomeController(ILogger<HomeController> logger, SliderService sliderService, CategoryService categoryService, ProductService productService)
        {
            _logger = logger;
            _sliderService = sliderService;
            _categoryService = categoryService;
            _productService = productService;
        }

        public IActionResult Index()
        {

            HomeVM vm = new()
            {
                Sliders = _sliderService.GetAll(),
                Products = _productService.GetAll(),
                Categories = _categoryService.GetAll(),

            };
            return View(vm);
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