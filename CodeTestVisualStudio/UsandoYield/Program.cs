using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsandoYield
{
    class Program
    {
        public static IEnumerable<int> TestEnum()
        {
            for (var i = 0; i < 4; i++)
            {
                Console.Write("yield ");
                yield return i;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Entera con yield: ");
            foreach (var i in TestEnum())
            {
                Console.WriteLine("{0} ", i);
            }

            Console.WriteLine("\nHasta 2 completa: ");
            var lFullList = TestEnum().ToArray();
            foreach (var i in lFullList)
            {
                Console.Write("{0} ", i);
                if (i == 2) break;
            }

            Console.WriteLine("\nHasta 2 con yield: ");
            foreach (var i in TestEnum())
            {
                Console.Write("{0} ", i);
                if (i == 2) break;
            }

            Console.ReadKey();
        }
    }
}