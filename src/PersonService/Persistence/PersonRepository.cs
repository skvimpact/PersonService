using System.Linq;
using PersonService.Models;

namespace PersonService.Persistence
{
    public class PersonRepository 
    {
        private PersonDbContext context;
        public PersonRepository(PersonDbContext context)
        {
            this.context = context;
        }
        public Person Get(int id)
        {
            return this.context.Persons
                .Single(p => p.ID == id);
        }
    }
}