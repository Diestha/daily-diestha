using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base;

namespace Logic02
{
    class Soal04 : LogicProps
    {
        public Soal04(int n)
        {
            Array2D = new string[2, n];
            FillArray();
            LogicFunction.PrintArray(Array2D);
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
        private void FillArray()

        {
            int k =  12;
            int j = 3;
            for (int i = 0; i < Array2D.GetLength(1); i++)
            {
                Array2D[0, i] = i.ToString();
                if (i < k)
                {
                    Array2D[1, i] = j.ToString();
                    j = j + 3;
                }
                else if (i >= k)
                {
                    Array2D[1, i] = j.ToString();
                    j = j - 3;
                }
            }
        }
    }
}
