using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hippodrome
{
    public class HippodromeContext:DbContext
    {
        public DbSet<Bet> Bets { get; set; }
        public DbSet<Breed> Breeds { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Horse> Horse { get; set; }
        public DbSet<Participation> Participations { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<Rider> Riders { get; set; }
        public DbSet<RiderHorse> RiderHorses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=HippodromeDb;Trusted_Connection=True;");
        }

    }
}
