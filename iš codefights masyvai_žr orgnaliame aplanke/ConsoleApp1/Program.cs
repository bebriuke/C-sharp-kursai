using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;







namespace ConsoleApp1
{
    class Program
    {
        static  void PrintArray(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine();
        }


        static string[] allLongestStrings(string[] inputArray)
        {
            int max = 0;
            int m = inputArray.Length;
            List<String> newlist = new List<String>();
            for (int i = 0; i < m; i++)
            {
                if (max < inputArray[i].Length)
                    max = inputArray[i].Length;
            }

            for (int i = 0; i < m; i++)
            {
                if (max == inputArray[i].Length)
                {
                    newlist.Add(inputArray[i]);
                }
            }

            return newlist.ToArray();
        }



        static void Main(string[] args)
        {
            string[] theArray = { "aba", "aa", "ad", "vcd", "aba" };
            //List<String> ats = allLongestStrings(theArray).Result;
            //int m = allLongestStrings(theArray).Result.Length;
            PrintArray(allLongestStrings(theArray));
            //PrintArray(theArray);
            Console.ReadLine();


        }
        
    }
}






