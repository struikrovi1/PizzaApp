using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitites
{
    public class Booking : Base
    {
        [DisplayName("Person Count")]
        public  int Person { get; set; }

        //[DataType(DataType.Date)]
        //public DateTime? Date { get; set; }

        //[DataType(DataType.DateTime)]
        //public DateTime? Time { get; set; }


        [DisplayName("Reservation")]
        public DateTime ReguestTime { get; set; }
    }
}
