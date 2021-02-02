using System;
using System.Collections.Generic;

namespace Movies
{
    public class OrderDetialDTO
    {
        //public DateTime PublicationDate { get; set; }
        public int MovieId { get; set; }
 

        public MovieDTO Movie { get; set; }

        public int OrderId { get; set; }
        public OrderDTO Order { get; set; }
    }
}
