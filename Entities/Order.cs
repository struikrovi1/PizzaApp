using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitites
{
    public class Order : Base
    {
        public Product Product { get; set; }
         
        public int? ProductId { get; set; }  

        public Combo Combo { get; set; }

        public int? ComboId { get; set; }    

        public string Phone { get; set; }
        public string? PhotoUrl { get; set; }

        public string? OrderTitle1 { get; set; }

        public string? OrderTitle2 { get; set; }

    }
}
