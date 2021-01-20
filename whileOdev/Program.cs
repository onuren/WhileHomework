using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0;
            int sayac = 0;
            int toplam=0;
            while (sayi <=100)
            {
                if (sayi % 4==0)
                {
                    sayac++;
                    toplam += sayi;
                }
                sayi++;
            }
            Console.WriteLine("{0} adet sayı vardır. Toplamları: {1}",sayac,toplam);
        }
    }
}
