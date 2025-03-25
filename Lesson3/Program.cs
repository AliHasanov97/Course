using System;
using System.ComponentModel;

namespace Lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //Write a C# program that takes two numbers as input and returns true or false when both numbers are even or odd
            int a, b;
            Console.WriteLine("Enter the first number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            b = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0 && b % 2 == 0 || a % 2 != 0 && b % 2 != 0)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            #endregion

            #region Task 2
            //Write a C# program which takes 2 string input from user and return if second string is in first string.
            //Example. 1st input: Azərbaycan, 2nd input: can, Result should be true because can is in Azərbaycan
            string str1, str2;
            Console.WriteLine("Enter the first string: ");
            str1 = Console.ReadLine();
            Console.WriteLine("Enter the second string: ");
            str2 = Console.ReadLine();
            if (str1.Contains(str2))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            #endregion

            #region Task 3
            //Get 2 int number input from user and calculate the exact input1 / input2.Example: 16, 5.Result should be 3.2 not 3.
            int num1, num2;
            Console.WriteLine("Enter the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((double)num1 / num2);
            #endregion
        }
    }
}
