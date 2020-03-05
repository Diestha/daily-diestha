using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base02;

namespace Review
{
    class Soal01 : Props
    {
        public Soal01(int n)
        {
            Array2D = new String[1, n];
            FillArray();
            Func.PrintArray2D(Array2D);
            Console.Write("Press Any key");
            Console.ReadKey();
        }
        private void FillArray()
        {
            for (int kol = 0; kol < Array2D.GetLength(1); kol++) ;
            {
             
                Console.Write(kol *2 + 1);
            }
        }
    }
}

