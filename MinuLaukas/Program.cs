
using MinuLaukas.Game;
using MinuLaukas.MyMeniuWindow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinuLaukas
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            MyMeniu Ekranas = new MyMeniu ();

            Ekranas.PrintWindow();

            GameRender Zaidimas = new GameRender();
            bool zaisti = Ekranas.Valdymas();
            if (zaisti)
            {
                Zaidimas.PrintZaidimas();
            }

           
           // Console.ReadKey();
        }
    }
}
