using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinuLaukas.MyMeniuWindow
{
    public enum GameState { start, open, record, quit }
    class MyWinWindow
    {
        

        private MyWindow Langas = new MyWindow(0, 0, 28, 110, '%', "");
        private MyWindow StartButton = new MyWindow(8, 20, 5, 17, '%', "Start New");
        private MyWindow StartSavedButton = new MyWindow(13 + 20, 20, 5, 17, '%', "Open Saved");
        private MyWindow RecordButton = new MyWindow(43 + 20, 20, 5, 17, '%', "Record");
        private MyWindow QuitButton = new MyWindow(68 + 20, 20, 5, 17, '%', "Quit");
        private GameState pasirinkimas = GameState.start;
        

        public void PrintWindow()
        {

            Langas.PrintWindow('%');
            Tekstas();
            StartButton.PrintWindow('@');
            StartSavedButton.PrintWindow('%');
            RecordButton.PrintWindow('%');
            QuitButton.PrintWindow('%');
            

        }

        public void PrintWindowBeRecord()
        {

            Langas.PrintWindow('%');
            Tekstas();
            StartButton.PrintWindow('@');
            StartSavedButton.PrintWindow('%');
            //RecordButton.PrintWindow('%');
            QuitButton.PrintWindow('%');


        }

        public void PrintWindowBeLoad()
        {

            Langas.PrintWindow('%');
            Tekstas();
            StartButton.PrintWindow('@');
            //StartSavedButton.PrintWindow('%');
            RecordButton.PrintWindow('%');
            QuitButton.PrintWindow('%');


        }

        public GameState Valdymas()
        {
            pasirinkimas = GameState.start;
            ConsoleKeyInfo kb = Console.ReadKey();
            while (kb.Key != ConsoleKey.Enter)
            {
                if (kb.Key == ConsoleKey.RightArrow)
                {
                    if (pasirinkimas == GameState.start)
                    {
                        PrintPasirinkimas(StartSavedButton, StartButton);
                        pasirinkimas = GameState.open;
                    }
                    else if (pasirinkimas == GameState.open)
                    {
                        PrintPasirinkimas(RecordButton, StartSavedButton);
                        pasirinkimas = GameState.record;
                    }
                    else if (pasirinkimas == GameState.record)
                    {
                        PrintPasirinkimas(QuitButton, RecordButton);
                        pasirinkimas = GameState.quit;
                    }
                    

                }
                if (kb.Key == ConsoleKey.LeftArrow)
                {
                    if (pasirinkimas == GameState.quit)
                    {
                        PrintPasirinkimas(RecordButton, QuitButton);
                        pasirinkimas = GameState.record;
                    }
                    else if (pasirinkimas == GameState.record)
                    {
                        PrintPasirinkimas(StartSavedButton, RecordButton);
                        pasirinkimas = GameState.open;
                    }
                    else if (pasirinkimas == GameState.open)
                    {
                        PrintPasirinkimas(StartButton, StartSavedButton);
                        pasirinkimas = GameState.start;
                    }
                }

                kb = Console.ReadKey();

            }
            return pasirinkimas;

        }


        public GameState ValdymasBeRecord()
        {
            pasirinkimas = GameState.start;
            ConsoleKeyInfo kb = Console.ReadKey();
            while (kb.Key != ConsoleKey.Enter)
            {
                
                if (kb.Key == ConsoleKey.RightArrow)
                {
                    if (pasirinkimas == GameState.start)
                    {
                        PrintPasirinkimas(StartSavedButton, StartButton);
                        pasirinkimas = GameState.open;
                    }
                    
                    else if (pasirinkimas == GameState.open)
                    {
                        PrintPasirinkimas(QuitButton, StartSavedButton);
                        pasirinkimas = GameState.quit;
                    }


                }
                if (kb.Key == ConsoleKey.LeftArrow)
                {
                    if (pasirinkimas == GameState.quit)
                    {
                        PrintPasirinkimas(StartSavedButton, QuitButton);
                        pasirinkimas = GameState.open;
                    }
                    else if (pasirinkimas == GameState.open)
                    {
                        PrintPasirinkimas(StartButton, StartSavedButton);
                        pasirinkimas = GameState.start;
                    }
                }

                kb = Console.ReadKey();

            }
            return pasirinkimas;

        }

        public GameState ValdymasBeLoad()
        {
            pasirinkimas = GameState.start;
            ConsoleKeyInfo kb = Console.ReadKey();
            while (kb.Key != ConsoleKey.Enter)
            {
                if (kb.Key == ConsoleKey.RightArrow)
                {
                    if (pasirinkimas == GameState.start)
                    {
                        PrintPasirinkimas(RecordButton, StartButton);
                        pasirinkimas = GameState.record;
                    }
                    
                    else if (pasirinkimas == GameState.record)
                    {
                        PrintPasirinkimas(QuitButton, RecordButton);
                        pasirinkimas = GameState.quit;
                    }


                }
                if (kb.Key == ConsoleKey.LeftArrow)
                {
                    if (pasirinkimas == GameState.quit)
                    {
                        PrintPasirinkimas(RecordButton, QuitButton);
                        pasirinkimas = GameState.record;
                    }
                    
                    else if (pasirinkimas == GameState.record)
                    {
                        PrintPasirinkimas(StartButton, RecordButton);
                        pasirinkimas = GameState.start;
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
            Console.SetCursorPosition(10, 5);
            Console.Write("Ekrane judame rodyklių klavišais.");
            Console.SetCursorPosition(10, 7);
            Console.Write("Pasirinkimas matomas paryškintu rėmeliu.");
            Console.SetCursorPosition(10, 9);
            Console.Write("Pasirinkimą patvirtiname Enter klavišo paspaudimu.");
        }
    }
}
