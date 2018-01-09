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
        //static void Main()
        {
            Console.WriteLine("What number would you like to count up to?  ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Would you rather lists all numbers, even numbers, or odd numbers? ");
            string choice = Console.ReadLine();

            if (choice == "all")
            {

                for (int i = 0; i <= num; i++)
                {
                    Console.WriteLine(i);
                }
            }

            else if (choice == "even")
            {
                for (int i = 0; i <= num; i++)
                {
                    if ((i % 2) == 0)
                    {
                        Console.WriteLine(i);
                    }
                    else
                    {

                    }
                }
            }

            else if (choice == "odd")
            {
                for (int i = 0; i <= num; i++)
                {
                    if ((i % 2) != 0)
                    {
                        Console.WriteLine(i);
                    }
                    else
                    {

                    }
                }
            }

            else
            {
                Console.WriteLine("Invalid Response");
            }


        }
    }
}
