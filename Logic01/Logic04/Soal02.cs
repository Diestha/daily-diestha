class Soal02
{
    public Soal02()
    {
     
        System.Console.Write("Masukan jumlah pergeseran huruf: ");
        int geser = int.Parse(System.Console.ReadLine());
        System.Console.Write("Masukan kalimat yang akan digeser: ");
        char[] kalimat = System.Console.ReadLine().ToCharArray();
        string hasil = Rotate(kalimat, geser);
        Cetak(hasil);
        System.Console.ReadKey();
    }
    private void Cetak(string a)
    {
        System.Console.WriteLine("Hasil kalimat sesudah digeser: " + a);
    }
    private static string Rotate(char[] arrKal, int geser)
    {
        string Conn = "";
        char temp = ' ';
        for (int i = 0; i < arrKal.Length; i++)
        {
            temp = arrKal[i];
            if (arrKal[i] >= 65 && arrKal[i] <= 90) 
            {
                temp = (char)(temp + geser);
                if (temp > 90)
                {
                    temp = (char)(temp - 26);
                }
                Conn += temp;
            }
            else if (arrKal[i] >= 97 && arrKal[i] <= 122) 
            {
                temp = (char)(temp + geser);
                if (temp > 122)
                {
                    temp = (char)(temp - 26);
                }
                Conn += temp;
            }
            else if (arrKal[i] == ' ' || arrKal[i] < 65 || arrKal[i] > 90 || arrKal[i] < 97 || arrKal[i] > 122)
            {
                Conn += temp;
            }
        }
        return (Conn);
    }
}