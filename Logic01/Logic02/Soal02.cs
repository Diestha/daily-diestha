using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base;

namespace Logic02
{
    class Soal02 : LogicProps
    {
        public Soal02(int n)
        {
            Array2D = new string[2, n];
            FillArray();
            LogicFunction.PrintArray(Array2D);
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
        private void FillArray()

        {
            int j = 2;
            for (int i = 0; i < Array2D.GetLength(1); i++)
            {
                Array2D[0, i] = i.ToString();
                Array2D[1, i] = (Math.Pow(3, i)).ToString();

                if (j == i)
                {
                    Array2D[1, i] = (Math.Pow(3, i) * (-1)).ToString();
                    j = j + 3;
                }
            }
        }
    }
}
