using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Input an integer: ");
                int integer = 0;
                try
                {
                    integer = Int32.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }

                Console.Write("Input a string: ");
                string string1 = Console.ReadLine();

                if (Compare<int, string>(integer, string1))
                    Console.WriteLine("The integer and the string are equal");
                else
                    Console.WriteLine("The integer and the string are NOT equal");

                Console.WriteLine();

            }
        }

        static bool Compare<I, X>(I i, X x)
        {
            return i.ToString() == x.ToString() ? true : false;
        }



    }
}
