using System;
using System.Collections.Generic;

namespace Movies
{
    public class OrderDetial
    {
        public int MovieId { get; set; }

        public Movie Movie { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
