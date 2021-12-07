using Microsoft.EntityFrameworkCore;
using PersonService.Models;
namespace PersonService.Persistence
{
    public class PersonDbContext : DbContext
    {
        public PersonDbContext(DbContextOptions<PersonDbContext> options) : base(options) {}
        public DbSet<Person> Persons {get; set;}
    }
    /*    public class PersonDbContextFactory : IDbContextFactory<PersonDbContext>
    {
        public PersonDbContext Create(DbContextFactoryOptions options)
        {
            var optionsBuilder = new DbContextOptionsBuilder<PersonDbContext>();
            var connectionString = Startup.Configuration.GetSection("postgres:cstr").Value;
            optionsBuilder.UseNpgsql(connectionString);

            return new PersonDbContext(optionsBuilder.Options);
        }
    } */   
}