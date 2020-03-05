using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base;

namespace Logic02
{
    class Soal06 : LogicProps
    {
        public Soal06(string kalimat)
        {
            Array1 = new string[kalimat.Length];
            FillArray(kalimat);
            LogicFunction.PrintArray(Array1);
            CountUpper();
        }
        private void CountUpper()
        {
            int jmlUpper = 0;
            for (int i = 0; i<Array1.Length; i++)
            {
                int temp = char.ConvertToUtf32(Array1[i], 0);
                if (temp >= 65 && temp <= 90)
                jmlUpper++;
            }
            Console.WriteLine("Hasilnya " + jmlUpper.ToString());

            Console.ReadKey();
        }
        private void FillArray(string kal)
        {
            //konversi string ke array

            //Array1 = kal.Split();
            char[] cArr = kal.ToCharArray();
            int idx = 0;
            foreach(var ch in cArr)
            {
                Array1[idx++] = ch.ToString();
            }
        }
    }
}
