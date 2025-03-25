using System;
using System.ComponentModel;

namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //Write a C# program that takes three letters as input and display them in reverse order.
            //string content = null;
            //for (int i = 1; i < 4; i++)
            //{
            //    while (true)
            //    {
            //        Console.WriteLine($"{i} letter :");
            //        string a = Console.ReadLine();
            //        if (!string.IsNullOrEmpty(a))
            //        {
            //            content += a + " ";
            //            break;
            //        }
            //    }
            //}
            //Console.WriteLine(content);
            #endregion

            #region Task 2
            //Write a C# program that takes 2 inputs form user respectively name and surname, and then print it as "NAME SURNAME" (both uppercase) in console
            //Console.WriteLine("Name");
            //string name = Console.ReadLine();
            //Console.WriteLine("Surname");
            //string surname = Console.ReadLine();
            //string Common = name + " " + surname;
            //Console.WriteLine(Common.ToUpper());
            #endregion

            #region Task 3
            //Write a C# program that takes the radius of a circle as input and calculate the perimeter and area of the circle and print it in console
            Console.WriteLine("Write radius of circle");
            int radius = int.Parse(Console.ReadLine());
            double perimeter = 2 * Math.PI * radius;
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"Perimeter of circle is {perimeter}");
            Console.WriteLine($"Area of circle is {area}");
            #endregion


        }
    }
}
