using Entitites;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebUI.Areas.ViewModel
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public SelectList Categories { get; set; }
        public SelectList Ratings { get; set; }
    }
}
