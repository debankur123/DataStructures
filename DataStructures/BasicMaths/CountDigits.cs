namespace DataStructures.BasicMaths
{
    public static class CountDigits
    {
        public static int CountOfDigits(int n)
        {
            var count = 0;
            while (n>0)
            {
                var lastDigit = n % 10;
                count += 1;
                n /= 10;
            }
            return count;
        }
        public static int CountEvenlyDigits(int n)
        {
            var temp = n;
            var count = 0;
            while (n > 0) {
                var lastDigit = n % 10;
                if (lastDigit > 0)
                {
                    if(temp%lastDigit == 0)
                    {
                        count += 1;
                    }
                }
                n /= 10;
            }
            return count;
        }
    }
}
