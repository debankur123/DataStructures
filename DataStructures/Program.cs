
using DataStructures.BasicMaths;
using System;

namespace DataStructures
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your choice:");
            var input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.WriteLine("Enter the number:");
                    var numberInput = Console.ReadLine();
                    if (int.TryParse(numberInput, out var n))
                    {
                        var result = CountDigits.CountOfDigits(n);
                        Console.WriteLine("The count of digits is: " + result);
                    }
                    else
                    {
                        Console.WriteLine("Invalid number. Please enter a valid integer.");
                    }
                    break;
            //---------------------------------------------------------------------
                case "2":
                    Console.WriteLine("Enter the number:");
                    var evenlyDigitInput = Console.ReadLine();
                    if (int.TryParse(evenlyDigitInput, out var x))
                    {
                        var result = CountDigits.CountEvenlyDigits(x);
                        Console.WriteLine("The count of evenly digits is: " + result);
                    }
                    else
                    {
                        Console.WriteLine("Invalid number. Please enter a valid integer.");
                    }
                    break;
                //-------------------------------------------------------------------------
                case "ReverseOfInteger":
                    Console.WriteLine("Enter the number:");
                    var numToReverse = Console.ReadLine();
                    if (int.TryParse(numToReverse, out var param1))
                    {
                        var result = ReverseOfNumber.ReverseOfInteger(param1);
                        Console.WriteLine("The reversed number is: " + result);
                    }
                    else
                    {
                        Console.WriteLine("Invalid number. Please enter a valid integer.");
                    }
                    break;
                //-------------------------------------------------------------------------
                case "IsPalindrome":
                    Console.WriteLine("Enter the number:");
                    var numToCheck = Console.ReadLine();
                    if (int.TryParse(numToCheck, out var param2))
                    {
                        var result = BasicMaths.BasicMaths.IsPalindrome(param2);
                        Console.WriteLine(result ? "This is a palindrome no" : "This is not a palindrome no");
                    }
                    else
                    {
                        Console.WriteLine("Invalid number. Please enter a valid integer.");
                    }
                    break;
                //-------------------------------------------------------------------------
                case "IsArmstrong":
                    Console.WriteLine("Enter the number:");
                    var input1 = Console.ReadLine();
                    if (int.TryParse(input1, out var param3))
                    {
                        var result = BasicMaths.BasicMaths.IsArmstrongNo(param3);
                        Console.WriteLine(result == "Yes" ? "This is an armstrong no" : "This is not an armstrong no");
                    }
                    else
                    {
                        Console.WriteLine("Invalid number. Please enter a valid integer.");
                    }
                    break;

//-----------------------------------------------------------------------------------------
                case "PrintAllFactors":
                    Console.WriteLine("Enter the number:");
                    var input2 = Console.ReadLine();
                    if (int.TryParse(input2, out var param4))
                    {
                        SumOfDivisors.PrintAllFactors(param4);
                    }
                    else
                    {
                        Console.WriteLine("Invalid number. Please enter a valid integer.");
                    }
                    break;
//-----------------------------------------------------------------------------------------
                case "IsPrimeOrNotOptimal":
                    Console.WriteLine("Enter the number:");
                    var input3 = Console.ReadLine();
                    if (int.TryParse(input3, out var param5))
                    {
                        var result = PrimeNo.IsPrimeOrNotOptimal(param5);
                        Console.Write(result);
                    }
                    else
                    {
                        Console.WriteLine("Invalid number. Please enter a valid integer.");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }
        }
    }
}
