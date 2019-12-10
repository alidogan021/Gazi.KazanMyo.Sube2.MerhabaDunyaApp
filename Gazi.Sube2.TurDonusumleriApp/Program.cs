using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazi.Sube2.TurDonusumleriApp
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Renk
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            #endregion

            //Tip Güvenliği-Type Safety
            //Explicit Type Casting
            //Parantez() ile yapılan dönüşümler değer tipinden değer tipine yapılır. İstisna:Object->Değer tipine


            //checked
            //{
            //    int sayi = 50;
            //    byte _sayi = (byte)sayi;
            //    Console.WriteLine(_sayi); 
            //}
            //Object tipi: Bütün tipler object tipinden türetilmiştir. Referans tipidir.

            //int sayi = 5;
            //object _objsayi = sayi;//Boxing:Değer tipinin object tipine dönüştürülmesi.


            //int _sayi = (int)_objsayi;//Unboxing:Daha önceden boxing yapılmış değer tipinin, tekrar kendi tipine dönüştürlmesi.


            //string deneme = "5";
            //int _deneme = int.Parse(deneme);//string->int
            //byte deneme_ = byte.Parse(deneme);


            //_deneme = Convert.ToInt32(deneme);//string->int


            //object objnum = 5;
            //int _sayi = (int)objnum;



            try
            {
                Console.WriteLine("Adınızı Giriniz:");
                string ad = Console.ReadLine();

                Console.WriteLine("Soyadınızı Giriniz:");
                string soyad = Console.ReadLine();

                Console.WriteLine("Yaşınızı giriniz:");
                byte yas = byte.Parse(Console.ReadLine());

                Console.WriteLine($"Adınız:{ad}\nSoyadınız:{soyad}\nYaşınız:{yas}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Yaşını sayıyla gir!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("0-255 arası gir!");
            }
            catch (Exception)
            {                
                Console.WriteLine("Bir Hata Oluştu!");
            }





            Console.ReadKey();










        }
    }
}
