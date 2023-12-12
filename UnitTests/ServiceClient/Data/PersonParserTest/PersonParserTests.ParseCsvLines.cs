using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using ServiceClient.Data;

namespace UnitTests.ServiceClient.Data.PersonParserTest
{
    public partial class PersonParserTests
    {
        [Test]
        public void ParseCsvLines_NullAsParameter_ArgumentException()
        {
            _sut
                .Invoking(p => p.ParseCsvLines(null))
                .Should()
                .Throw<ArgumentNullException>();
        }

        [Test]
        public void ParseCsvLines_EmptyCollection_EmptyPersonList()
        {
            var inputLines = new string[] { };

            var actual = _sut.ParseCsvLines(inputLines).ToList();

            actual.Count.Should().Be(0, "no item was inserted into the source collection");
        }

        [Test]
        public void ParseCsvLines_OneValidPerson_OnePersonInList()
        {
            var inputLines = new string[] { "1,Test,2" };

            var actual = _sut.ParseCsvLines(inputLines).ToList();

            actual.Count.Should().Be(1);
            var person = actual[0];
            person.Id.Should().Be(1);
            person.Name.Should().Be("Test");
            person.Age.Should().Be(2);
        }
        
        [Test]
        public void ParseCsvLines_TwoValidPerson_TwoPersonsInList()
        {
            var inputLines = new string[] { "1,Test1,2","2,Test2,3" };

            var actual = _sut.ParseCsvLines(inputLines).ToList();

            actual.Count.Should().Be(2);
        }
    }
}
