using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceClient.Data;

namespace UnitTests.ServiceClient.Data.FileLoaderTest
{
    [TestFixture]
    public partial class FileLoaderTests
    {
        private FileLoader _sut;

        [SetUp]
        public void SetUp()
        {
            _sut = new FileLoader();
            FileLoaderHelper.CreateFile();
        }

        [TearDown]
        public void TearDown()
        {
            FileLoaderHelper.DeleteFile();
        }
    }
}
