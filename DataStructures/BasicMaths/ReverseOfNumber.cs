namespace DataStructures.BasicMaths
{
    public static class ReverseOfNumber
    {
        public static int ReverseOfInteger(int value)
        {
            long revNum = 0;
            while (value != 0)
            {
                var lastDigit = value % 10;
                revNum = (revNum * 10) + lastDigit;
                value /= 10;
            }
            return revNum is > int.MaxValue or < int.MinValue ? 0 : (int)revNum;
        }
    }
}
