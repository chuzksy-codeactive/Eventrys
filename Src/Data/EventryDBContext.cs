using Eventrys.Src.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Eventrys.Src.Data
{
    public class EventrysDBContext : DbContext 
    {
        public EventrysDBContext(DbContextOptions<EventrysDBContext> options) : base (options)
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Center> Centers { get; set; }
        public DbSet<Facility> Facilities { get; set; }
    }
}