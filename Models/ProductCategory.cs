using System;
using System.Collections.Generic;

namespace Movies
{
    public class ProductCategory
    {
        public DateTime PublicationDate { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    } 
}