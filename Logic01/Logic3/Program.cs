using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan Nilai Alice :");

            string deret1 = Console.ReadLine();
            string[] arrDeret1 = deret1.Split(',');


            Console.Write("Masukkan Nilai Bob :");

            string deret2 = Console.ReadLine();
            string[] arrDeret2 = deret2.Split(',');

            int j = 0;
            int k = 0;
            for (int i = 0; i < arrDeret1.Length; i++)
            {
                int x = Int32.Parse(arrDeret1[i]);
                int y = Int32.Parse(arrDeret2[i]);
                if (x > y)
                {
                    j = j + 1;
                }
                else if (x < y)
                {
                    k = k + 1;
                }
                else if (x == y)
                {
                    j = j + 0;
                    k = k + 0;
                }
            }
            Console.WriteLine("[" + j + "," + k + "]");
            Console.WriteLine("Press Any Key !!!");
            Console.ReadKey();
        }
    }
}