using Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic03
{
    public class Soal04 : LogicProps
    {
        public Soal04()
        {
            //Console.WriteLine("Masukkan deret 2 dim:");
            //string[] split1 = Console.ReadLine().Split(',');
            string[] split1 = "1 2 3 2 8,4 19 10 5 6,7 1 8 0 9,4 19 10 5 6,7 1 8 0 9".Split(',');
            int jmlBrs = split1.Length;
            int jmlKol = 0;
            foreach (var item in split1)
            {
                string[] split2 = item.Split(' ');
                jmlKol = split2.Length;
                break;
            }

            Array2D = new string[jmlBrs, jmlKol];

            int brs = 0;
            foreach (var item1 in split1)
            {
                int kol = 0;
                string[] split2 = item1.Split(' ');
                foreach (var item2 in split2)
                {
                    Array2D[brs, kol] = item2;
                    kol++;
                }
                brs++;
            }
            LogicFunction.PrintArray(Array2D);
            int[] result = CountDiagonal(Array2D);
            Console.WriteLine("D1: {0}, D2: {1}, Diff: {2}", result[0], result[1], Math.Abs(result[0] - result[1]));
            Console.Write("Press any key!");
            Console.ReadKey();
        }

        private int[] CountDiagonal(string[,] array2D)
        {
            int[] result = new int[2];

            for (int row = 0; row < array2D.GetLength(0); row++)
            {
                for (int col = 0; col < array2D.GetLength(1); col++)
                {
                    if (row == col)
                    {
                        // Diagonal 1
                        result[0] = result[0] + int.Parse(array2D[row, col]);
                    }
                    if (row == array2D.GetLength(1) - col - 1)
                    {
                        //Diagonal 2
                        result[1] = result[1] + int.Parse(array2D[row, col]);
                    }
                }
                Console.WriteLine();
            }
            return result;
        }
    }
}
