using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hain_Mvc_Movies.Models;

namespace Hain_Mvc_Movies.Data
{
    public class Hain_Mvc_MoviesContext : DbContext
    {
        public Hain_Mvc_MoviesContext (DbContextOptions<Hain_Mvc_MoviesContext> options)
            : base(options)
        {
        }

        public DbSet<Hain_Mvc_Movies.Models.Movie> Movie { get; set; }
    }
}
