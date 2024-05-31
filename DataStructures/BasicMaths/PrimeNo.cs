namespace DataStructures.BasicMaths
{
    public static class PrimeNo
    {
        public static bool IsPrimeOrNotBruteForce(int x)
        {
            var count = 0;
            for (var i = 1; i <= x; i++)
            {
                if (x % i == 0)
                {
                    count += 1;
                }
            }
            return count == 2 ? true : false;
        }
        public static bool IsPrimeOrNotOptimal(int n)
        {
            var count = 0;
            for (var idx = 1; idx * idx <= n; idx++)
            {
                if (n % idx != 0) continue;
                count += 1;
                if ((n / idx) != idx)
                {
                    count += 1;
                }
            }
            return count is 2 ? true : false;
        }
    }
}