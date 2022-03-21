using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitites
{
    public class Blog : Base
    {
        public string BlogName { get; set; }

        public string? BlogSummary { get; set; }

        public string BlogDate { get; set; }

        public string? PhotoUrl { get; set; }
    }
}
