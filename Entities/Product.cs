using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitites
{
    public class Product : Base
    {

        public string Name { get; set; }    
        public int CategoryId { get; set; } 
        public Category Category { get; set; }

        public decimal? Rating { get; set; }

        public decimal? Reviews { get; set; }

        public string Summary { get; set; }

        public string? PhotoUrl { get; set; }
        public decimal Price { get; set; }
        public decimal? Discount { get; set; }
        public string Description { get; set; }
    }
}
