﻿using Microsoft.EntityFrameworkCore;
namespace PracticaMVC1.Models
{
    public class equiposDbContext : DbContext
    {
        public equiposDbContext(DbContextOptions options) : base(options) {
        }
        public DbSet<marcas> marcas { get; set; }
        public DbSet<equipos> equipos { get; set; }


    }
}
