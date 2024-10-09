using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Kütüphanelerin yer aldığı blok.

namespace _01_MainSubject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region YazdirmaKomutları
            //Console.Write("Hello World"); //Write imleci en sağa atar
            //Console.WriteLine("Selam"); //WriteLine ise imleci alt satıra indirir.
            // //Tuşa basana kadar yazıyı ekranda tutar.

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");

            #endregion

            #region StringDegiskenler

            //String Degiskenler (alfabetik türde verileri tutar)
            //Degisken_turu degisken_adi;
            //string name;
            //name = "Eftal";
            //Console.Write(name);

            //string customerName; 
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city; //Bir satırda birden fazla değişken tanımlanabilir.

            //customerName = "Ali ";
            //customerSurname = "Çınar";
            //customerPhone = "+90 500 000 11 11";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";
            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("-------------------------------");

            //Console.WriteLine();

            //customerName = "Ayşegül ";
            //customerSurname = "Kaya";
            //customerPhone = "+90 400 300 70 80";
            //customerEmail = "test@gmail.com";
            //district = "Başiskele";
            //city = "Kocaeli";
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("-------------------------------");

            #endregion

            #region IntDegiskenler
            //Tam Sayı türündeki değişkenler

            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 45;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("***** Restoran Menü Fiyatı *****");
            Console.WriteLine();
            Console.WriteLine("----Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("----Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("----Kola: " + cokePrice + " TL");
            Console.WriteLine("----Limonata: " + lemonadePrice + " TL");
            Console.WriteLine("----Kızartma: " + friesPrice + " TL");
            Console.WriteLine("----Su: " + waterPrice + " TL");
            Console.WriteLine();
            Console.WriteLine("**** Restoren Menü Fiyatı");

            Console.WriteLine();

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHambugerPrice;
            int totalFriesPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHambugerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalPizzaPrice = pizzaCount * pizzaCount;
            totalLemonadePrice =lemonadeCount * lemonadePrice;
            totalFriesPrice = friesCount * friesPrice;

            Console.WriteLine("------------------------------");
            Console.WriteLine("Hambuger Tutarı: " + totalHambugerPrice + " TL");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + " TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + " TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + " TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + " TL");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + " TL");

            Console.WriteLine();

            int totalPrice = totalHambugerPrice +  totalCokePrice + totalWaterPrice + totalPizzaPrice + totalLemonadePrice + totalFriesPrice;

            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + " TL");
         

            #endregion

            Console.Read();


        }
    }
}



