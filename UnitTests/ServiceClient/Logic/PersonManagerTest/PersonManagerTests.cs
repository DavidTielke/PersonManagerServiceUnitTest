using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using ServiceClient.Data;
using ServiceClient.Logic;
using ServiceClient.Models;

namespace UnitTests.ServiceClient.Logic.PersonManagerTest
{
    [TestFixture]
    public partial class PersonManagerTests
    {
        private Mock<IPersonRepository> _repoMock;
        private PersonManager _sut;

        [SetUp]
        public void SetUp()
        {
            _repoMock = new Mock<IPersonRepository>();
            _sut = new PersonManager(_repoMock.Object);
        }

        [TearDown]
        public void TearDown()
        {
            _sut = null;
            _repoMock = null;
        }

        [Test]
        public void Add_OnePersonIsAdded_RepoInsertIsCalled()
        {
            _sut.Add(new Person(1,"Test",23));

            _repoMock.Verify(m => m.Insert(It.IsAny<Person>()), Times.Exactly(1));
        }
    }
}
