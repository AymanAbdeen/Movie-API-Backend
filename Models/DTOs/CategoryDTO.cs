using System;
using System.Collections.Generic;

namespace Movies{

public class CategoryDTO 
{
    public int Id { get; set; }
    public string name { get; set; }
    public int MovieId { get; set; }
    public Movie Movie { get; set; }

    //public ICollection<Movie> Movies { get; set; } not with me
    public List<ProductCategoryDTO> ProductCategorys { get; set; } 
}}