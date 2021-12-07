using Microsoft.EntityFrameworkCore;
using PersonService.Models;
namespace PersonService.Persistence
{
    public class PersonDbContext : DbContext
    {
        public PersonDbContext(DbContextOptions<PersonDbContext> options) : base(options) {}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {        
            //modelBuilder.Entity<Person>()
              //  .ToTable("Integration Message Schema");
        }
        public DbSet<Person> Persons {get; set;}
    }
}