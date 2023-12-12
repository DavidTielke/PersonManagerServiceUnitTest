using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using ServiceClient.Data;
using ServiceClient.Logic;

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
    }
}
