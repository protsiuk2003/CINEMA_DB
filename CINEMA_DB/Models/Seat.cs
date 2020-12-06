using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CINEMA_DB.Models
{
    public class Seat
    {
        public long ID { get; set; }
        public int Number { get; set; }
        public bool Occupancy { get; set; }
        public long? StaffID { get; set; }
        public long? RepID { get; set; }

        public DbSet<Staff> Staff { get; set; }

        public DbSet<Repertoire> Rep { get; set; }
    }
}
