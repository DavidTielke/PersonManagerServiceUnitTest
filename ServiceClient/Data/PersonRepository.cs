using ServiceClient.Models;

namespace ServiceClient.Data
{
    public class PersonRepository : IPersonRepository
    {
        private IFileLoader _loader;
        private IPersonParser _parser;

        public PersonRepository(IFileLoader loader, 
            IPersonParser parser)
        {
            _loader = loader;
            _parser = parser;
        }


        public IQueryable<Person> Query()
        {
            var lines = _loader.LoadLines();
            var persons = _parser.ParseCsvLines(lines);
            return persons.AsQueryable();
        }
    }
}
