using ServiceClient.Data;

namespace UnitTests.ServiceClient.Data.PersonParserTest
{
    [TestFixture]
    public partial class PersonParserTests
    {
        private PersonParser _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new PersonParser();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}