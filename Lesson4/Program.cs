using System;
using System.ComponentModel;

namespace Lesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //Write a C# that calculates the day of week (ex: Monday) of your birthday
            DateTime birthday = new DateTime(1997, 4, 5);
            Console.WriteLine(
                $"My birthday is on {birthday.DayOfWeek} and it is on {birthday.Day} of {birthday.ToString("MMMM")} {birthday.Year}");
            #endregion

            #region Task 2
            //Write a C# that calculates you current life days (how many days past since your birth)
            DateTime today = DateTime.Now;
            TimeSpan lifeSpan = today - birthday;
            Console.WriteLine($"I have lived {lifeSpan.Days} days");
            #endregion

            #region Task 3
            //Write a C# program to calculate what day of the week is after 40 days from this moment
            DateTime after40Days = today.AddDays(40);
            Console.WriteLine($"After 40 days, it will be {after40Days.DayOfWeek}");
            #endregion

            #region Task 4
            //Write a program in C# to check whether the given year, month and day are the current or not. Test Data :
            //Input the Day: 17
            //Input the Month: 09
            //Input the Year: 2016
            //Expected Output :
            //The formatted Date is : 17 / 09 / 2016 The current date status : True
           
            Console.WriteLine("Input the Day: ");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the Month: ");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the Year: ");
            int year = int.Parse(Console.ReadLine());
            DateTime inputDate = new DateTime(year, month, day);
            Console.WriteLine($"The formatted Date is : {inputDate.ToString("dd/MM/yyyy")}");
            #endregion

            #region Task 5
            //Write a program in C# to get the day of week from last day of the current year against a given date.
            //Test Data:
            //Input the Day : 12
            //Input the Month : 12
            //Input the Year : 2012
            //Expected Output :
            //The formatted Date is : 12/12/2012
            //The Last day of the year 2012 is : 31/12/2012
            //The day of the week on the last date of the year 2012 is : Monday

            Console.WriteLine("Input the Day: ");
            day = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the Month: ");
            month = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the Year: ");
            year = int.Parse(Console.ReadLine());
            inputDate = new DateTime(year, month, day);
            Console.WriteLine($"The formatted Date is : {inputDate.ToString("dd/MM/yyyy")}");
            DateTime lastDayOfYear = new DateTime(year, 12, 31);
            Console.WriteLine($"The Last day of the year {year} is : {lastDayOfYear.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"The day of the week on the last date of the year {year} is : {lastDayOfYear.DayOfWeek}");
            #endregion

            #region Task 6
            //Write a program in C# Sharp to find the last day of a week against a given date.
            //Test Data:
            //Input the Day : 16
            //Input the Month : 06
            //Input the Year : 2016
            //Expected Output :
            //The formatted Date is : 16/06/2016 The last day of the week for the above date is: 18/06/2016

            Console.WriteLine("Input the Day: ");
            day = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the Month: ");
            month = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the Year: ");
            year = int.Parse(Console.ReadLine());
            inputDate = new DateTime(year, month, day);
            Console.WriteLine($"The formatted Date is : {inputDate.ToString("dd/MM/yyyy")}");
            DateTime lastDayOfWeek = inputDate.AddDays(6 - (int)inputDate.DayOfWeek);
            Console.WriteLine($"The last day of the week for the above date is: {lastDayOfWeek.ToString("dd/MM/yyyy")}");
            #endregion

            #region Task 7
            //Write a C# Sharp program to find the largest of three numbers.
            //Test Data :
            //Input the 1st number :25
            //Input the 2nd number :63
            //Input the 3rd number :10
            //Expected Output :
            //The 2nd Number is the greatest among three

            Console.WriteLine("Input the 1st number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the 2nd number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the 3rd number: ");
            int num3 = int.Parse(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("The 1st Number is the greatest among three");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("The 2nd Number is the greatest among three");
            }
            else
            {
                Console.WriteLine("The 3rd Number is the greatest among three");
            }
            #endregion

            #region Task 8
            //Write a program in C# Sharp to read any day number in integer and display day name in the word.
            //Test Data : 4
            //Expected Output : Thursday

            Console.WriteLine("Input the day number: ");
            int dayNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(((DayOfWeek)dayNumber).ToString());
            #endregion

            #region Task 9
            //Write a program in C# Sharp which is a Menu-Driven Program to perform a simple calculation. Test Date and Expected
            //Output
            //Enter the first Integer :10
            //Enter the second Integer :2
            //Here are the options : 1-Addition. 2-Substraction. 3-Multiplication. 4-Division. 5-Exit.
            //Input your choice :3 The Multiplication of 10 and 2 is: 20
            //Do you want to continue (y/n) :y

            Console.WriteLine(
                "Enter the first Integer :");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(
                "Enter the second Integer :");
            int secondNumber = int.Parse(Console.ReadLine());
            string choice = "y";
            while (choice == "y")
            {
                Console.WriteLine("Here are the options : 1-Addition. 2-Substraction. 3-Multiplication. 4-Division. 5-Exit.");
                Console.WriteLine("Input your choice :");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine($"The Addition of {firstNumber} and {secondNumber} is: {firstNumber + secondNumber}");
                        break;
                    case 2:
                        Console.WriteLine($"The Substraction of {firstNumber} and {secondNumber} is: {firstNumber - secondNumber}");
                        break;
                    case 3:
                        Console.WriteLine($"The Multiplication of {firstNumber} and {secondNumber} is: {firstNumber * secondNumber}");
                        break;
                    case 4:
                        Console.WriteLine($"The Division of {firstNumber} and {secondNumber} is: {firstNumber / secondNumber}");
                        break;
                    case 5:
                        return;
                }
                Console.WriteLine("Do you want to continue (y/n) :");
                choice = Console.ReadLine();
            }
            #endregion

        }
    }
}
