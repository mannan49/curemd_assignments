using System;

namespace MyApp
{
    internal class Program
    {
        //Task#1: Write a program that takes two numbers as input and prints their sum.
        static void SumTwoNumbers()
        {
            try
            {
                Console.Write("Enter the first number: ");
                int firstNum = Int32.Parse(Console.ReadLine());
                Console.Write("Enter the second number: ");
                int secondNum = Int32.Parse(Console.ReadLine());

                int total = firstNum + secondNum;
                Console.WriteLine($"Sum is {total}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter integers only.");
            }
        }

        //Task#2 : Write a program that prints all even numbers from 1 to 100.
        static void PrintEven1To100()
        {
            Console.WriteLine("The even numbers from one to hundred are:");
            for (int i = 2; i <= 100; i += 2)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        //Task#3: Write a function that checks if a given year is a leap year or not.
        static void IsLeapYear()
        {
            try
            {
                Console.Write("Enter a year: ");
                int year = Int32.Parse(Console.ReadLine());
                if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                {
                    Console.WriteLine($"The year {year} is a leap year.");
                }
                else
                {
                    Console.WriteLine($"The year {year} is NOT a leap year.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid year.");
            }
        }

        //Task#4: Write a program that converts kilometers per hours to miles per hour. Hint: 1km = 0.621371
        static void KphToMph()
        {
            try
            {
                Console.Write("Enter speed in kilometers per hour: ");
                double speed = Double.Parse(Console.ReadLine());
                Console.WriteLine($"{speed} KPH is equal to {speed * 0.621371} MPH.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        //Task#5: Write a pseudocode to check whether a number is a buzz number or not.
        static void IsBuzzNumber()
        {
            try
            {
                Console.Write("Enter a number: ");
                int num = Int32.Parse(Console.ReadLine());
                if (num % 7 == 0 || num % 10 == 7)
                {
                    Console.WriteLine($"The number {num} is a Buzz Number.");
                }
                else
                {
                    Console.WriteLine($"The number {num} is NOT a Buzz Number.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        //Task#6: Write a program that prints the multiplication table of a number up to 10.
        static void PrintTable()
        {
            try
            {
                Console.Write("Enter a number: ");
                int num = Int32.Parse(Console.ReadLine());
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{num} x {i} = {num * i}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        //Task#7: Write a program that computes the factorial of a number (n!).
        static void CalcFactorial()
        {
            try
            {
                Console.Write("Enter a number: ");
                int num = Int32.Parse(Console.ReadLine());
                if (num < 0)
                {
                    Console.WriteLine("Factorial is not defined for negative numbers.");
                    return;
                }
                long factorial = 1;
                for (int i = 1; i <= num; i++)
                {
                    factorial *= i;
                }
                Console.WriteLine($"The factorial of {num} is {factorial}.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        //Task#8: Write a function that checks whether a number is prime or not.
        static void IsPrime()
        {
            try
            {
                Console.Write("Enter a number: ");
                int num = Int32.Parse(Console.ReadLine());
                bool isPrime = num > 1;
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine($"The number {num} is a PRIME number.");
                }
                else
                {
                    Console.WriteLine($"The number {num} is NOT a prime number.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        //Task#9: Write a program to check whether the triangle is equilateral, isosceles or scalene triangle.
        static void TriangleStatus()
        {
            try
            {
                Console.Write("Enter the length of the first side of the triangle: ");
                int a = Int32.Parse(Console.ReadLine());
                Console.Write("Enter the length of the second side of the triangle: ");
                int b = Int32.Parse(Console.ReadLine());
                Console.Write("Enter the length of the third side of the triangle: ");
                int c = Int32.Parse(Console.ReadLine());

                if (a == b && b == c)
                {
                    Console.WriteLine("The triangle is equilateral.");
                }
                else if (a == b || a == c || b == c)
                {
                    Console.WriteLine("The triangle is isosceles.");
                }
                else
                {
                    Console.WriteLine("The triangle is scalene.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter valid lengths.");
            }
        }

        //Task#10: Print this pattern: (using multiple prints and then by loop)
        //a: Using multiple prints
        static void PrintPattern()
        {
            Console.WriteLine("*");
            Console.WriteLine("**");
            Console.WriteLine("***");
            Console.WriteLine("****");
            Console.WriteLine("*****");
        }

        //b: Using loop
        static void PrintPatternUsingLoop()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        //Task#11: Bonus Question: Check if a number is a palindrome.
        static void IsPalindrome()
        {
            try
            {
                Console.Write("Enter a number: ");
                int num = Int32.Parse(Console.ReadLine());
                int reverse = 0;
                int original = num;

                while (num > 0)
                {
                    int remainder = num % 10;
                    reverse = (reverse * 10) + remainder;
                    num /= 10;
                }

                if (original == reverse)
                {
                    Console.WriteLine($"The number {original} is a Palindrome.");
                }
                else
                {
                    Console.WriteLine($"The number {original} is NOT a Palindrome.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Assignment Questions in C#");
            SumTwoNumbers();
            PrintEven1To100();
            IsLeapYear();
            KphToMph();
            IsBuzzNumber();
            PrintTable();
            CalcFactorial();
            IsPrime();
            TriangleStatus();
            PrintPattern();
            PrintPatternUsingLoop();
            IsPalindrome();

            // Keep the console window open
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
