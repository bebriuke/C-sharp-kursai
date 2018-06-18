using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grandinele
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, salyga;
            string[] inputArray = {"bef", "bec", "bdc", "bcc", "bbc", "abc"};

            string[] tinkami = { "bef", "bec", "bdc", "bcc", "bbc", "abc"};
            string[] naujas = new string[5];
            string[] surikiuotas = new string[5];
            /*  naujas = surink("bbc", inputArray);
              for (int i = 0; i < naujas.Length; i++)
                  Console.WriteLine(naujas[i]);*/

            /*
                        string[] arr = { " ", "a", "b", " ", "c", " ", "d", " ", "e", "f", " ", " " };
                        arr = arr.Where(s => s != " ").ToArray();
                        for (int i = 0; i < arr.Length; i++)
                            Console.WriteLine(arr[i]); 
            */
             salyga = tinkami.Length;
             rekursija(ref a, surikiuotas, inputArray, tinkami, salyga);

             for (int i = 0; i < naujas.Length; i++)
                 Console.WriteLine(surikiuotas[i]);

             Console.ReadKey();
        }


        static int skirtumas(string a, string b)
        {
            int ilg = a.Length;
            int kiek = 0;
            for (int i = 0; i < ilg; i++)
            {
                if (a[i] != b[i])
                {
                    kiek++;
                }

            }
            return kiek;
        }

        static string[] surink(string a, string[] inputArray)
        {
            int j = 0;
            int n = inputArray.Length;
            int kiek = 0;
            
            //naujas[0] = a;

            for (int i = 0; i < n; i++)
            {
                if (skirtumas(a, inputArray[i]) == 1)  kiek++;
                
            }

            string[] naujas = new string[kiek];
            for (int i = 0; i < n; i++)
            {
                //Console.Write(skirtumas(a, inputArray[i]));
                //Console.WriteLine(" "+a+" "+ inputArray[i]);
                if (skirtumas(a, inputArray[i]) == 1)
                {
                    naujas[j] = inputArray[i];
                    //Console.WriteLine("*");
                    j++;
                }
            }
            return naujas;
        }



        static void rekursija(ref int a, string[] surikiuotas, string[] inputArray, string[] tinkami, int salyga)
        {
            Console.WriteLine(tinkami.Length+" grįžimo sąlyga");
            string[] SenasInputArray = new string[inputArray.Length];
            for (int i = 0; i < inputArray.Length; i++)
                SenasInputArray[i] = inputArray[i];
            string[] SenasTinkami = new string[tinkami.Length];
            

            if (salyga >= 1)
            {
                Console.WriteLine("");
                for (int i = 0; i < inputArray.Length; i++)
                    Console.Write(inputArray[i]+" ");
                Console.WriteLine(" ");
                
                Console.WriteLine("nr. "+a);
                Console.WriteLine("surikiuotas "+ a+" "+ tinkami[0]);
                surikiuotas[a] = tinkami[0];

                //for (int i = 0; i < surikiuotas.Length; i++)
                //Console.Write(surikiuotas[i] + " ");
                //Console.WriteLine(" ");
                // Array.IndexOf(inputArray, tinkami[0]);
                Console.WriteLine(tinkami[0] + " bla bla bla " + tinkami.Length);
                if (tinkami.Length == 1)
                {
                    rekursija(ref a, surikiuotas, inputArray, tinkami, 0);
                }
                inputArray.Where(s => s != tinkami[0]).ToArray();
                // tinkami.RemoveAt(0, 1);
                SenasTinkami = tinkami.Where(s => s != tinkami[0]).ToArray();
                
                string zodis = tinkami[0];
                Console.Write (zodis + " žodis   ");
                
                tinkami = surink(zodis, inputArray);
                for (int i = 0; i < tinkami.Length; i++)
                    Console.Write(tinkami[i] + ",  ");
                Console.WriteLine("^^^");

                a++;
                Console.WriteLine(tinkami.Length + " grįžimo sąlyga222222");
                salyga = tinkami.Length;
                rekursija(ref a, surikiuotas, inputArray, tinkami, salyga);
            }
            /*else
            {
                a = a - 1;
                if (a > 0)
                {
                    //įdėti abc į SenasInputArray galą;
                    salyga = tinkami.Length;
                    rekursija(ref a, surikiuotas, SenasInputArray, SenasTinkami, salyga);
                }

            }*/



        }



        static bool stringsRearrangement(string[] inputArray)
        {
            int a = 0;
            int ilg = inputArray.Length;
            string[] tinkami = new string[ilg];
            for (int i = 0; i < ilg; i++)
                tinkami[i] = inputArray[i];
            string[] surikiuotas = new string[ilg];
            int salyga = tinkami.Length;
            rekursija(ref a, surikiuotas, inputArray, tinkami, salyga);
            return true;
        }
    }
}
