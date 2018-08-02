using MinuLaukas.GameData;
using MinuLaukas.MyMeniuWindow;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinuLaukas.Game
{
    class GameRender
    {
        private MyWindow Langas = new MyWindow(0, 0, 28, 110, '%', "");
        private int size;
        private MyGameData Zaidimas;
        //private bool darZaidziam = true;

        public GameRender(int dydis)
        {
            size = dydis;
            Zaidimas = new MyGameData(size);
        }

        public void PrintZaidimas()
        {
            Langas.PrintWindow('%');
            Console.SetCursorPosition(20, 3);
            Console.Write("Žaidimas prasidėjo");
             // Console.WriteLine();
            Console.SetCursorPosition(20, 6);
            Zaidimas.MinuIsdestymas();
            Zaidimas.Skaiciavimai();
            Zaidimas.PrintArray();
            //Zaidimas.PrintTuscia();
            Zaidimas.Valdymas(0, 0);
            

            Console.ReadKey();
        }

        public void PrintToFile()
        {
            Zaidimas.SaveData();
        }

        public void SkaitymasIsFailo()
        {
            

            Langas.PrintWindow('%');
            Console.SetCursorPosition(20, 3);
            Console.Write("Žaidimas prasidėjo");
            // Console.WriteLine();
            Console.SetCursorPosition(20, 6);

            Zaidimas.ReadFromFile();
            Zaidimas.PrintArray();
            //Zaidimas.PrintTuscia();
            Zaidimas.Valdymas(0, 0);


            Console.ReadKey();
        }

        // Meniu

    }
}
