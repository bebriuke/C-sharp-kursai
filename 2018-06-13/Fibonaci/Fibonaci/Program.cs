using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonaci
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 1, i;
            int kiek = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(kiek);
            for(i=0; i<kiek; i++)
            {
                Console.Write(x+" ");
                int laik = y;
                y = x + y;
                x = laik;
            }
            Console.ReadKey();
        }
    }
}
