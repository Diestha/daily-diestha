using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base;

namespace Logic02
{
    class Soal05 : LogicProps
    {
        public Soal05(string kalimat)
        {
            Array1 = new string[kalimat.Length];
            Array1 = kalimat.Split(' ');
            FillArray(Array1);
            Console.ReadKey();
        }
        private void FillArray(string [] kal)
        {
            for(int i= 0; i < kal.Length; i++)
            {
                char[] arrChar = kal[i].ToCharArray();
                for(int o =0; o < arrChar.Length; o++)
                {
                    if (o > 0 && o < arrChar.Length-1)
            {
                arrChar[o]= '*';
            }
                }
                kal[i] = new string(arrChar);
            }
            Console.WriteLine("\nHasilnya : " + string.Join("", kal));
        }

    }
}
