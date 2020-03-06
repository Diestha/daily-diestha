//exam
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base;

namespace Logic03
{
    class Soal05
    {
        public Soal05()
        {
            Console.WriteLine("masukan Nilai dengan spas : ");
            string[] angkaArr = Console.ReadLine().Split(' ');
            int[] result = countscore(angkaArr);
            ShowResult(result[0], result[1]);
        }
        private int[] countscore(string[] arr1)
        {
            int[] result = new int[2];
            int a = 0;
            int b = 0;
            Array.Sort(arr1);
            for (int i = 0; i < arr1.Length; i++)
            {
                if (i != 0)
                {
                  a += Int32.Parse(arr1[i]);
                }
               if (i < arr1.Length -1)
                {
                  b += Int32.Parse(arr1[i]);
                }
            }
            result[0] = a;
            result[1] = b;
            return result;
        }
        private void ShowResult(int a, int b)
        {
            Console.WriteLine("Besar : {0}, Kecil : {1} ", a, b);
            Console.ReadKey();
        }
    }
}
