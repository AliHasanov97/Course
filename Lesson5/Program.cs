using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Lesson5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //Write a program in C# to display the first 10 natural numbers
            //Expected Output:
            //1 2 3 4 5 6 7 8 9 10

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write(i + " ");
            //}
            #endregion

            #region Task 2
            //Write a C# program to find the sum of first 20 odd natural numbers.

            //int sum = 0;
            //for (int i = 1, count = 0; count < 20; i += 2, count++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);
            #endregion

            #region Task 3
            //Write a program in C# to read 5 numbers from keyboard and find their sum and average.

            //int sum1 = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{i+1} number");
            //    sum1 += int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Sum: " + sum1);
            //Console.WriteLine("Average: " + sum1 / 5);
            #endregion

            #region Task 4
            //Write a program in C# to display the multiplication table vertically from 1 to n.
            //Test Data: Input upto the table number starting from 1 : 8
            //Expected Output: Multiplication table from 1 to 8 1x1 = 1, 2x1 = 2, 3x1 = 3, 4x1 = 4, 5x1 = 5, 6x1 = 6, 7x1 = 7, 8x1 = 8
            //... 1x10 = 10, 2x10 = 20, 3x10 = 30, 4x10 = 40, 5x10 = 50, 6x10 = 60, 7x10 = 70, 8x10 = 80

            //Console.WriteLine("Input upto the table number starting from 1: ");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= n; j++)
            //    {
            //        Console.Write($"{j}x{i} = {j * i}, ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Task 5
            //Write a program in C# to display the pattern like right angle triangle using an asterisk. The pattern like :
            //*
            //**
            //***
            //****
            //*****

            //Console.WriteLine("Input number of rows : ");
            //int rows = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= rows; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Task 6
            //Write a program in C# to make such a pattern like right angle triangle with number increased by 1.
            //The pattern like :
            //1
            //2 3
            //4 5 6
            //7 8 9 10

            //Console.WriteLine("Input number of rows : ");
            //int rows1 = int.Parse(Console.ReadLine());
            //int count = 1;
            //for (int i = 1; i <= rows1; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(count + " ");
            //        count++;
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Task 7
            //Write a program in C# to display the sum of the series [ 9 + 99 + 999 + 9999 ...].
            //Test Data : Input the number or terms :5
            //Expected Output : 9 99 999 9999 99999
            //The sum of the series = 111105

            //Console.WriteLine("Input the number of terms: ");
            //int terms = int.Parse(Console.ReadLine());
            //int sum2 = 0;
            //for (int i = 1, number = 9; i <= terms; i++)
            //{
            //    Console.Write(number + " ");
            //    sum2 += number;
            //    number = number * 10 + 9;
            //}
            //Console.WriteLine("The sum of the series = " + sum2);
            #endregion

            #region Task 8
            //Write a C# program to find prime numbers up to users entered value.
            //Exmpl: input-100, Result: 2, 3, 5, 7, 11, 13 ... 89, 97

            //Console.WriteLine(
            //    "Input the number to find prime numbers up to users entered value: ");
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine(
            //    "Prime numbers up to users entered value: ");
            //for (int i = 2; i <= number; i++)
            //{
            //    bool isPrime = true;
            //    for (int j = 2; j <= i / 2; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //    }
            //    if (isPrime)
            //    {
            //        Console.Write(i + " ");
            //    }
            //}
            #endregion

            #region Task 9
            //Write a program in C# to check whether a number can be express as sum of two prime numbers.
            //Test Data :
            //Input a positive integer: 16
            //Expected Output :
            //16 = 3 + 13
            //16 = 5 + 11
            #endregion

            #region Task 10
            //Write a program in C# to check whether a number is a palindrome (visual simmetric) or not. Test Data :
            //Input a number: 121
            //Expected Output :
            //121 is a palindrome number.

            //Console.WriteLine("Write number");
            //string num = Console.ReadLine();
            //if (num == new string(num.Reverse().ToArray()))
            //{
            //    Console.WriteLine($"{num} is a palindrome number.");
            //}
            //else
            //{
            //    Console.WriteLine($"{num} is not a palindrome number.");
            //}
            #endregion
        }
    }
}
