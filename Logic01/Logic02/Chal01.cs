using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base;

namespace Logic02
{
    class Chal01 : LogicProps
    {
        public Chal01(string kalimat)
        {
            Array1 = new string[kalimat.Length];
            FillArray(kalimat);
            a();
            Console.ReadKey();
        }
        private void a()
        {
            int k = (Array1.Length - 1);
            for (int i = 0; i < Array1.Length; i++)
            {
                Console.Write(Array1[k]);
                k--;
            }
        }
        private void FillArray(string kal)
        {
            char[] cArr = kal.ToCharArray();
            int idx = 0;
            foreach (var ch in cArr)
            {
                Array1[idx++] = ch.ToString();
            }
        }
    }
}
