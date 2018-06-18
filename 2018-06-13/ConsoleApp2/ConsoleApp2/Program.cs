using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int kartai = 0;
            rasyk("Labas", kartai);
            Console.ReadKey();
        }

        static void rasyk (string x, int kartai)
        {
            Console.WriteLine(x);
            kartai++;
            if (kartai < 5)
                rasyk(x, kartai);
            Console.WriteLine("Viso!");
        }
    }
}
