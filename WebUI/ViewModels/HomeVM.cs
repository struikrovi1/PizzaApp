using Entitites;

namespace WebUI.ViewModels
{
    public class HomeVM
    {
        public List<MainSlider> Sliders { get; set; }

        public List<Product> Products { get; set; }
        public List<Product> Pizza { get; set; }

        public List<Category> Categories { get; set; }

        public List<Combo> Combos { get; set; }

        public List<Blog> Blogs{ get; set; }

        public Order Order { get; set; }

        public List<Chefs> Chefs { get; set; }
    }
}
