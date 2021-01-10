using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiBulmacaOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sayiBulunduMu = true; // Sonlanmayan bir sayı tahmin oyunudur. Sayı doğru tahmin edildikten sonra, program random seçilen farklı bir sayı ile devam eder.

            Random rastgeleSayiUretici = new Random();
            int uretilenSayi = rastgeleSayiUretici.Next(1, 100);
            while (sayiBulunduMu)
            {

                Console.WriteLine("Tahmininizi girin: ");
                int tahminEdilenSayi = Convert.ToInt32(Console.ReadLine());
                if (uretilenSayi > tahminEdilenSayi)
                {
                    Console.WriteLine("Yukarı!");
                }
                else if (uretilenSayi < tahminEdilenSayi)
                {
                    Console.WriteLine("Aşağı in!");
                }
                else
                {
                    Console.WriteLine("doğru tahmin");
                    Console.WriteLine("çıkmak isterseniz 1'e, devam etmek isterseniz 2'ye basın");
                    int devam = Convert.ToInt32(Console.ReadLine());
                    if (devam == 1)
                    {
                        sayiBulunduMu = false;
                    }
                    else if (devam == 2)
                    {
                        uretilenSayi = rastgeleSayiUretici.Next(1, 100); //uretilenSayi burda yazılmazsa program aynı random sayıyı üretiyor.
                    }


                }
            
            }
        }
    }
}
