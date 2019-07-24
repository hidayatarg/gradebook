using System;
using Xunit;

namespace GradeBook.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // arrange 
            var x = 5;
            var y = 6;
            var result = 11;

            // act
            var actual = x+y;
            
            // assert
            Assert.Equal(result, actual);

        }
    }
}
