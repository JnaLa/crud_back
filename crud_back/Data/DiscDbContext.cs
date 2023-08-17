using crud_back.Models;
using Microsoft.EntityFrameworkCore;

namespace crud_back.Data
{
    public class DiscDbContext : DbContext
    {
        

        public DiscDbContext(DbContextOptions<DiscDbContext> options) : base(options) 
        { 

        }

        public DbSet<Disc> Discs { get; set; }
        public DbSet<PuttingPractise> Practises { get; set;}
        public DbSet<User> Users { get; set; }
    }
}
