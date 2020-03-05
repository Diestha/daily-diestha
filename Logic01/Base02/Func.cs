using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base02
{
    public class Func
    {
        public static void PrintArray2D(string[,] arr)
        {
            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int kol = 0; kol < arr.GetLength(1); kol++)
                {
                    Console.Write(arr[row, kol] + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.Write("Press any key");
            Console.ReadKey();
        }

        public static void PrintArray1D(string[] arr)
        {
            for (int kol = 0; kol < arr.Length; kol++)
            {
                Console.Write(arr[kol] + "\t");
            }
            Console.Write("Press any key");
            Console.ReadKey();
        }
    }
}
