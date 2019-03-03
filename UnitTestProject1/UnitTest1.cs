using System;
using ConsoleApp1;
using FluentAssertions;
using Xunit;

namespace UnitTestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(0, 1, 0)]
        [InlineData(1, 1, 1)]
        [InlineData(2, 1, 2)]
        [InlineData(10, 1, 10)]
        [InlineData(4, 2, 2)]
        [InlineData(5, 2, 2)]
        [InlineData(-5, 2, -2)]
        [InlineData(-5, -2, 2)]
        [InlineData(Int32.MaxValue, Int32.MaxValue, 1)]
        [InlineData(Int32.MinValue, -1, int.MaxValue)]
        [InlineData(Int32.MinValue, -2, int.MaxValue)]
        [InlineData(Int32.MinValue, Int32.MinValue, int.MaxValue)]
        [InlineData(Int32.MinValue, 1, int.MinValue)]
        [InlineData(1, Int32.MinValue, 0)]
        public void Solution_Divide(int num, int div, int result)
        {
            var sut = Solution.Divide(num, div);
            sut.Should().Be(result);
        }
    }
}
