using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base;

namespace Logic02
{
    class Soal01 : LogicProps
    {
        public Soal01(int n)
        {
            Array2D = new string[2, n];
            FillArray();
            LogicFunction.PrintArray(Array2D);
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
        private void FillArray()
        {
            for (int i = 0; i < Array2D.GetLength(1); i++)
            {
                Array2D[0, i] = i.ToString();
            }
            for (int i = 0; i < Array2D.GetLength(1); i++)
            {
                Array2D[1, i] = (Math.Pow(3,i)).ToString(); 
            }
        }
    }
}
