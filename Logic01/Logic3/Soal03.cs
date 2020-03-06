using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base;

namespace Logic03
{
   public class Soal03 : LogicProps
    {
        public Soal03()
        {
            Console.WriteLine("masukan score alice dgn sepertor , : ");
            string[] aliceArr = Console.ReadLine().Split(',');
            Console.WriteLine("masukan score bob dgn sepertor , : ");
            string[] bobArr = Console.ReadLine().Split(',');

            countscore(aliceArr, bobArr);
        }

        private void countscore(string[] arr1, string[] arr2)
        {
            int aliSc = 0;
            int bobSc = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (int.Parse(arr1[i]) > int.Parse(arr2[i]))
                {
                    aliSc++;
                }
                else if (int.Parse(arr1[i]) < int.Parse(arr2[i]))
                {
                    bobSc++;
                }
            }
            ShowResult(aliSc, bobSc);
        }
        private void ShowResult(int aliSc, int bobSc)
        {
            Console.WriteLine("Alice : {0}, Bob : {1} ", aliSc, bobSc);
        }
    }
}