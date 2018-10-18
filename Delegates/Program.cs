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
            string[] names = { "Alice", "John", "Bobby", "Kyle", "Scott", "Tod", "Sharon", "Armin", "George" };

            // Filtering with anonymous method

            // Created this delegate that stores our anon method. This delegate takes in an array and another delegate as the paramenters
            Func<string[], Func<string, bool>, List<string>> extractStrings = (array, filter) =>
            {
                List<string> result = new List<string>();

                foreach (var item in array) // Takes in array
                {
                    if (filter(item)) // The condition is a delegate
                    {
                        result.Add(item);
                    }
                }
                // Returns list of strings
                return result;
            };

            Func<string, bool> lessThanFive = x => x.Length < 5;

            List<string> namesLessThanFiveChars = extractStrings(names, lessThanFive); // Takes in names array, lessThanFive method, creates a list of chars with less than 5 char

            Console.WriteLine(string.Join(",", namesLessThanFiveChars)); // Print it out



        }
    }
}
