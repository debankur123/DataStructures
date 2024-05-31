using System;

namespace DataStructures.BasicMaths
{
    public static class BasicMaths
    {
        public static bool IsPalindrome(int value)
        {
            var temp = value;
            var revNum = 0;
            while (value != 0)
            {
                var lastDigit = value % 10;
                revNum = (revNum * 10) + lastDigit;
                value /= 10;
            }
            return Math.Abs(revNum) == temp;
        }

        public static string IsArmstrongNo(int n)
        {
            var temp = n;
            var sum = 0;
            while (n != 0)
            {
                var lastDigit = n % 10;
                sum += (lastDigit * lastDigit * lastDigit);
                n /= 10;
            }
            return sum == temp ? "Yes" : "No";
        }
    }
}
