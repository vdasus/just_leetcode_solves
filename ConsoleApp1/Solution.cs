using System;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    public static class Solution
    {
        public static int Divide(int dividend, int divisor)
        {
            if (dividend == Int32.MinValue && divisor == -1)
                return Int32.MaxValue;

            int result = 0;

            var signNegative = (divisor < 0) ^ (dividend < 0);

            var modDividend = Math.Abs((long)dividend);
            var modDiv = Math.Abs((long)divisor);

            /* Commented is enough to solve, but below is better
            while (modDividend > 0)
            {
                modDividend -= modDiv;
                if (modDividend >= 0) result++;
            }*/

            while (modDividend >= modDiv)
            {
                var shift = 1;

                while (modDividend >= modDiv << shift) shift++;

                modDividend -= modDiv << (shift - 1);
                result += 1 << (shift - 1);
            }

            return signNegative ? -result : result;
        }

        public static int LongestValidParentheses(string s)
        {
            var REGEXP = @" 
            \( 
            (?:                 
            (\(\))*
		    |
		    (?<open> \()
            |
            (?<-open> \))
            )+
            (?(open)(?!))
            \)";

            var cnt = 0;
            
            var m = Regex.Match(s, REGEXP, RegexOptions.IgnorePatternWhitespace);
            
            while (m.Success)
            {
                cnt += m.Value.Length;
                m = m.NextMatch();
            }

            return cnt;
        }
    }
}