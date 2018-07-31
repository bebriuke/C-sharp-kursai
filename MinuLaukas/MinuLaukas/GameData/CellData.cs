using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinuLaukas.GameData
{
    public enum CellState { tuscia, mina, skaicius }

    public struct CellData
    {
        
        public bool mode; // atidengta - 1 /uždengta - 0//bool
        public CellState value; // tuscia; mina; skaicius; 
        public char number;  // O 1 2 3 4 5 6 7 8 # - matomas simbolis
        

        public CellData(bool atidengta = false, CellState reiksme = CellState.tuscia, char num = 'O')
        {
            
            mode = atidengta;
            value = reiksme;
            number = num;
        }

    }
}
