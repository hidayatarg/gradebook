using System;
using Xunit;

namespace GradeBook.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var x = 5;
            var y = 6;
            var result = 11;

            var actual = x+y;
            Assert.Equal(result, actual);

        }
    }
}
