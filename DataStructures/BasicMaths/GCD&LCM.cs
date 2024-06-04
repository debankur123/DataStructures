using System;

namespace DataStructures.BasicMaths
{
    public class GCD_LCM
    {
        public int FindGCDFirstApproach(int n1, int n2)
        {
            var gcd = 1;
            for (var index = 1; index < Math.Min(n1, n2); index++) {  // T.C is O(min(n1,n2))
                if(n1% index == 0 && n2 % index == 0) {
                    gcd = index;
                }
            }
            return gcd;
        }
        public void FindGCDSecondApproach(int n1, int n2)
        {
            for(var index = Math.Min(n1, n2); index >= 1; index--)
            {
                // T.C is O(min(n1,n2))
                if (n1 % index != 0 || n2 % index != 0) continue;
                Console.WriteLine($"The GCD of {n1} and {n2} is: {index}");
                break;
            }
        }
        //--------------------------  EUCLIDEANS ALGORITHM------------------------------------

        // Given two non-negative integers a & b,we have to find their GCD, that is the largest no that is the divisor of both a & b. => gcd(a,b). Mathematically denoted as below
        //Equation --> gcd(a,b) = max{k>0 : (k/a) && (k/b)} and this implies that gcd(a,b)=gcd(a%b,b) i.e (greater%smaller,smaller)

        public void GcdByEuclideanProcess(int a,int b)
        {
            while(a>0 && b>0)
            {
                if (a > b) {
                    a %= b;
                }
                else { b %= a; }
            }
            Console.WriteLine(a == 0 ? $" Gcd is {b}" : $" Gcd is {a}");
        }
    }
}
