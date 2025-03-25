using System;
using System.ComponentModel;
using System.Linq;

namespace Lesson6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //Enter the value between 10 and 100. Initialize int array with random values with length of user entered value. Do following tasks
            //Write a program in C# sort array both descending and ascending order
            //Write a C# program to find the 3rd max element of array.
            //Write a program in C# to find first 4 max elements.

            //Console.WriteLine("Write number");
            //int num = int.Parse(Console.ReadLine());
            //Random rnd = new Random();
            //int[] list = new int[num];
            //for (int i = 0; i < num; i++)
            //{
            //    list[i] = rnd.Next(1, 100);
            //}
            //Desc(list);
            //Console.WriteLine();
            //Ord(list);
            //Console.WriteLine();
            //fourth(list);
            #endregion

            #region Task 2
            //Write a program in C# to create a function to swap the values of two integer numbers without additional variable.
            //Test Data : Enter a number: 5 Enter another number: 6 Expected Output : Now the 1st number is : 6 , and the 2nd number is : 5

            //Console.WriteLine("First number");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Second number");
            //int num2 = int.Parse(Console.ReadLine());
            //RefFunc(ref num1, ref num2);
            //Console.WriteLine($"now First {num1} Second {num2}");
            #endregion

            #region Task 5
            //Write a program in C# to create a function to display the n number Fibonacci sequence.
            //Test Data :
            //Input number of Fibonacci Series : 5
            //Expected Output : The Fibonacci series of 5 numbers is : 0 1 1 2 3 5 8

            //int num = int.Parse(Console.ReadLine());
            //int a = 0, b = 1, c;

            //Console.Write($"{a} "); 
            //for (int i = 1; i < num; i++)
            //{ 
            //    Console.Write($"{b} "); 
            //    c = a + b;
            //    a = b;
            //    b = c;
            //}

            #endregion

            #region Task 6
            //Write a program in C# to create a function to calculate the sum of the individual digits of a given number.
            //Test Data : Enter a number: 1234 Expected Output : The sum of the digits of the number 1234 is : 10

            //Console.WriteLine("Write number");
            //int num = int.Parse(Console.ReadLine());
            //int sum = 0;
            //foreach (var item in num.ToString()) { sum += (int)char.GetNumericValue(item); }
            //Console.WriteLine("Sum " + sum);
            #endregion

            #region Task 7
            //Write a program in C# Sharp to create a function to input a string and count number of spaces are in the string.
            //Test Data : Please input a string : This is a test string. Expected Output : "This is a test string." contains 4 spaces

            Console.WriteLine(Console.ReadLine().Split(" ").ToArray().Length);
            #endregion

        }

        static void Desc(int[] list)
        {
            foreach (var item in list.OrderByDescending(x => x).ToArray())
            {
                Console.Write(item + " ");
            };
        }
        static void Ord(int[] list)
        {
            foreach (var item in list.OrderBy(x => x).ToArray())
            {
                Console.Write(item + " ");
            };
        }
        static void fourth(int[] list)
        {
            foreach (var item in list.OrderByDescending(x => x).ToArray().Take(4).ToArray().Reverse().ToArray())
            {
                Console.Write(item + " ");
            };
        }
        static void RefFunc(ref int first, ref int second)
        {
            int sum = first + second;
            first = sum - first;
            second = sum - first;
        }
    }
}
