using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lambdas can be used with Func and Action delegates
            // Check to see if this integer is less than 8
            // If you use more than one input, you need to use parentheses (i,j)
            Func<int, int, bool> checkIntegers = (i,j) => i < 8;

            Action printSomething = () => Console.WriteLine("Printing");

            Action<int, int> sumOfTwoNumbers = (i, j) =>
             {
                 Console.WriteLine("The i number is: " + i);
                 Console.WriteLine("The j number is: " + j);
                 Console.WriteLine("The Sum number is: " + (int)(i + j));

             };

            sumOfTwoNumbers(5, 2);
        }
    }
}
