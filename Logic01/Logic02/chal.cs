using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base;

namespace Logic02
{
    class Chal : LogicProps 
    {
        public Chal(int n)
        {
            Array2D = new string[2, n];
            FillArray();
            LogicFunction.PrintArray(Array2D);
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
        private void FillArray()
        {
            int a = 2;
            int b = (Array2D.GetLength(1) - 1);
            for (int i = 0; i < Array2D.GetLength(1); i++)
            {
                Array2D[0, i] = b.ToString();// array atas
                b--;
                if (i == a)
                {
                    Array2D[1, i] = "XXX";// array bawah
                    a = a + 3;
                }
                else
                {
                    Array2D[1, i] = (Math.Pow(3, i)).ToString();
                }
            }
        }
    }
}
