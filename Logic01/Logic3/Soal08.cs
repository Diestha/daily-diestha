//exam
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic03
{
    class Soal08
    {
        public Soal08()
        {
            Console.WriteLine("Masukkan Angka Dengan Spas : ");
            string[] Arr = Console.ReadLine().Split(' ');

            int[] result = Count(Arr);
            ShowResult(result[0]);

        }
        private int[] Count(string[] arr1)
        {
            int[] result = new int[1];
            int max = 0;
            int b = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                b = int.Parse(arr1.Max());
                if (int.Parse(arr1[i]) != b)
                {
                    max++;
                }
            }
            result[0] = max;
            return result;
        }
        private void ShowResult(int max)
        {
            Console.WriteLine("Sisanya Adalah : {0} ", max);
            Console.ReadKey();
        }
    }
}
