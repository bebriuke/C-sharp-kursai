using MinuLaukas.MyMeniuWindow;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinuLaukas.GameData
{
    class MyGameData
    {
        private static int size = 10; //kvadrato krastines ilgis
        private CellData[,] MineSweeper;
        private int kiekis;


        public MyGameData()
        {
            MineSweeper = new CellData[size, size];
            kiekis = size * size;
        }

        public void MinuIsdestymas()
        {
            int minuSkaicius;
            //Sudedam minas į lenelę
            Random random = new Random();
            
            minuSkaicius = Convert.ToInt32(0.3 * kiekis);
            int temp = 0;
            int x;
            int[] minos = new int[minuSkaicius];
            while (temp < minuSkaicius)
            {
                x = random.Next(0, kiekis);
                if (!minos.Contains(x))
                {
                    minos[temp] = x;
                    //Console.WriteLine(x);
                    int i = x / 10;
                    int j = x % 10;
                    MineSweeper[i, j].value = CellState.mina;
                    MineSweeper[i, j].number = '#';
                    temp++;

                }
            }
        }


        private int[,] sk = new int[size, size];
        public CellData[,] Skaiciavimai()
        {
            int temp;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (MineSweeper[i, j].value != CellState.mina)
                    {
                        temp = MinuSkaicius(MineSweeper, i, j, size, size);
                        if (temp == 0)
                        {
                            MineSweeper[i, j].value = CellState.tuscia;  //skaicius arba tuscia
                            MineSweeper[i, j].number = KonvertuokChar(temp);
                        }
                        else if (temp > 0)
                        {
                            MineSweeper[i, j].value = CellState.skaicius;
                            MineSweeper[i, j].number = KonvertuokChar(temp);
                            
                        }
                    }
                }
            }
            return MineSweeper;
        }

        public char KonvertuokChar(int x)
        {
            char[] a = new char[] { 'O', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            return a[x];
        }



        static int MinuSkaicius(CellData[,] array, int i, int j, int n, int m)
        {
            int kiek = 0;
            for (int a = i - 1; a <= i + 1; a++)
            {
                for (int b = j - 1; b <= j + 1; b++)
                {
                    if ((a >= 0) && (b >= 0) && (a < m) && (b < n) && (array[a, b].value == CellState.mina))
                    {
                        kiek++;
                        //Console.WriteLine(kiek);
                    }
                }
            }
            if (array[i, j].value == CellState.mina) kiek--;
            //Console.WriteLine(kiek);
            return kiek;
        }




        public void PrintArray()  
        {
            //Console.SetCursorPosition(80, 20);
            for (int i = 0; i < size; i++)
            {
                Console.SetCursorPosition(20, 6 + i * 2);
                for (int j = 0; j < size; j++)
                {
                    if (MineSweeper[i, j].mode  == true)
                    {
                        Console.Write(MineSweeper[i, j].number + "   ");
                    }
                    else
                    {
                        Console.Write("%   ");
                    }

                    //Console.Write(" ");
                }
                
            }
        }

/*
        public void PrintTuscia()
        {
            //Console.SetCursorPosition(20, 20);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write('%' + "   ");
                }
                Console.SetCursorPosition(20, 10 + i * 2);
            }
        }
 */

        public void Valdymas()
        {
            int i = 0;
            int j = 0;
            Console.SetCursorPosition(j * 4 + 20, i * 2 + 6);
            if (MineSweeper[i, j].mode == false) Console.Write('@');

            ConsoleKeyInfo kb = Console.ReadKey();
            while (kb.Key != ConsoleKey.Enter)
            {
                switch (kb.Key)
                {
                    case ConsoleKey.LeftArrow:
                        if (j > 0)
                        {
                            j -= 1;
                            ZenkluPasikeitimas(i, j+1, i, j);
                            
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (j < size-1)
                        {
                            j += 1;
                            ZenkluPasikeitimas(i, j-1, i, j);
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (i > 0)
                        {
                            i -= 1;
                            ZenkluPasikeitimas(i+1, j, i, j);
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (i < size-1)
                        {
                            i += 1;
                            ZenkluPasikeitimas(i-1, j, i, j);
                        }
                        break;
                    default:
                        Console.SetCursorPosition(20, 6);
                        PrintArray();
                        break;
                }
                Debug.WriteLine("eilutes {0}, stulpelis {1}"+ MineSweeper[i, j].mode, i, j);  //eilute, stulpelis
                kb = Console.ReadKey();

            }
            Atverk(i, j);
        }


        public void ZenkluPasikeitimas(int oldi, int oldj, int i, int j)
        {
            if (MineSweeper[oldi, oldj].mode == false)//
            {
                Console.SetCursorPosition(20+oldj*4, 6+oldi*2);
                Console.Write('%');
            }
            
            if (MineSweeper[i, j].mode == false)//
            {
                Console.SetCursorPosition(20+j*4, 6+i*2);
                Console.Write('@');
            }
        }

        private int atvertiLangeliai = 0;
        public void Atverk(int i, int j)
        {
            
            MyWindow LoseWindow = new MyWindow(10, 5, 15, 50, '*', "PRALAIMĖJAI!");
            MyWindow WinWindow = new MyWindow(10, 5, 15, 50, '!', "Laimėjai! Valio!");

           
            if(MineSweeper[i, j].mode == false)
            {
                MineSweeper[i, j].mode = true;
                atvertiLangeliai++;
                Console.SetCursorPosition(j*4+20, i*2+6);
                if (MineSweeper[i, j].value == CellState.mina)
                {
                    // LoseButton.PrintWindow('*');
                    Console.Write('#');
                }
                else if (MineSweeper[i, j].value == CellState.skaicius)
                {
                    Console.Write(MineSweeper[i, j].number);
                }
                else
                {
                    //Console.Write(MineSweeper[i, j].number); 
                    Tuscia(i, j);
                }
                if (atvertiLangeliai == size*size)
                {
                    WinWindow.PrintWindow('!');
                }
            }
            
            Valdymas();

        }


        public void Tuscia(int x, int y)
        {
            Console.SetCursorPosition(x + 20, y + 6);
            Console.Write('O');//???
            for (int i = x-1; i <= x+1; i++)
            {
                for(int j = y-1; j <= y+1; j++)
                {
                    if (i >= 0 && j >= 0 && i < size && j < size)
                    {
                        if (MineSweeper[i, j].value == CellState.tuscia) //
                        {
                            Tuscia(i, j);
                        }

                    }
                    else break;
                }
            }

        }


    }
}
