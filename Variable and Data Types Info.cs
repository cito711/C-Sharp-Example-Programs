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
            // Integer values up to 2,147,483,647
            int maxInt = int.MaxValue;
            // Long values up to 9,223,372,036,854,775,807 
            long maxLong = long.MaxValue;
            // Decimal values up to 79,228,162,514,264,337,593,543,950,335
            // BigInteger could be used for larger values
            decimal maxDec = decimal.MaxValue;
            // Float is a 32 bit number with maxValue of 3.402823E+38 with 7 decimals
            float maxFloat = float.MaxValue;
            // Double is a 32 bit number with a maxValue of 1.797693134E+308 with 15 decimals
            double maxDouble = double.MaxValue;
            // Boolean variable for true or false values
            bool flag = true;
            // Character data type for a single character
            char grade = 'A';
            // String is used for multiple characters
            string name = "John";
            // Using var will automatically determine the variable data type
            // After initialized the data type cannot be changed
            var lastName = "Doe";

            // The type code can be retrieved from var type 
            Console.WriteLine("The variable lastName is a {0}", lastName.GetTypeCode());

            Console.WriteLine("The value of flag is {0} while the maximum integer value is {1}", flag, maxInt);

            Console.WriteLine("My name is " + name + " {0}", lastName);


            


        }
    }
}
