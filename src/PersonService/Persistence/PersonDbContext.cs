using Microsoft.EntityFrameworkCore;
using PersonService.Models;
namespace PersonService.Persistence
{
    public class PersonDbContext : DbContext
    {
        public PersonDbContext(DbContextOptions<PersonDbContext> options) : base(options) {}



        public DbSet<Person> Persons {get; set;}
    }
}