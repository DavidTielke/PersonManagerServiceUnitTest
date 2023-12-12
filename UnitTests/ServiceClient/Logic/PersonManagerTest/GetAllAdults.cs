using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using ServiceClient.Models;

namespace UnitTests.ServiceClient.Logic.PersonManagerTest
{
    public partial class PersonManagerTests
    {
        [Test]
        public void GetAllAdults_NoPersonsFromRepo_NoAdultsReturned()
        {
            var actual = _sut.GetAllAdults().Count();

            actual.Should().Be(0);
        }

        [Test]
        public void GetAllAdults_TwoAdultsFromRepo_TwoAdultsReturned()
        {
            _repoMock
                .Setup(m => m.Query())
                .Returns(new List<Person>
            {
                new Person(1, "Test1", 19),
                new Person(1, "Test1", 18),
            }.AsQueryable);

            var actual = _sut.GetAllAdults().Count();

            actual.Should().Be(2);
        }

        [Test]
        public void GetAllAdults_TwoChildrenFromRepo_NoAdultsReturned()
        {
            _repoMock
                .Setup(m => m.Query())
                .Returns(new List<Person>
            {
                new Person(1, "Test1", 17),
                new Person(1, "Test1", 16),
            }.AsQueryable());

            var actual = _sut.GetAllAdults().Count();

            actual.Should().Be(0);
        }

        [Test]
        public void GetAllAdults_TwoChildrenTwoAdultsFromRepo_TwoAdultsReturned()
        {
            _repoMock
                .Setup(m => m.Query())
                .Returns(new List<Person>
            {
                new Person(1, "Test1", 16),
                new Person(2, "Test1", 17),
                new Person(3, "Test1", 18),
                new Person(4, "Test1", 19),
            }.AsQueryable());

            var actual = _sut.GetAllAdults().Count();

            actual.Should().Be(2);
        }
    }
}
