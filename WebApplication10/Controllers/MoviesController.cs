using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab2_api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lab2_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private Models.MoviesDbContext context;
        public MoviesController(Models.MoviesDbContext context)
        {
            this.context = context;
        }

        // GET: api/Flowers
        [HttpGet]
         public IEnumerable<Models.Movie> Get()
         {
           return context.Movies.Include(t => t.Comments).Where(m => m.Date <= new DateTime(2019, 3, 11, 11, 20, 0)
           && m.Date >= new DateTime(2019, 3, 10, 12, 30, 0)).OrderBy(m => m.Year);
        }




        // public IEnumerable<Models.Movie> GetAll(DateTime? from = null, DateTime? to = null)
        // {
        //     IQueryable<Movie> result = context
        //         .Movies
        //         .Include(f => f.Comments);
        //     if (from == null && to == null)
        //     {
        //         return result.Select(m => Models.Movie.FromMovie(m));
        //     }
        //     if (from != null)
        //     {
        //         result = result.Where(m => m.DatePicked >= from);
        //     }
        //     if (to != null)
        //     {
        //         result = result.Where(m => m.DatePicked <= to);
        //     }
        //      return result.Select(f => Models.Movie.FromMovie(m));
        //  }


        //   public IEnumerable<Models.Movie> Get([FromQuery]DateTime? from, [FromQuery]DateTime? to)
        //  {
        //       return Movie.GetAll(from, to);
        //   }



        // GET: api/Products/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var existing = context.Movies.FirstOrDefault(movie => movie.Id == id);
            if (existing == null)
            {
                return NotFound();
            }

            return Ok(existing);
        }

        // POST: api/Products
        [HttpPost]
        public void Post([FromBody] Movie movie)
        {
            //if (!ModelState.IsValid)
            //{

            //}
            context.Movies.Add(movie);
            context.SaveChanges();
        }

        // PUT: api/Flowers/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Movie movie)
        {
            var existing = context.Movies.Include(t => t.Comments).AsNoTracking().FirstOrDefault(m => m.Id == id);
            if (existing == null)
            {
                context.Movies.Add(movie);
                context.SaveChanges();
                return Ok(movie);
            }
            movie.Id = id;
            context.Movies.Update(movie);
            context.SaveChanges();
            return Ok(movie);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existing = context.Movies.FirstOrDefault(movie => movie.Id == id);
            if (existing == null)
            {
                return NotFound();
            }
            context.Movies.Remove(existing);
            context.SaveChanges();
            return Ok();
        }
    }
}

