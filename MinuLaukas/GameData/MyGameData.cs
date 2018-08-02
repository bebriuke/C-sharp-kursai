using MinuLaukas.MyMeniuWindow;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinuLaukas.GameData
{
    class MyGameData
    {
        private static int size_i = 10; //lentelės krastines ilgis
        private static int size_j; //lentelės krastines ilgis
        private CellData[,] MineSweeper;
        private int kiekis;
        private bool zaidimoPabaiga = false;
        private int minuSkaicius;
        public int eksperimentas = size_j;

        public MyGameData(int plotis = 10)
        {
            size_j = plotis;
           
            MineSweeper = new CellData[size_i, size_j];
            kiekis = size_i * size_j;
        }

        public void MinuIsdestymas()
        {
            kiekis = size_i * size_j;
            //Sudedam minas į lenelę
            Random random = new Random();
            
            minuSkaicius = Convert.ToInt32(0.1 * kiekis);
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
                    int i = x / size_j;
                    int j = x % size_j;
                    MineSweeper[i, j].value = CellState.mina;
                    MineSweeper[i, j].number = '#';
                    temp++;

                }
            }
        }


        private int[,] sk = new int[size_i, size_j];
        public CellData[,] Skaiciavimai()
        {
            int temp;
            for (int i = 0; i < size_i; i++)
            {
                for (int j = 0; j < size_j; j++)
                {
                    if (MineSweeper[i, j].value != CellState.mina)
                    {
                        temp = MinuSkaicius(MineSweeper, i, j, size_i, size_j);
                        if (temp == 0)
                        {
                            MineSweeper[i, j].value = CellState.tuscia;  //skaicius arba tuscia
                            MineSweeper[i, j].number = 'O';
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
           // Debug.WriteLine("atsiųstas taškas " + i + " " + j);
            for (int a = i - 1; a <= i + 1; a++)
            {
                for (int b = j - 1; b <= j + 1; b++)
                {
                   // Debug.WriteLine("koordinatės " + a + " " + b + " dydis: " + n + " " + m);
                    if ((a >= 0) && (b >= 0) && (a < n) && (b < m) )
                        if (array[a, b].value == CellState.mina)
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
            zaidimoPabaiga = false;
            atvertiLangeliai = 0;
            //Console.SetCursorPosition(80, 20);
            Console.WriteLine(eksperimentas + " " + size_i);
            for (int i = 0; i < size_i; i++)
            {
                Console.SetCursorPosition(20, 6 + i * 2);
                for (int j = 0; j < size_j; j++)
                {
                    if (MineSweeper[i, j].mode  == true)
                    {
                        if (MineSweeper[i, j].velevele == true)
                        {
                            SpausdinimoSpalva(i, j);
                            Console.Write("+   ");
                        }
                        else
                        {
                            SpausdinimoSpalva(i, j);
                            Console.Write(MineSweeper[i, j].number + "   ");
                        }
                        
                    }
                    else
                    {
                        if (MineSweeper[i, j].velevele == true)
                        {
                            SpausdinimoSpalva(i, j);
                            Console.Write("+   ");
                        }
                        else
                        {
                            SpausdinimoSpalva(i, j);
                            Console.Write("%   ");
                        }
                    }

                    //Console.Write(" ");
                }
                
            }
        }

/*
        public void PrintTuscia()
        {
            //Console.SetCursorPosition(20, 20);
            for (int i = 0; i < size_i; i++)
            {
                for (int j = 0; j < size_j; j++)
                {
                    Console.Write('%' + "   ");
                }
                Console.SetCursorPosition(20, 10 + i * 2);
            }
        }
 */

        public void Valdymas(int i, int j)
        {
            
            //Console.SetCursorPosition(j * 4 + 20, i * 2 + 6);
            // if (MineSweeper[i, j].mode == false) Console.Write('@');

            ConsoleKeyInfo kb = Console.ReadKey();
            while (kb.Key != ConsoleKey.Enter)
            {
                switch (kb.Key)
                {
                    case ConsoleKey.F5:
                        string data = JsonConvert.SerializeObject(MineSweeper);  // masyvą į tekstą
                       // CellData[,] naujas = JsonConvert.DeserializeObject<CellData[,]>(data);  //tekstą į masyvą! valio!!!
                        Console.WriteLine(data);
                        break;
                    case ConsoleKey.Spacebar:
                        ZymekVelevele(i, j);
                        break;
                    case ConsoleKey.LeftArrow:
                        if (j > 0)
                        {
                            j -= 1;
                            ZenkluPasikeitimas(i, j+1, i, j);
                            
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (j < size_j-1)
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
                        if (i < size_i-1)
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
                
                kb = Console.ReadKey();

            }
            Atverk(i, j);
        }


        public void ZymekVelevele(int i, int j)
        {
           if (MineSweeper[i, j].mode == false)
           {
                if (MineSweeper[i, j].velevele == false)
                {
                    MineSweeper[i, j].velevele = true;
                    Console.SetCursorPosition(20 + j * 4, 6 + i * 2);
                    SpausdinimoSpalva(i, j);
                    Console.Write('+');
                    
                }
                else
                {
                    MineSweeper[i, j].velevele = false;
                    Console.SetCursorPosition(20 + j * 4, 6 + i * 2);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write('@');
                    
                }
           }
        }


        public void ZenkluPasikeitimas(int oldi, int oldj, int i, int j)
        {
            if (MineSweeper[oldi, oldj].mode == false && MineSweeper[oldi, oldj].velevele == false)//
            {
                Console.SetCursorPosition(20+oldj*4, 6+oldi*2);
                SpausdinimoSpalva(oldi, oldj);
                Console.Write('%');
            }
            else
            {
                if(MineSweeper[oldi, oldj].mode == true)
                {
                    Console.SetCursorPosition(20 + oldj * 4, 6 + oldi * 2);
                    SpausdinimoSpalva(oldi, oldj);
                    Console.Write(MineSweeper[oldi, oldj].number);
                }
                if (MineSweeper[oldi, oldj].velevele == true)
                {
                    Console.SetCursorPosition(20 + oldj * 4, 6 + oldi * 2);
                    SpausdinimoSpalva(oldi, oldj);
                    Console.Write('+');
                }

            }

            if (MineSweeper[i, j].mode == false && MineSweeper[i, j].velevele == false)//
            {
                Console.SetCursorPosition(20 + j * 4, 6 + i * 2);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write('@');
            }
            else
            {
                if (MineSweeper[i, j].mode == true)
                {
                    Console.SetCursorPosition(20 + j * 4, 6 + i * 2);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(MineSweeper[i, j].number);
                }
                if (MineSweeper[i, j].velevele == true)
                {
                    Console.SetCursorPosition(20 + j * 4, 6 + i * 2);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write('+');
                }
            }
        }

        private int atvertiLangeliai = 0;
        public void Atverk(int i, int j)
        {
            
            MyWindow LoseWindow = new MyWindow(50, 5, 15, 50, '*', "PRALAIMĖJAI!");
            MyWindow WinWindow = new MyWindow(50, 5, 15, 50, '!', "Laimėjai! Valio!");

           
            if(MineSweeper[i, j].mode == false)
            {
                MineSweeper[i, j].mode = true;
                MineSweeper[i, j].velevele = false;
                atvertiLangeliai++;
                Debug.WriteLine("Atverta: " + atvertiLangeliai + "  Kartu su pažymėtais: " + (atvertiLangeliai + minuSkaicius) + "   Iš viso: " + (size_i * size_j));
                Console.SetCursorPosition(j*4+20, i*2+6);


                if (MineSweeper[i, j].value == CellState.mina)
                {
                    
                    LoseTable();
                    PrintArray();
                    Console.ForegroundColor = ConsoleColor.Gray;
                    LoseWindow.PrintWindow('*');
                    zaidimoPabaiga = true;
                    //Console.Write('#');

                }
                else if (MineSweeper[i, j].value == CellState.skaicius)
                {
                    SpausdinimoSpalva(i, j);
                    Console.Write(MineSweeper[i, j].number);
                }
                else
                {
                    //Console.Write(MineSweeper[i, j].number); 
                    Tuscia(i, j);
                }


                if (atvertiLangeliai + minuSkaicius == size_i*size_j)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    WinWindow.PrintWindow('!');
                    zaidimoPabaiga = true;
                }
            }

            if (zaidimoPabaiga == false)
            {
                Valdymas(i, j);
            }

        }


        public void LoseTable()
        {
            for(int i = 0; i < size_i; i++)
            {
                for(int j = 0; j < size_j; j++)
                {
                    MineSweeper[i, j].mode = true;
                }
            }
        }

        public void Tuscia(int x, int y) //
        {

            Console.SetCursorPosition(y * 4 + 20, x * 2 + 6);
            MineSweeper[x, y].mode = true;
            SpausdinimoSpalva(x, y);
            Console.Write(MineSweeper[x, y].number);
            
            
            //Debug.WriteLine("nulis eilute {0}, stulpelis {1}  " + MineSweeper[x, y].mode, x, y);  //eilute, stulpelis

            for (int i = x-1; i <= x+1; i++)
            {
                for(int j = y-1; j <= y+1; j++)
                {
                    if (i >= 0 && j >= 0 && i < size_i && j < size_j)
                    {
                        if(MineSweeper[i, j].mode == false)
                        {
                            if (MineSweeper[i, j].value == CellState.skaicius)
                            {
                                MineSweeper[i, j].mode = true;
                                Console.SetCursorPosition(j * 4 + 20, i * 2 + 6);
                                SpausdinimoSpalva(i, j);
                                Console.Write(MineSweeper[i, j].number);
                                atvertiLangeliai++;
                            }
                            else
                            {
                                if (MineSweeper[i, j].value == CellState.tuscia)
                                {
                                    atvertiLangeliai++;
                                    Tuscia(i, j);
                                }
                            }
                        }
                    }
                }
            }
        }

        public void SpausdinimoSpalva(int i, int j)
        {
            if (MineSweeper[i, j].mode == true)
            {
                if (MineSweeper[i, j].value == CellState.mina)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (MineSweeper[i, j].value == CellState.skaicius)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else if (MineSweeper[i, j].value == CellState.tuscia)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
            }
            else
            {
                if (MineSweeper[i, j].velevele == true)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }    

                
        }



        public void SaveData()
        {
            string path = @"data.txt";
            File.WriteAllText(path, size_i + " " + size_j + Environment.NewLine);
            for (int i = 0; i < size_i; i++)
            {
                for (int j = 0; j < size_j; j++)
                {
                    File.AppendAllText(path, MineSweeper[i, j].value + " " + MineSweeper[i, j].number + " " + Environment.NewLine);
                }
            }
           
        }

        public void ReadFromFile()
        {
            StreamReader file = new StreamReader(@"data.txt");
            
            string myStr = file.ReadLine();
            string[] laik = new string[2];
            laik = myStr.Split(' ');
            size_i = Convert.ToInt32(laik[0]);
            size_j = Convert.ToInt32(laik[1]);
            Debug.WriteLine(size_i + " " + size_j);
            kiekis = size_i + size_j;
            MineSweeper = new CellData[size_i, size_j];
            for (int i = 0; i < size_i; i++)
            {
                for (int j = 0; j < size_j; j++)
                {

                    myStr = file.ReadLine();
                    laik = myStr.Split(' ');
                    Debug.WriteLine(i + " " + j);
                    MineSweeper[i, j].mode = false;
                    if (Convert.ToString(laik[1]) == "tuscia")
                    {
                        MineSweeper[i, j].value = CellState.tuscia;
                    }
                    else if (Convert.ToString(laik[1]) == "mina")
                    {
                        MineSweeper[i, j].value = CellState.mina;
                    }
                    else if(Convert.ToString(laik[1]) == "skaicius")
                    {
                        MineSweeper[i, j].value = CellState.skaicius;
                    }
                    Debug.WriteLine(laik[1]);
                    MineSweeper[i, j].number = Convert.ToChar(laik[1]);
                    MineSweeper[i, j].velevele = false;
                }
            }
        }
    }
}
