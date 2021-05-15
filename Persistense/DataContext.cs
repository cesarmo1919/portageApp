using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistense
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options)
            : base(options)
        {
            
        }

        public DbSet<Mission> Missions { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Intermediate> Intermediates { get; set; }
    }
}