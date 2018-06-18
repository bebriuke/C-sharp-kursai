using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salyga_ciklai_debuginimas
{
    class Program
    {
        static double Sinc(double x)
        {
            return x != 0.0 ? Math.Sin(x) / x : 1.0;
        }

        static void Main(string[] args)
        {
            /*for(int i=0; i<10; i++)
            {

                Console.WriteLine(i);
                Console.ReadKey();
            }*/
            //
            /*
                const double PI = 3.14;
                Console.WriteLine("Įvesk apskritimos spindulį: ");
                int r = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Lanko ilgis: " + 2 * PI * r);
                Console.WriteLine("Apskritimo plotas: " + PI * r*r);
                Console.ReadKey();

                        //
                Console.WriteLine("Įvesk atstumą metrais: ");
                double m = Convert.ToDouble (Console.ReadLine());
                Console.WriteLine("Įvesk laiką sekundėmis: ");
                double s = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Gretis km/h: " + (m /1000)/(s/(60*60)));
                Console.ReadKey();
            */
            //
            /*
                int a = 4;
                int b = a++; // gražina reikšmę, tada padidina. b = a; a++
                int c = ++a; // padidina reikšmę, tada gražina. a++; c = a
                Console.WriteLine("b="+b);
                Console.WriteLine("c="+c);
                Console.WriteLine("a=" + a);
                Console.ReadKey();
            */
            
                        Console.WriteLine("Įvesk savo amžių: ");
                        int amzius = Convert.ToInt32(Console.ReadLine());
                        if (amzius >= 18) Console.WriteLine("Pilnametis");
                        else Console.WriteLine("nepilnametis");
                        Console.ReadKey();
            
            /*
                Console.WriteLine("Įvesk skaičių: ");
                int sk = Convert.ToInt32(Console.ReadLine());
                double skd = Convert.ToDouble(sk);
                int rez = sk / 2;
                double rezd = skd / 2;
                if (sk % 2 == 0) Console.WriteLine("Lyginis: "+ sk+"/"+2+"="+rez);
                else Console.WriteLine("Nelyginis: "+ sk+"/"+2+"="+rezd);
                Console.ReadKey();
    */
           /* 
                    Console.WriteLine("Įvesk pažymį: ");
                    int paz = Convert.ToInt32(Console.ReadLine());

                    if (paz == 10) Console.WriteLine("Puiku");
                    else if ((paz >= 8) & (paz < 10)) Console.WriteLine("Labai gerai");
                         else if ((paz >= 6) & (paz < 8)) Console.WriteLine("Gerai");
                              else if (paz == 5) Console.WriteLine("Visutiniškai");
                                   else if (paz == 4) Console.WriteLine("Bent teigiamas");
                                        else if((paz > 0) & (paz < 4)) Console.WriteLine("Labai blogai");
                                             else Console.WriteLine("Klaida");
                    Console.ReadKey();
*/
        
            /*
                Console.WriteLine(true ^ true); //tiesa bus kai bus skirtingi (kalbam apie 2 duomenis)
                Console.WriteLine(true ^ false);
                Console.WriteLine(false ^ true);
                Console.WriteLine(false ^ false);
                Console.ReadKey();
    */

           
            Console.WriteLine(Sinc(1.25));
            Console.ReadKey();


            // faina!!!
            Console.WriteLine("Tu esi " + ((amzius <= 18) ? "ne" : "") + "pilnametis!");
            Console.ReadKey();


        }
    }
}
