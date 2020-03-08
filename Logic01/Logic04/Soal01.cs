public class Soal01
{
    public Soal01()
    {
        System.Console.Write("Input Kata   : ");
        string kata = System.Console.ReadLine();
        string kalimatpisah = PisahKata(kata);
        string kalimat = CetakKalimat(kalimatpisah);
        int total = JumlahKata(kalimat);
        CetakHasil(total);
        System.Console.ReadKey();
    }

    private static int JumlahKata(string kalimat)
    {
        int count = 0;
        string[] arrKat = kalimat.Split(' ');
        for (int i = 0; i < arrKat.Length; i++)
        {
            if (arrKat[i] != "")
            {
                count++;
            }
        }
        return (count);
    }

    private static string PisahKata(string input)
    {
        string kata = "";
        foreach (char ch in input)
        {
            if (char.IsLower(ch))
            {
                kata += ch.ToString();
            }
            else if (char.IsUpper(ch))
            {
                kata += " " + ch.ToString();
            }
        }
        return (kata);
    }

    private static string CetakKalimat(string kalimat)
    {
        System.Console.WriteLine("Kalimat      : " + kalimat);
        return (kalimat);
    }

    private static void CetakHasil(int total)
    {
        System.Console.WriteLine("Total Kata   : " + total);
    }
}