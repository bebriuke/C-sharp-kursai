using MinuLaukas.GameData;
using MinuLaukas.MyMeniuWindow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinuLaukas.Game
{
    class GameRender
    {
        private MyWindow Langas = new MyWindow(0, 0, 28, 110, '%', "");
        private MyGameData Zaidimas = new MyGameData();
        //private bool darZaidziam = true;

        public GameRender()
        {

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

        // Meniu

    }
}
