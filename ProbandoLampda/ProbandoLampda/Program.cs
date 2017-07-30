using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbandoLampda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> data = new List<string> { 
                "Michel",
                "Roberto",
                "Traña",
                "Tablada"
            };

            data.ForEach(c =>
            {
                var prefijo = "Sorpresa: ";
                prefijo += c;

                Console.WriteLine(prefijo);
            });

            Console.ReadKey();
        }
    }
}
