using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Örnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("tc:");
            string tc = Console.ReadLine();
            int[] tcno = new int[tc.Length];
            int toplam = 0;
            for (int i = 0; i < tcno.Length - 1; i++)
            {
                tcno[i] = Convert.ToInt32(tc[i].ToString());
                toplam += tcno[i];



            }

            if (tc.Length==11)
            {
                if (toplam % 10 == tcno[tcno.Length - 1])
                {
                    Console.WriteLine("giriş yapıldı");


                }
                else
                {
                    Console.WriteLine("böyle bir şahıs bulunamadı lütfen kontrol ediniz");
                }
                Console.WriteLine(toplam);

            }
            else
            {
                Console.WriteLine("tcnizi eksik ya da fazla girdiniz");
            }

            

            Console.ReadLine();
        }
    }
}
