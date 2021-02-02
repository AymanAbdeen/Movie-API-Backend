using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Movies
{

    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly MovieContext _context;
        private readonly IMapper _mapper;
        public MoviesController(MovieContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }



        [HttpGet]
        public async Task<ActionResult> GetMovies()
        {
            List<Movie> movies = await _context.Movies
            .Include(b => b.ProductCategorys).ToListAsync();

            List<MovieDTO> movieDTOs = _mapper.Map<List<MovieDTO>>(movies);

            return Ok(movieDTOs);
        }



        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult> GetById(int id)
        {
            Movie found = await _context.Movies.FindAsync(id);

            if (found == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<MovieDTO>(found));
        }

        [HttpPost]
        public async Task<ActionResult> CreateMovie(MovieDTO newMovieDTO)
        {
            Movie newMovie = _mapper.Map<Movie>(newMovieDTO);

            newMovie.Added = DateTime.Now;
            _context.Movies.Add(newMovie);
            await _context.SaveChangesAsync();

            return CreatedAtAction("CreateMovie", newMovie);
        }



        [HttpPost]
        [Route("category")]
        public async Task<ActionResult> CreateCategory(CategoryDTO newCategoryDTO)
        {
            Category newCategory = _mapper.Map<Category>(newCategoryDTO);

            //newCategory.Added = DateTime.Now;
            _context.Categorys.Add(newCategory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("CreateCategory", newCategory);
        }





        [HttpGet]
        [Route("ordars")]
        public async Task<ActionResult> GetOrdars()
        {
            List<Order> Ordars = await _context.Orders
            .Include(o => o.OrderDetials).ToListAsync();


            List<OrderDTO> orderDTOs = _mapper.Map<List<OrderDTO>>(Ordars);

            return Ok(orderDTOs);
        }


        [HttpGet]
        [Route("ordars/{id}")]
        public async Task<ActionResult> GetOrderById(int id)
        {
            Order found = await _context.Orders.FindAsync(id);

            if (found == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<OrderDTO>(found));
        }



        [HttpPost]
        [Route("ordars")]
        public async Task<ActionResult> CreateOrder(OrderDTO newOrderDTO)
        {
            Order newOrder = _mapper.Map<Order>(newOrderDTO);

            newOrder.created = DateTime.Now;
            _context.Orders.Add(newOrder);
            await _context.SaveChangesAsync();

            return CreatedAtAction("CreateOrder", newOrder);
        }



        [HttpDelete("ordars/{id}")]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            var order = await _context.Orders.FindAsync(id);

            if (order == null)
            {
                return NotFound();
            }

            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }

}