using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region ForeachDongusu

            ////Foreach(1;2;3;4)
            //// 1: Değişken Türü
            //// 2: Değişken Adı
            //// 3: In
            ////4:Liste, Koleksiyon, Dizi

            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };

            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //int total = 0;

            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);



            #endregion

            #region Listeler

            //List<int> numbers = new List<int>()
            //{
            //    1,2, 3, 4, 5, 8
            //};

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "Merhaba";
            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}



            #endregion

            #region OrnekSinavSistemi

            //Klavyeden Öğrenci İsmi, Notları ve Ortalamasını Alalım

            //Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            ////Sınıftaki Öğrenci Sayısını Kullanıcıdan Alma
            //Console.WriteLine("-----------------------------");
            //Console.Write("Sınıfınızda Kaç Öğrenci Var: ");

            //int studentCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("-----------------------------");

            ////Öğrenci isimleri ve not ortalamalarını saklayacak diziler
            //string[] studentNames = new string[studentCount];
            //double[] studenExamAvg = new double[studentCount];

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
            //    studentNames[i] = Console.ReadLine();

            //    double totalExamResult = 0;

            //    //Her Öğrenci İçin 3 sınav not girişi

            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz: ");
            //        double value = double.Parse(Console.ReadLine());
            //        totalExamResult += value; //notları topluyoruz.

            //    }
            //    Console.WriteLine();
            //    studenExamAvg[i] = totalExamResult / 3;
            //}

            ////Sınav Ortalamaları
            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studenExamAvg[i]}");

            //    //Öğrencilerin ortalaması ve geçip kalma durumları
            //    if (studenExamAvg[i] >= 50)
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");
            //    }
            //    Console.WriteLine("-----------------------------");
            //}



            #endregion

            //Console.Read();
        }
    }
}
