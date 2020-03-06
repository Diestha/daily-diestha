using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string repeat = "Y";
                while (repeat == "Y")
                {
                    Console.Write("Masukan logic ke : ");
                    int logicNum = int.Parse(Console.ReadLine());
                    switch (logicNum)
                    {
                        case 1:
                            Logic01.Program prog01 = new Logic01.Program();

                            break;
                        case 2:
                            Logic02.Program prog02 = new Logic02.Program();
                            break;

                        default:
                            break;
                    }
                    Console.Write("Lanjut y/Y : ");
                    repeat = Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }

        }
    }
}

