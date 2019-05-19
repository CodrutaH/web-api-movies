using Lab2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2_api.Models
{
   
    public class Movie
    {
        //[Key()]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public int Duration { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        public DateTime Date { get; set; }
        [Range(1, 10)]
        public int Rating { get; set; }
        public bool Watched { get; set; }
        public List<Comment> Comments { get; set; }

    }
}