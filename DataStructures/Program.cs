using DataStructures.BasicMaths;
using System;
using System.Collections.Generic;

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
                //--------------------------------------------------------------------------------------------------
                case "FindGcd":
                    Console.WriteLine("Enter the first number:");
                    var gcdVal1 = Console.ReadLine();

                    Console.WriteLine("Enter the second number:");
                    var gcdVal2 = Console.ReadLine();

                    if (int.TryParse(gcdVal1, out var gcdParam1) && int.TryParse(gcdVal2, out var gcdParam2))
                    {
                        var obj = new GCD_LCM();
                        obj.GcdByEuclideanProcess(gcdParam1, gcdParam2);
                        //Console.WriteLine($"The GCD of {gcdParam1} and {gcdParam2} is: {result}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid number. Please enter valid integers.");
                    }
                    break;
                //-----------------------------------------------------------------------------------------
                case "QuadraticEquation":
                    Console.WriteLine("Enter the first coefficient:");
                    var quadVal1 = Console.ReadLine();

                    Console.WriteLine("Enter the second coefficient:");
                    var quadVal2 = Console.ReadLine();

                    Console.WriteLine("Enter the third coefficient:");
                    var quadVal3 = Console.ReadLine();

                    if (int.TryParse(quadVal1, out var quadParam1) && int.TryParse(quadVal2, out var quadParam2)&& int.TryParse(quadVal3, out var quadParam3))
                    {
                        var obj = BasicMaths.BasicMaths.QuadraticRoots(quadParam1, quadParam2, quadParam3);
                        foreach(var items in obj) {
                            Console.Write($"The roots is/are {items}" + " ");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid number. Please enter valid integers.");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }
        }
    }
}