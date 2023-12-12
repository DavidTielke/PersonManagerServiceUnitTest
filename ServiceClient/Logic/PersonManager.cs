using ServiceClient.Data;
using ServiceClient.Models;

namespace ServiceClient.Logic
{
    public class PersonManager : IPersonManager
    {
        private IPersonRepository _repository;

        public PersonManager(IPersonRepository repository)
        {
            _repository = repository;
        }

        public void Add(Person person)
        {
            //_repository.Insert(person);
        }

        public IQueryable<Person> GetAll()
        {
            var persons = _repository.Query();
            return persons;
        }

        public IQueryable<Person> GetAllAdults()
        {
            var adults = _repository.Query().Where(p => p.Age >= 18);
            return adults;
        }

        public IQueryable<Person> GetAllChildren()
        {
            var children = _repository.Query().Where(p => p.Age < 18);
            return children;
        }
    }
}
