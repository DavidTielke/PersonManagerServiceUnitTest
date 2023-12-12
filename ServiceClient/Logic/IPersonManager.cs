using ServiceClient.Models;

namespace ServiceClient.Logic;

public interface IPersonManager
{
    IQueryable<Person> GetAll();
    IQueryable<Person> GetAllAdults();
    IQueryable<Person> GetAllChildren();
}