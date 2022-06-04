using HastaneFinder.Entitiy;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneFinder.DataAcess
{
    public class HastaneDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-FHSN1O8;Database=HastaneEgzersiz;Trusted_Connection=true");

        }

        public DbSet<Hastaneler> hastaneler { get; set; }
    }
}
