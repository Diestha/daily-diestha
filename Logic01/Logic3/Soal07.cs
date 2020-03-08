using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic03
{
    class Soal07
    {
        public Soal07()
        {
            Console.Write("region (Apel Jeruk)          : ");
            string[] region = Console.ReadLine().Split(' ');
            Console.Write("posisi buah (Apel / Jeruk)   : ");
            string[] posBuah = Console.ReadLine().Split(' ');
            Console.Write("posisi akhir Apel            : ");
            string[] posApel = Console.ReadLine().Split(' ');
            Console.Write("posisi akhir jeruk           : ");
            string[] posJeruk = Console.ReadLine().Split(' ');
            hitung(region, posBuah, posApel, posJeruk);
            Console.ReadKey();
        }

        private void hitung(string[] region, string[] posBuah, string[] posApel, string[] posJeruk)
        {
            int countA = 0;
            int countB = 0;
            int reg0 = int.Parse(region[0]);
            int reg1 = int.Parse(region[1]);
            int posBapel = int.Parse(posBuah[0]);
            int posBjeruk = int.Parse(posBuah[1]);
            for (int i = 0; i < posApel.Length; i++)
            {
                int x = int.Parse(posApel[i]);
                if (posBapel + x >= reg0 && posBapel + x <= reg1)
                {
                    countA++;
                }
            }
            for (int i = 0; i < posJeruk.Length; i++)
            {
                int x = int.Parse(posJeruk[i]);
                if (posBjeruk + x >= reg0 && posBjeruk + x <= reg1)
                {
                    countB++;
                }
            }
            print(countA, countB);
        }

        private void print(int a, int j)
        {
            Console.WriteLine("Jumlah Apel dalam region     : {0}\nJumlah jeruk dalam region    : {1}", a, j);
        }
    }
}
