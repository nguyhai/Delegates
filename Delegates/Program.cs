using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        public delegate bool CheckLengthOfString(string item);

        static void Main(string[] args)
        {
            CheckLengthOfString d = LessThanFive;
            d += MoreThanFive;
            d += ExactlyFive;

            //Console.WriteLine(d("Message"));

            //List<bool> results = new List<bool>();

            //foreach (var del in d.GetInvocationList())
            //{
            //    results.Add((bool)del.DynamicInvoke("Message"));
            //}
            //Console.WriteLine(string.Join(", ", results));

            List<bool> results = d.GetInvocationList().Select(del => (bool)del.DynamicInvoke("Message")).ToList();
            Console.WriteLine(string.Join(", ", results));


        }

        public static bool LessThanFive(string name)
        {
            return name.Length < 5;
        }
        public static bool MoreThanFive(string name)
        {
            return name.Length > 5;
        }
        public static bool ExactlyFive(string name)
        {
            return name.Length == 5;
        }

    }
}
