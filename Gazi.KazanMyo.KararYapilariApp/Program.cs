using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazi.KazanMyo.KararYapilariApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Birinci sayıyı giriniz:");
            //byte sayi1 = byte.Parse(Console.ReadLine());

            //Console.WriteLine("İkinci Sayıyı giriniz:");
            //byte sayi2 = byte.Parse(Console.ReadLine());

            //if (sayi1 > sayi2)
            //{
            //    Console.WriteLine("Sayı 1 Büyük");
            //}
            //else if(sayi2>sayi1)
            //{                
            //    Console.WriteLine("Sayı 2 Büyük");
            //}
            //else
            //{
            //    Console.WriteLine("Sayılar eşittir.");
            //}

            //?:->Ternary Operator
            //C#'da 3 operand alan tek operator.
            //Sadece if-else durumlarında kullanılır.

            //Console.WriteLine(sayi1 > sayi2 ? "Sayı1 Büyük" : "Sayı 1 Küçüktür ya da sayılar eşittir.");

            //  1  &&  0 = 0
            //  0  &&  1 = 0
            //  0  &&  0 = 0
            //  1  &&  1 = 1

            //  1  ||  0 = 1
            //  0  ||  1 = 1
            //  0  ||  0 = 0
            //  1  ||  1 = 1

            //byte a = 10;
            //byte b = 3;
            //Console.WriteLine((!(a == b) && (b == 3)));

            //c# case sensitive bir dildir. 




            //Console.WriteLine("Hava Nasıl?Güzel/Kötü");
            //string cevap = Console.ReadLine();
            //if (cevap.ToLower() == "güzel")
            //{
            //    //0'dan küçükse->Çok soğuk
            //    //0-15 Soğuk
            //    //15-35 Dışarı çık
            //    //>35 Çok sıcak

            //    Console.WriteLine("Kaç derece?");
            //    sbyte derece = sbyte.Parse(Console.ReadLine());
            //    if (derece < 0)
            //    {
            //        Console.WriteLine("Çok soğuk");
            //    }
            //    else if (derece >= 0 && derece <= 15)
            //    {
            //        Console.WriteLine("Soğuk");
            //    }
            //    else if (derece > 15 && derece <= 35)
            //    {
            //        Console.WriteLine("Dışarı Çık");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Çok Sıcak!!");
            //    }
            //}
            //else if (cevap == "kötü")
            //{
            //    Console.WriteLine("Evde otur");
            //}
            //else
            //{
            //    Console.WriteLine("Sadece güzel/kötü cevabı verebilirsiniz.");
            //}

            //BreakPoint
            //Start Debugging-F5 Hata Ayıklama Modu
            //Start Without Debugging- Ctrl+F5
            int sayi = 3;

            if (sayi == 1)
            {
                Console.WriteLine("Sayı değeri 1");
            }
            else if (sayi == 2)
            {
                Console.WriteLine("Sayı değeri 2");
            }
            else if (sayi == 3)
            {
                Console.WriteLine("Sayı değeri 3");
            }
            else
            {
                Console.WriteLine("Yukarıdakilerden hiçbiri");
            }

            switch (sayi)
            {
                case 1:
                    Console.WriteLine("Sayı değeri 1");
                    break;
                case 2:
                    Console.WriteLine("Sayı değeri 2");
                    break;
                case 3:
                    Console.WriteLine("Sayı değeri 3");
                    break;
                default:
                    Console.WriteLine("Yukarıdakilerden hiçbiri");
                    break;
            }



            Console.ReadKey();
            
        }
    }
}
