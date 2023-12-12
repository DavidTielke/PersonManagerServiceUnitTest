using ServiceClient.Models;

namespace ServiceClient.Data;

public class PersonParser : IPersonParser
{
    public IEnumerable<Person> ParseCsvLines(IEnumerable<string> lines)
    {
        if (lines == null)
        {
            throw new ArgumentNullException(nameof(lines));
        }

        var persons = lines.Select(l => l.Split(","))
            .Select(p => new Person
            {
                Id = int.Parse(p[0]),
                Name = p[1],
                Age = int.Parse(p[2])
            });
        return persons;
    }
}