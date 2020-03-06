using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Masukan Nilai N = ");
            //int n = int.Parse(Console.ReadLine());
            // Soal01 soal01 = new Soal01(n);
            //Soal02 soal02 = new Soal02(n);
            Console.WriteLine("Masukan kalimat : ");
            string kalimat = Console.ReadLine();
            Chal01 chal01 = new Chal01(kalimat);
        }
    }
}
