using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skaiciuotuvas
{
    class Program
    {
        static void Main(string[] args)
        {
            char vykdom = 't';
            while (vykdom != 'n') {
                Console.WriteLine("Įvesk pirmą skaičių: ");
                double a = Convert.ToDouble(Console.ReadLine());

                //ĮSIDĖMĖTI! NAUJA!

                char operacija = '0';
                char[] array = new char[] { '+', '-', '*', '/' };
                while (!(array.Contains(operacija))) {
                    Console.WriteLine("Įvesk norimą operaciją: +, -, * arba /");
                    operacija = Console.ReadKey(true).KeyChar;
                }
                Console.WriteLine(operacija);
                //
                Console.WriteLine("Įvesk pirmą skaičių: ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.Write(a);
                Console.Write(operacija);
                Console.Write(b);

                if ((operacija == '/') && (b == 0))
                {
                    Console.WriteLine();
                    Console.WriteLine("Dalyba iš 0 negalima! ");
                    continue;
                }
                    


                double rezult = 0;
                switch (operacija) {
                    case '+':
                        rezult = a + b;
                        break;
                    case '-':
                        rezult = a - b;
                        break;
                    case '*':
                        rezult = a * b;
                        break;
                    case '/':
                        rezult = a / b;
                        break;
                 }
                Console.WriteLine("=" + rezult);
                Console.WriteLine("Norėdami baigti skaičiavimus spustelėkite ESC ");

                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                {
                    break;
                }

                //vykdom = Console.ReadKey(true).KeyChar;
                //Console.ReadKey();
            }
        }
    }
}
