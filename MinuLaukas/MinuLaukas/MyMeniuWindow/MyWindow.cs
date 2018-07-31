using MinuLaukas.GameData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinuLaukas.MyMeniuWindow
{
    class MyWindow
    {
        //remeliai: koordinatė, ilgis, plotis, aktyvumas

        //tekstas viduje
        private int _x;
        private int _y;
        private int _aukstis;
        private int _plotis;
        private char _ch;

        private string _text;

        public MyWindow(int x, int y, int aukstis, int plotis, char ch = '&', string tekstas = "")
        {
            _x = x;
            _y = y;
            _aukstis = aukstis;
            _plotis = plotis;
            _ch = ch;
            _text = tekstas;

        }

        /*public MyWindow(CellData cellData)
        {
            _x = cellData.x;
            _y = cellData.y;


        }*/

        public void PrintWindow(char ch)
        {

            Console.SetCursorPosition(_x, _y);
            for (int i = 0; i < _aukstis; i++)
            {
                if (i == 0 || i == (_aukstis - 1))
                {
                    for (int j = 0; j < _plotis; j++)
                    {
                        Console.Write(ch);
                    }
                }
                else
                {
                    Console.Write(ch);
                    for (int j = 1; j < _plotis - 1; j++)
                    {
                        Console.Write(' ');
                    }

                    Console.Write(ch);
                }
                Console.SetCursorPosition(_x, _y + i + 1);
                

            }
            int px = (_plotis - _text.Length) / 2;
            int py = (_aukstis / 2);

            Console.SetCursorPosition(_x + px, py + _y);
            Console.Write(_text);

        }
    }
}
