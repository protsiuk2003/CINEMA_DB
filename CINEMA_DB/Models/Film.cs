﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CINEMA_DB.Models
{
    public class Film
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
        public string Manufacturer { get; set; }
        public string  CountryOfOrigin{ get; set; }
        public string Actors { get; set; }
        public int AgeRestrictions { get; set; }
        public string Description{ get; set; }
        public long? GenreID { get; set; }
        public DbSet<Genre> Genre { get; set; }

    }
}
