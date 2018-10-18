using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        public delegate bool Filters(string item);
        public delegate bool Test(string item);

        static void Main(string[] args)

        {
            string[] names = { "Alice", "John", "Bobby", "Kyle", "Scott", "Tod", "Sharon", "Armin", "George" };

            List<string> lessThanFiveChars = NamesFilter(names, item => item.Length == 5); // We dont need method, we can just use a lambda expression here!

            Console.WriteLine(string.Join(", ", lessThanFiveChars));
        }

        // Now we have three different methods with three different conditions. Delegate should allow us to store these variables and pass them around.


        public static List<string> NamesFilter(string[] names, Filters filter)
        {
            List<string> result = new List<string>();

            foreach (var name in names)
            {
                // We need a string for the input, and we return a boolean, whether it is true or false that the length is less than 5
                if (filter(name))
                {
                    result.Add(name);
                }
            }
            return result;
        }
    }
}
