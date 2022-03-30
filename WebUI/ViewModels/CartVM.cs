
using Entitites;

namespace Web.ViewModels
{
    public class CartVM
    {
        public  List<Combo> CartItems { get; set; }   

        public List<int> ProIds { get; set; }

        public List<Product> ProductItems { get; set; }
    }
}
