using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciklai
{
    class Program
    {
        static void Main(string[] args)
        {
            string x="";

            int ne_prie_lango = 0;
            int prie_lango = 0;
            do
            {
                if (ne_prie_lango == 4) {
                    Console.WriteLine("Ar sutinkate sėdėti prie lango? Kitų vietų jau nebėra. Parašykite \"t\" arba \"n\" ");
                }
                else
                    Console.WriteLine("Ar sutinkate sėdėti prie lango? Parašykite \"t\" arba \"n\" ");

                x = Console.ReadLine();
                if (x == "t")
                    prie_lango++;
                Console.WriteLine("Prie lango pasirinktų vietų skaičius {0}", prie_lango); // PASIŽIŪRĖK VEIKIMĄ!
            } while (prie_lango < 4);
            Console.WriteLine("Pasirinkimai baigėsi! Press any key");
            Console.ReadKey();
        }
    }
}
