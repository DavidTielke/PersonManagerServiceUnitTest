using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.ServiceClient.Data.FileLoaderTest
{
    public partial class FileLoaderTests
    {
        [Test]
        public void LoadLines_EmptyFile_EmptyArrayReturned()
        {
            var actual = _sut.LoadLines();

            actual.Should().HaveCount(0);
        }

        [Test]
        public void LoadLines_OneLineInFile_OneLineReturned()
        {
            FileLoaderHelper.SeedData("test");

            var actual = _sut.LoadLines();

            actual.Should().HaveCount(1);
        }


        [Test]
        public void LoadLines_TwoLineInFile_TwoLineReturned()
        {
            FileLoaderHelper.SeedData("test1\ntest2");

            var actual = _sut.LoadLines();

            actual.Should().HaveCount(2);
        }
    }
}

