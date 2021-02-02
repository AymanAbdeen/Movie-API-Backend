using AutoMapper;

namespace Movies
{

    public class AutoMapping : Profile
    {

        public AutoMapping()
        {
            CreateMap<Movie, MovieDTO>();
            CreateMap<MovieDTO, Movie>();

            CreateMap<Category, CategoryDTO>();
            CreateMap<CategoryDTO, Category>();

            CreateMap<Order, OrderDTO>();
            CreateMap<OrderDTO, Order>(); 
        }

    }
}