using System;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using PersonService.Persistence;
using Xunit;

namespace PersonService
{
    public class UnitTest1
    {
        private PersonRepository repo;
        public UnitTest1(){
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            var optionsBuilder = new DbContextOptionsBuilder<PersonDbContext>();
            optionsBuilder.UseNpgsql(config["postgres:cstr"]);
                PersonDbContext db = new PersonDbContext(optionsBuilder.Options);
            repo = new PersonRepository(db);    
        }


        [Fact]
        public void Test1()
        {            
            var p = repo.Get(1);
            Assert.Equal("Kirill", p.Name);
        }
    }
}
