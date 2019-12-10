using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazi.KazanMyo.Sube2.DongulerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Döngü değişkeni
            //Döngünün dönüş sayısını kontrol eder.

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Gazi");
            //}

            //2*2*2

            //int sonuc = 1;
            //for (int i = 0; i < 3; i++)
            //{
            //    sonuc = sonuc * 2;
            //}
            //Console.WriteLine(sonuc);

            //3!=3*2*1
            //int sonuc = 1;
            //for (int i = 2; i <= 3; i++)
            //{
            //   // sonuc = sonuc * i;
            //    sonuc *= i;
            //}
            //Console.WriteLine(sonuc);

            Console.WriteLine("Birinci sayıyı giriniz:");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.WriteLine("İkinci sayıyı giriniz:");
            int sayi2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Tek/Çift?");

            int toplam = 0;

            //sayi1=10
            //sayi2=5

            if (sayi1 > sayi2)
            {
                int temp = sayi1;
                sayi1 = sayi2;
                sayi2 = temp;
            }

            //5%2=1
            //Github-Visual Studio Github Extension
            //Depo-Repository
            for (int i = sayi1; i <= sayi2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                    toplam = toplam + i;
                }
            }
            Console.WriteLine(toplam);
            Console.ReadKey();
        }
    }
}
