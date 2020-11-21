using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CINEMA_DB.Models;

namespace CINEMA_DB.Data
{
    public class CINEMA_DBContext : DbContext
    {
        public CINEMA_DBContext (DbContextOptions<CINEMA_DBContext> options)
            : base(options)
        {
        }

        public DbSet<CINEMA_DB.Models.Staff> Staff { get; set; }

        public DbSet<CINEMA_DB.Models.Seat> Seat { get; set; }

        public DbSet<CINEMA_DB.Models.Repertoire> Repertoire { get; set; }

        public DbSet<CINEMA_DB.Models.Position> Position { get; set; }

        public DbSet<CINEMA_DB.Models.Genre> Genre { get; set; }

        public DbSet<CINEMA_DB.Models.Film> Film { get; set; }
    }
}
