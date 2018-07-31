using MinuLaukas.GameData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinuLaukas.MyMeniuWindow
{
    class MyMeniu
    {
        //aktyvumas

        //didysis remelis
        
        private MyWindow Langas = new MyWindow(0, 0, 28, 110, '%', "");
        private MyWindow StartButton = new MyWindow(20, 20, 5, 17, '%', "Start");
        private MyWindow QuitButton = new MyWindow(55 + 20, 20, 5, 17, '%', "Quit");
        

        public void PrintWindow()
        {
            
            Langas.PrintWindow('%');
            Taisykles();
            StartButton.PrintWindow('%');
            QuitButton.PrintWindow('%');
        }

        public int Valdymas()
        {
            int vykdyk = 0; // 1 - vykdyk;private int vykdyk = 0; // 1 - vykdyk;
            ConsoleKeyInfo kb = Console.ReadKey();
            while (kb.Key != ConsoleKey.Enter)
            {
                if (kb.Key == ConsoleKey.LeftArrow)
                {
                    //Console.WriteLine("Left Arrow pressed");
                    StartButton.PrintWindow('@');
                    QuitButton.PrintWindow('%');
                    vykdyk = 1;
                }
                if (kb.Key == ConsoleKey.RightArrow)
                {
                    //Console.WriteLine("Right Arrow pressed");
                    QuitButton.PrintWindow('@');
                    StartButton.PrintWindow('%');
                    vykdyk = 0;
                }
               
                kb = Console.ReadKey();

            }
            return vykdyk;
            
        }

        public void Taisykles()
        {
            Console.SetCursorPosition(10, 5);
            Console.Write("Ekrane judame rodyklių klavišais.");
            Console.SetCursorPosition(10, 7);
            Console.Write("Pasirinkimas matomas paryškintu rėmeliu.");
            Console.SetCursorPosition(10, 9);
            Console.Write("Pasirinkimą patvirtiname Enter klavišo paspaudimu.");
        }







        //Statr Game
        //Quit
        //valdymas?
    }
}
