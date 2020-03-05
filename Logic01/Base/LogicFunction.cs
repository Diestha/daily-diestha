using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    public class LogicFunction
    {
        public static void PrintArray(string[,] arr)
        {
            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    Console.Write(arr[row, col] + "\t");
                    //Perpindahan kolom
                }
                Console.WriteLine("\n");
                //Perpindahan baris
            }
            Console.Write("Press any key!!!");
            Console.ReadKey();
        }

        public static void PrintArray(string[] arr)
        {
            for (int col = 0; col < arr.Length; col++)
            {
                Console.Write(arr[col] + "\t");
                //Perpindahan kolom
            }

            Console.Write("Press any key!!!");
            Console.ReadKey();
        }
    }
}