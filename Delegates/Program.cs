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
        public delegate int GetLengths(string message);

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

            GetLengths g = x => x.Length;
            g += x => x.Length + 1;
            g += x => x.Length + 2;

            List<bool> results = GottaCatchEmAll<bool>(d, "Message");
            Console.WriteLine(string.Join(", ", results));

            List<int> lengths = GottaCatchEmAll<int>(g, "Message");
        }

        public static List<T> GottaCatchEmAll<T>(Delegate del, object parameter = null)
        {
            List<T> result = del.GetInvocationList().Select(d =>(T)d.DynamicInvoke(parameter)).ToList();
            return result;
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
