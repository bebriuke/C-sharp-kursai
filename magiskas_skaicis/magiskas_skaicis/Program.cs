using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magiskas_skaicis
{
    class Program
    {
        static void Main(string[] args)
        {
           /* if(args.Length > 0)
            {
                string fileName = args[0];
                // Console.WriteLine(fileName); ?? Čia kad nelūžtų
            }
            Console.ReadKey();*/

            int sk = 0;
            for(sk = 100000; sk <= 999998; sk++)
            {

                int d4 = kiek(sk*4);
                int d5 = kiek(sk*5);
                int d6 = kiek(sk*6);

                int[] MAS = new int[6];
                int[] MAS4 = new int[6] { 0, 0, 0, 0, 0, 0};
                int[] MAS5 = new int[6] { 0, 0, 0, 0, 0, 0 };
                int[] MAS6 = new int[6] { 0, 0, 0, 0, 0, 0 };

                Versk(sk, MAS);

                if ((d4 == 6) && (d5 == 6) && (d6 == 6) && (Skirtingi(MAS)))
                {
                    
                    Versk(sk * 4, MAS4);
                    Versk(sk * 5, MAS5);
                    Versk(sk * 6, MAS6);
                    if (Vienodi(MAS, MAS4) && Vienodi(MAS, MAS5) && Vienodi(MAS, MAS6))
                    {
                        Console.WriteLine(sk);
                        Console.WriteLine(sk * 4);
                        Console.WriteLine(sk * 5);
                        Console.WriteLine(sk * 6);
                        Console.WriteLine("***********");
                    }
                }

            }

            
            
            


            Console.ReadKey();
        }

        //galima turėti neribotą skaičių parametrų funkcijos gale
        // params object[] KintamojoVardas;

        static int kiek(int laik)
        {
            int d = 0;
            while (laik > 0)
            {
                laik /= 10;
                d++;
            }
            return d;
        }


    static void Versk (int sk, int[] MAS)
        {
            int i = 0;
            int[] laik = new int[11];

            while (sk > 0)
            {
                laik[i] = sk % 10;
                sk = sk / 10;
                i++;
            }

            for (int j = 0; j < i; j++)
            {
                MAS[j] = laik[i - (1 + j)];  
            }
            
        }

        static bool Skirtingi(int[] MAS)
        {
            bool rez = true;
            int ilg = MAS.Length;
            for (int i = 0; i < ilg-1; i++)
            {
                for (int j = i + 1; j < ilg; j++)
                    if (MAS[i] == MAS[j]) return false;
            }
            return rez;
        }


        static bool Vienodi(int[] MAS1, int [] MAS2)
        {
            
            int ilg = MAS1.Length;
            Array.Sort(MAS1);
            Array.Sort(MAS2);
            for (int i = 0; i < ilg; i++) {
                if (MAS1[i] != MAS2[i]) return false;
            }
            return true;
        }
    }
}
