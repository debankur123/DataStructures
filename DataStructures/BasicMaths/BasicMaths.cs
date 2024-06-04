using System;
using System.Collections.Generic;

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
                sum += lastDigit * lastDigit * lastDigit;
                n /= 10;
            }
            return sum == temp ? "Yes" : "No";
        }
        public static List<int> QuadraticRoots(int a, int b, int c) { 
            var roots = new List<int>();
            int root1, root2 = 0;
            int discrimination = (int)(Math.Pow(b, 2) - 4 * a * c);
            if (discrimination < 0) {
                roots.Add(-1);
            }
            else if (discrimination > 0)
            {
                root1 = (int)Math.Floor(-b + Math.Sqrt(discrimination)) / (2 * a);
                root2 = (int)Math.Floor(-b - Math.Sqrt(discrimination)) / (2 * a);
                roots.Add(Math.Max(root1,root2));
                roots.Add(Math.Min(root1, root2));
            }
            else
            {
                int singleRoot = -b / (2 * a);
                roots.Add(singleRoot);
            }
            return roots;
        }
    }
}
