using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kintamuju_aprasai
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c = 3;
            a = 5;
            b = 4;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            var id = 10;  // var - tinginių tipas, kompiliatoriai išsiaiškink;
            Console.WriteLine(id);

            const float PI = 3.1425f;  //negalim keisti reikšmės
            Console.WriteLine(id*PI);

            Console.WriteLine(int.MinValue);
            Console.WriteLine(long.MaxValue);

            Console.ReadKey();
        }
    }
}
