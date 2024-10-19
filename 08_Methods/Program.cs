using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Serialization;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region VoidMetotlar

            //Bir metot için () sonuna konur.
            //Metotlar ikiye ayrılır.
            //Geriye Değer Döndermeyen Metotlar
            //ör: customer --> Listele, ekle, sil, güncelle
            //Void olarak tanımlanır. 

            //void customerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}

            //customerList();
            //customerList();
            //customerList();
            //customerList();
            //customerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();

            #endregion

            #region GeriyeDegerDondurmeyenStringParametreliMetotlar

            //void writeMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //writeMethod("Mehmet Yıldırım");

            //void customerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surName);

            //}
            //customerCard("Mehmet", "Yıldız");
            //customerCard("Ayşegül", "Kaya");

            #endregion

            #region GeriyeDegerDondurmeyenINTParametreliMetotlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //Sum(4, 5, 6);


            #endregion

            #region GeriyeDegerDondurenMetotlar

            //string customerName()
            //{
            //    return "Buse Yıldız";
            //}

            //customerName();

            //string studentCard()
            //{
            //    string name = "Ali";
            //    string surName = "Kaya";

            //    return name +" "+ surName;

            //}

            //Console.WriteLine(studentCard());

            #endregion

            #region GeriyeDegerStringDondurenParametreliMetotlar

            //string CountryCard(string countryName, string capital, string flagClolor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " - Başkent: " + capital + "- Bayrak Rengi: " + flagClolor;
            //    return cardInfo;

            //}
            //string x, y, z;
            //Console.Write("Ülke Adını Giriniz: ");
            //x = Console.ReadLine();


            //Console.Write("Başkenti Giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Rengi Giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı-Beyaz"));


            #endregion

            #region GeriyeDegerDondurenINTParametleriMetotlar

            //int Sum( int number1, int number2 )
            //{
            //    int result = number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(45, 98));
            //Console.WriteLine(Sum(36, 25));
            //Console.WriteLine(Sum(44, 36));
            //Console.WriteLine(Sum(14, 20));




            #endregion

            #region OrnekUygulama
            //string examResult (string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return student + " İsimli Öğrenci Sınavı Geçti " + "Ortalama: " + result;
            //    }
            //    else
            //    {
            //        return student + " İsimli Öğrenci Başarısız Oldu " + "Ortalama: " + result;
            //    }

            //}
            //Console.WriteLine(examResult("Ali", 25, 41, 85));
            //Console.WriteLine(examResult("Ayşe", 36, 88, 33));

            #endregion 
            Console.Read();
        }
    }
}
