using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masyvai
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = new[] { "Mano", "batai", "buvo", "Mano", "batai", "buvo", "du", "buvo", "du", "." };
            keisti(data);
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write(data[i] + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] != "!") Console.Write(data[i] + " ");
            }
            Console.WriteLine();

            DarVienasKeitimas(data);

            for (int i = 0; i < data.Length; i++)
            {
                Console.Write(data[i] + " ");
            }
            Console.WriteLine();
            

            int[] skaiciai = new[] { 1, 2, 3, 4, 5};
            foreach (int elem in skaiciai)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();
            int[] saugojamas = skaiciai.Clone() as int[];

            gadina(skaiciai);
            foreach (int elem in skaiciai)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();

            for (int i = (skaiciai.Length-1); i >= 0 ; i--)
            {
                Console.Write(saugojamas[i] + " ");
            }

            Console.WriteLine();

            Console.ReadKey();
        }

        static void keisti (string [] data)
        {
            int temp = data.Length;
            for (int i = 0; i < temp-1; i++)
            {
                for (int j = i + 1; j < temp; j++)
                    if ((data[j] == data[i]) && (data[j] != "!"))
                        data[j] = "!";
            }
        }

        static void DarVienasKeitimas(string[] data)
        {
            int temp = data.Length;
            for (int i = 0; i < temp; i++)
            {
                if (data[i] == "!")
                {
                    int j = i;
                    while ((data[j] == "!") && (j < temp-1))
                        j++;
                    string laik = data[i];
                    data[i] = data[j];
                    data[j] = laik;
                }

            }
        }


        static void gadina(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = -1;
            }
        }
    }
}
