using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Lab2_api.Models
{
    public class MoviesDbContext : DbContext
    {
        public MoviesDbContext(DbContextOptions<MoviesDbContext> options) : base(options)
        {  
        }

        public DbSet<Movie> Movies { get; set; }
        
    }
}