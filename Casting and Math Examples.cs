using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Casting converts one data type to another, in this case double to int
            double pi = 3.14;
            int intPi = (int)pi;

            double num1 = 10.2;
            double num2 = 8.5;

            Random rand = new Random();
            

            Console.WriteLine("The double value of pi is {0} and the integer value of pi is {1}", pi, intPi);

            Console.WriteLine("\nMath.Abs(num1) " + (Math.Abs(num1)));
            Console.WriteLine("Math.Ceiling(num1) " + (Math.Ceiling(num1)));
            Console.WriteLine("Math.Floor(num1) " + (Math.Floor(num1)));
            Console.WriteLine("Math.Max(num1, num2) " + (Math.Max(num1, num2)));
            Console.WriteLine("Math.Min(num1, num2) " + (Math.Min(num1, num2)));
            Console.WriteLine("Math.Pow(num1, 2) " + (Math.Pow(num1, 2)));
            Console.WriteLine("Math.Round(num1) " + (Math.Round(num1)));
            Console.WriteLine("Math.Sqrt(num1) " + (Math.Sqrt(num1)));

            Console.WriteLine("\nRandom Number between 1 and 100: " + (rand.Next(1, 101)));

            //Arithmetic Examples
            Console.WriteLine("7 + 2 = " + (7 + 2));
            Console.WriteLine("7 - 2 = " + (7 - 2));
            Console.WriteLine("7 * 2 = " + (7 * 2));
            Console.WriteLine("7 / 2 = " + (7 / 2));
            Console.WriteLine("7.2 % 2 = " + (7.2 % 2));

            int i = 0;

            Console.WriteLine("i++ = " + (i++));
            Console.WriteLine("++i = " + (++i));
            Console.WriteLine("i-- = " + (i--));
            Console.WriteLine("--i = " + (--i));

            Console.WriteLine("i += 5 " + (i += 5));
            Console.WriteLine("i -= 5 " + (i -= 5));
            Console.WriteLine("i *= 5 " + (i *= 5));
            Console.WriteLine("i /= 5 " + (i /= 5));
            Console.WriteLine("i %= 5 " + (i %= 5));



        }
    }
}
