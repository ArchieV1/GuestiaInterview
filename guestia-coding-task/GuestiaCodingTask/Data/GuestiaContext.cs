using Microsoft.EntityFrameworkCore;

namespace GuestiaCodingTask.Data
{
    public class GuestiaContext : DbContext
    {
        public DbSet<Guest> Guests { get; set; }
        public DbSet<GuestGroup> GuestGroups { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=GuestiaDB;Trusted_Connection=True;");
        }
    }
}
