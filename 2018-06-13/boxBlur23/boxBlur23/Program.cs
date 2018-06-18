using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boxBlur23
{
    class Program
    {
        static int[][] boxBlur(int[][] image)
        {

            int sum = 0, sk, i, j, a, b;
            int ilg1 = image.Length;
            int ilg2 = image[0].Length;
            //int[] naujas = new int[ilg1 - 2];
            //int [] eilute = 
            int[][] naujas = new int[ilg1 - 2][];
            for (i = 0; i < ilg2-2; i++)
            {
                naujas[i] = new int[ilg1 - 2];
            }


            for (i = 0; i < ilg1 - 2; i++)
                for (j = 0; j < ilg2 - 2; j++)
                {
                    sum = 0;
                    Console.WriteLine(sum);
                    for (a = i; a < i + 3; a++)
                        for (b = j; b < j + 3; b++)
                            sum += image[a][b];

                    Console.WriteLine(sum);
                    sk = sum / 9;
                    Console.WriteLine(sk);
                    Console.WriteLine(i + ", " + j);
                    naujas[i][j] = sk;
                    Console.WriteLine(naujas[i][j]);

                }


            return naujas;
        }



        static void Main(string[] args)
        {
            //int[][] image = [[1, 1, 1], [1, 7, 1], [1, 1, 1]];
            int[][] naujas = new int[3][];
           
            naujas[0] = new int[] { 1, 1, 1 };
            naujas[1] = new int[] { 1, 7, 1 };
            naujas[2] = new int[] { 1, 1, 1 };

            boxBlur(naujas);
            Console.ReadKey();
    }
    }
}
