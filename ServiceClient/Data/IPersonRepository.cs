using ServiceClient.Models;

namespace ServiceClient.Data;

public interface IPersonRepository
{
    IQueryable<Person> Query();
    void Insert(Person person);
}