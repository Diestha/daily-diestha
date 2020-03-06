using System;

namespace Logic03
{
    public class Soal06
    {
        public Soal06()
        {
            int y = 0;
            Console.Write("Masukkan angka dengan batas spasi : ");
            string tambah = Console.ReadLine();
            string[] arrtambah = tambah.Split(' ');
            for (int i = 0; i < arrtambah.Length; i++)
            {
                int x = Int32.Parse(arrtambah[i]);
                y = y + x;
            }
            Console.WriteLine("Jumlah nya adalah : " + y);
            Console.WriteLine("Press Any Key !!!");
            Console.ReadKey();
        }
    }
}