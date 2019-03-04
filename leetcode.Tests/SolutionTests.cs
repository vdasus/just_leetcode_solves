using System;
using FluentAssertions;
using leetcode;
using Xunit;

namespace leetcodeTests
{
    public class SolutionTests
    {
        #region solution 1

        [Trait("29. Divide Two Integers", "Unit")]
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
        [InlineData(Int32.MinValue, -2, 1073741824)]
        [InlineData(Int32.MinValue, -3, 715827882)]
        [InlineData(Int32.MinValue, Int32.MinValue, 1)]
        [InlineData(Int32.MinValue, 1, int.MinValue)]
        [InlineData(1, Int32.MinValue, 0)]
        public void Solution_Divide(int num, int div, int result)
        {
            var sut = Solution.Divide(num, div);
            sut.Should().Be(result);
        }

        #endregion

        [Trait("32. Longest Valid Parentheses", "Unit")]
        [Theory]
        [InlineData(")", 0)]
        [InlineData("()", 2)]
        [InlineData("(()", 2)]
        [InlineData(")()())", 4)]
        [InlineData("()(())", 6)]
        [InlineData("()()(())", 8)]
        [InlineData("()((()))", 8)]
        [InlineData("()()((()))", 10)]
        [InlineData("()()(((())))", 12)]
        [InlineData("()(()", 2)]
        [InlineData("()((())", 4)]
        [InlineData("(()((())()", 6)]
        public void LongestValidParentheses(string data, int count)
        {
            var sut = Solution.LongestValidParentheses(data);
            sut.Should().Be(count);
        }
    }
}
