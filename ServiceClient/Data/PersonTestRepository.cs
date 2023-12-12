using ServiceClient.Models;

namespace ServiceClient.Data
{
    public class PersonTestRepository : IPersonRepository
    {
        public IQueryable<Person> Query()
        {
            return new List<Person>
            {
                new Person(1, "TestAdult1", 18),
                new Person(2, "TestAdult2", 19),
                new Person(3, "TestChild", 17),
            }.AsQueryable();
        }

        public void Insert(Person person)
        {
            
        }
    }
}
