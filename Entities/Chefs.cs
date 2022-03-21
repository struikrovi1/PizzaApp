using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitites
{
    public class Chefs : Base
    {

        public string Name { get; set; }
        public string PhotoUrl { get; set; }

         public string Position { get; set; }

        public int Age { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public string Experience { get; set; }

        public string? Email { get; set; }

        public string? Address { get; set; }

        public string? Phone { get; set; }
        public string? Biography { get; set; }
    }
}
