using System;

namespace ConsoleApp1
{
    public static class Solution
    {
        public static int Divide(int dividend, int divisor)
        {
            if (dividend == Int32.MinValue && divisor < 0)
                return Int32.MaxValue;

            int result = 0;

            var signNegative = (divisor < 0) ^ (dividend < 0);

            var modDividend = Math.Abs((long)dividend);
            var modDiv = Math.Abs((long)divisor);

            /*while (modDividend > 0)
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
    }
}