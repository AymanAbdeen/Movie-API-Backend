using System;
using System.Collections.Generic;

namespace Movies{

public class OrderDTO{

    public int Id { get; set; }
    public int companyId { get; set; }
    //public string name { get; set; }
    public DateTime created { get; set; }
    public string createdBy { get; set; }
    //public string paymentMethod { get; set; }
    public int totalPrice { get; set; } 
    //public int status { get; set; } 



    //public ICollection<Movie> Movies { get; set; } not with me
    public List<OrderDetialDTO> OrderDetials { get; set; } 
}
}

