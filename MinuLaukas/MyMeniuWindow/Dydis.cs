using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinuLaukas.MyMeniuWindow
{
    class Dydis
    {
        private MyWindow remai = new MyWindow(10, 5, 15, 70, '%', "");
        private MyWindow desimt = new MyWindow(15, 13, 5, 17, '%', "10 x 10");
        private MyWindow penkiolika = new MyWindow(35, 13, 5, 17, '%', "10 x 15");
        private MyWindow dvidesimt = new MyWindow(55, 13, 5, 17, '%', "10 x 20");
        private int pasirinkimas = 10;



        public void PrintWindow()
        {

            remai.PrintWindow('%');
            Tekstas();
            desimt.PrintWindow('@');
            penkiolika.PrintWindow('%');
            dvidesimt.PrintWindow('%');
        }

        public int Valdymas()
        {

            ConsoleKeyInfo kb = Console.ReadKey();
            while (kb.Key != ConsoleKey.Enter)
            {
                if (kb.Key == ConsoleKey.RightArrow)
                {
                    if (pasirinkimas == 10)
                    {
                        PrintPasirinkimas(penkiolika, desimt);
                        pasirinkimas = 15;
                    }
                    else if (pasirinkimas == 15)
                    {
                        PrintPasirinkimas(dvidesimt, penkiolika);
                        pasirinkimas = 20;
                    }
                }
                if (kb.Key == ConsoleKey.LeftArrow)
                {
                    if (pasirinkimas == 20)
                    {
                        PrintPasirinkimas(penkiolika, dvidesimt);
                        pasirinkimas = 15;
                    }
                    else if (pasirinkimas == 15)
                    {
                        PrintPasirinkimas(desimt, penkiolika);
                        pasirinkimas = 10;
                    }
                }

                kb = Console.ReadKey();

            }
            return pasirinkimas;

        }

        public void PrintPasirinkimas(MyWindow A, MyWindow B)
        {
            A.PrintWindow('@');
            B.PrintWindow('%');
        }

        public void Tekstas()
        {
            Console.SetCursorPosition(15, 8);
            Console.Write("Pasirink minų lauko dydį.");
            
        }

    
    }
}
