using ServiceClient.Data;
using ServiceClient.Models;

namespace UnitTests.ServiceClient.Logic.PersonManagerTest;

class RepoMock : IPersonRepository
{
    public List<Person> Items { get; set; }

    public RepoMock()
    {
        Items = new List<Person>();
    }

    public IQueryable<Person> Query()
    {
        return Items.AsQueryable();
    }
}