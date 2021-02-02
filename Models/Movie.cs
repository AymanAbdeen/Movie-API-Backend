using System;
using System.Collections.Generic;

namespace Movies{
    
public class Movie
{
    public int Id { get; set; }
    public string name { get; set; }
    public int price { get; set; }
    public string imageUrl { get; set; }
    public DateTime Added { get; set; }
    public int year { get; set; }

    //public ICollection<Category> Categorys { get; set; }
    public List<OrderDetial> OrderDetials { get; set; }
    public List<ProductCategory> ProductCategorys { get; set; }

}
}
