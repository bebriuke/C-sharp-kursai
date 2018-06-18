using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atspek_skaiciu
{
    class Program
    {
        static void Main(string[] args)
        {
            int tikslas, spejimas, virsus, yra;
            int nr = 1, kiek = 0;
            int[] MAS = new int[10];
            Console.WriteLine("Viršus: "); virsus = Convert.ToInt32(Console.ReadLine());
            //srand (time(NULL));
            //tikslas = rand()%virsus;            // kompas "sugalvoja" atsitiktiná skaièiø iki 10-ties imtinai
            tikslas = new Random().Next(0, virsus); ;
            Console.WriteLine(nr + " spėjimas: "); spejimas = Convert.ToInt32(Console.ReadLine());  // spëjimas ið klaviatûros
            Console.WriteLine("Spėjai " + spejimas);
            MAS[kiek] = spejimas;
            kiek++;
            while ((spejimas != tikslas) && (nr < 5))
            {

                if ((spejimas > virsus) || (spejimas < 0))
                    Console.WriteLine("Į pievas");
                else if (spejimas > tikslas)
                    Console.WriteLine(" Per daug");
                else Console.WriteLine("Per mažai");
                nr++;
                yra = 1;
                while (yra == 1)
                {
                    Console.WriteLine(nr + " spėjimas: "); spejimas = Convert.ToInt32(Console.ReadLine());
                    yra = 0;

                    for (int i = 0; i < kiek; i++)
                    {
                        if (MAS[i] == spejimas)
                        {
                            yra = 1;
                        }
                    }

                    if (yra == 1) Console.WriteLine("Šitą skaičių " + spejimas + " jau spėjai ");
                    else
                    {
                        MAS[kiek] = spejimas;
                        kiek++;
                    }


                }



            }

            if ((nr <= 5) && (spejimas == tikslas)) Console.WriteLine("atspėjai!");
            else Console.WriteLine("Spėjimai baigėsi. Teisingas atsakymas buvo " + tikslas);

            Console.WriteLine(" Mažesni už tikslą spėjimai buvo: ");
            for (int i = 0; i < kiek; i++)
                if (MAS[i] < tikslas) Console.Write(MAS[i] + "  ");

            Console.ReadKey();
        }
    }
}
