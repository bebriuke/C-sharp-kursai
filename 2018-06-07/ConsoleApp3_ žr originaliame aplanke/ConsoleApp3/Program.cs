using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("labas"+ "\n" + "labas"); // \t - tabuliacija
            Console.WriteLine("50 = {0} + {1}", 20, 50); /*Įdomu*/
            //foat – skaičiai su kableliu (7 skaitmenys), pvz: 10.15f, 145.123f
            //float m;
            string m = Console.ReadLine();
            float k = float.Parse(m);
            Console.WriteLine(m + "++++");
            Console.WriteLine(k);
            Console.WriteLine("Test:" + (5 / 2));
            //ND.
            bool yra = true;
            Console.WriteLine(yra);
            sbyte tik256 = 25;
            Console.WriteLine(tik256);
            long didelis = 12345678900;
            Console.WriteLine(didelis);
            double didesnis = 1.3221587;
            Console.WriteLine(didesnis); // ar galima apvalinti?
            float d = 1.1525f;
            //spausdinimas tam tikru tikslumu;
            Console.WriteLine(string.Format("Number 2: {0:0.#}", d));
            Console.WriteLine(d.GetType());
            //ctrl+d -- dublikuoja eilutę;
            //ctrl+pelė -- kopijuoja;
            int ss = 7;
            Console.WriteLine(sizeof(float));
            Console.ReadKey();
        }
    }
}
