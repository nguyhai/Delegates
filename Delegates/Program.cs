using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        public delegate void Printer(string message);

        static void Main(string[] args)
        {
            Printer p = Print;

            p += Print;
            p += PrintTwice;
            p += Print;
            p += PrintTwice;
            p += Print;

            p("Message");

            // How do we check what is on the list of the delegate chain? Use a foreach loop

            foreach (var del in p.GetInvocationList())
            {
                Console.WriteLine(del.Method);
            }


        }

        public static void PrintTwice(string message)
        {
            Console.WriteLine(message + " 1 ");
            Console.WriteLine(message + " 1 ");

        }


        public static void Print(string message)
        {
            Console.WriteLine(message);
        }

    }
}
