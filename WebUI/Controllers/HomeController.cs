using Entitites;
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
        private readonly ComboService _comboService;
        private readonly OrderService _orderService;
        private readonly ChefService _chefService;
        private readonly BookingService _bookingService;
        private readonly BlogService _blogService;

        public HomeController(ILogger<HomeController> logger, SliderService sliderService, CategoryService categoryService, ProductService productService, ComboService comboService, OrderService orderService, ChefService chefService, BookingService bookingService, BlogService blogService)
        {
            _logger = logger;
            _sliderService = sliderService;
            _categoryService = categoryService;
            _productService = productService;
            _comboService = comboService;
            _orderService = orderService;
            _chefService = chefService;
            _bookingService = bookingService;
            _blogService = blogService;
        }

        public IActionResult Index()
        {

            HomeVM vm = new()
            {
                Sliders = _sliderService.GetAll(),
                Products = _productService.GetAll(),
                Categories = _categoryService.GetAll(),
                Combos = _comboService.GetAll(), 
                Pizza = _productService.GetAllPizza(),
                Order = _orderService.GetAll().FirstOrDefault(),
                Chefs = _chefService.GetAll(),
                Blogs = _blogService.GetAll(),

            };
            return View(vm);
        }


        [HttpPost]
        public IActionResult Index(Booking book)
        {
            _bookingService.Add(book);
            return RedirectToAction(nameof(Index));
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