using System;
using System.Collections.Generic;

namespace DataStructures.BasicMaths
{
    public static class SumOfDivisors
    {
        public static void PrintAllFactors(int n)
        {
            var factorsList = new List<int>();
            for (var idx = 1; idx * idx <= n; idx++) // T.C here is O(Sqrt(N))
            {
                if (n % idx != 0) continue;
                factorsList.Add(idx);
                if ((n / idx) != idx)
                {
                    factorsList.Add(n/idx);
                }
            }
            factorsList.Sort(); // T.C -> O(NLogN)
            foreach (var items in factorsList) // T.C -> O(N)
            {
                Console.Write(items + " ");
            }
            // Overall T.C -> O(Sqrt(N)) which is better than O(N).
        }
    }
}