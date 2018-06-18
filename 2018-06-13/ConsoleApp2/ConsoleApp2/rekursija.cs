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
            int y = 0;
            rasyk(123456, ref y);
            Console.WriteLine(y+"+++");
            Console.ReadKey();
        }

        static void rasyk (int x, ref int y)
        {
            Console.WriteLine(x+" "+y);
            int psk = x % 10;
            
            if (x > 10) rasyk(x / 10, ref y);
            //y = y * 10 + y;
            y = y * 10 + psk;
        }
    }
}
