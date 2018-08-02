
using MinuLaukas.Game;
using MinuLaukas.GameData;
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
            MyWinWindow Pasirinkimai = new MyWinWindow();
         
            Ekranas.PrintWindow();
            bool laik = Ekranas.Valdymas();

            Dydis DydzioPasirinkimas = new Dydis();
            DydzioPasirinkimas.PrintWindow();

            GameRender Zaidimas = new GameRender(DydzioPasirinkimas.Valdymas()); ;

            if (laik)
            {
                 Zaidimas.PrintZaidimas();
                
            }

            bool YraIrasytu = false;
            Pasirinkimai.PrintWindowBeLoad();

            GameState temp = Pasirinkimai.ValdymasBeLoad();
            while (temp != GameState.quit)
            {
                
                if (temp == GameState.start)
                {
                    DydzioPasirinkimas = new Dydis();
                    DydzioPasirinkimas.PrintWindow();
                    Zaidimas = new GameRender(DydzioPasirinkimas.Valdymas());
                    Zaidimas.PrintZaidimas();
                    if (YraIrasytu)
                    {
                        Pasirinkimai.PrintWindow();
                        temp = Pasirinkimai.Valdymas();
                    }
                    else
                    {
                        Pasirinkimai.PrintWindowBeLoad();
                        temp = Pasirinkimai.ValdymasBeLoad();
                    }
                    

                }
                if (temp == GameState.record)
                {
                    Zaidimas.PrintToFile();
                    YraIrasytu = true;
                    Pasirinkimai.PrintWindow();
                    temp = Pasirinkimai.Valdymas();

                }
                if (temp == GameState.open)
                {
                    Zaidimas.SkaitymasIsFailo();
                    Pasirinkimai.PrintWindow();
                    temp = Pasirinkimai.Valdymas();
                }
                



            }
           
            
        }
    }
}
