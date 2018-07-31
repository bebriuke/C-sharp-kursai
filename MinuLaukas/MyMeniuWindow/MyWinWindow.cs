using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinuLaukas.MyMeniuWindow
{
    class MyWinWindow
    {
        private MyWindow Langas = new MyWindow(0, 0, 28, 110, '%', "");
        private MyWindow StartButton = new MyWindow(20, 20, 5, 17, '%', "Start New");
        private MyWindow StartSavedButton = new MyWindow(25 + 20, 20, 5, 17, '%', "Open Sved");
        private MyWindow RecordButton = new MyWindow(55 + 20, 20, 5, 17, '%', "Record");
        private MyWindow QuitButton = new MyWindow(80 + 20, 20, 5, 17, '%', "Quit");
        

        public void PrintWindow()
        {

            Langas.PrintWindow('%');
            Tekstas();
            StartButton.PrintWindow('%');
            StartSavedButton.PrintWindow('%');
            RecordButton.PrintWindow('%');
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

        public void Tekstas()
        {
            Console.SetCursorPosition(10, 7);
            Console.Write("tekstas");
        }
    }
}
