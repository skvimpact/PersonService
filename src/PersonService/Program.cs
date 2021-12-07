using System;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using PersonService.Persistence;

namespace PersonService
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            PersonRepository repo;
        
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            var optionsBuilder = new DbContextOptionsBuilder<PersonDbContext>();
            //optionsBuilder.UseNpgsql(config["postgres:cstr"]);
            optionsBuilder.UseNpgsql("Host=ds220;Port=65432;Database=BeeHive;Username=postgres;Password=zozo");
                PersonDbContext db = new PersonDbContext(optionsBuilder.Options);
            repo = new PersonRepository(db);   
            var p = repo.Get(1);
            Console.WriteLine(p.Name);         
        }
    }
}
