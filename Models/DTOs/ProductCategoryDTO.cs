using System;
using System.Collections.Generic;

namespace Movies{

public class ProductCategoryDTO
{
    //public DateTime PublicationDate { get; set; }
    public int MovieId { get; set; }
    public MovieDTO Movie { get; set; }

    public int CategoryId { get; set; }
    public CategoryDTO Category { get; set; }
}
}  