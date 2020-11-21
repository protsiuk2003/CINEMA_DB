using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CINEMA_DB.Models
{
    public class Staff
    {
        public long ID { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string PassportData { get; set; }
        public long? PositionID { get; set; }
        public DbSet<Position> Position { get; set; }
    }
}
