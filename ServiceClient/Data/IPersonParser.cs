using ServiceClient.Models;

namespace ServiceClient.Data;

public interface IPersonParser
{
    IEnumerable<Person> ParseCsvLines(IEnumerable<string> lines);
}