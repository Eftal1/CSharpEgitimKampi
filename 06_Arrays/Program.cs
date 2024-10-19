﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region temelDiziOrnekleri
            // aynı veri tipindeki çok sayıda veriyi bir arada tutmak için kullanılan yapılardır.
            //2.6.8
            //sarı,kırmızı,mavi,turuncu,beyaz
            //adana, ankara,istanbul, bursa

            // DeğişkenTürü [] DiziAdı = new DeğişkenTürü[ElamanSayısı]

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];

            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[4]);

            //int[] numbers = new int[10];

            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;

            //Console.WriteLine(numbers[7]);

            //string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };
            //Console.WriteLine(cities[2]);

            #endregion

            #region DizidekiTumElemanlariListeleme
            //string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] number = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };

            //for (int i = 0; i < number.Length; i++)
            //{
            //    if (number[i] % 3 == 0)
            //    {
            //        Console.WriteLine(number[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };
            //for(int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //Dizideki En Büyük Elemanı Bulma

            //int[] myArray = { 45, 85, 95, 41, 25, 635, 789, 86, 100 };

            //int maxNumber = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            //string[] persons = { "ali", "ahmet", "ayşe", "buse", "cem", "deniz" };
            //Console.WriteLine(persons.Length);

            //Diziyi Küçükten Büyüğe Sıralama
            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Sort(numbers);
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //Diziyi Tersten Sıralama
            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}




            #endregion

            #region DiziMetotları

            //string[] customers = { "Ali", "Buse", "Ayşegül", "Çınar", "Merve", "Kaya" };

            //int index = Array.IndexOf(customers, "Merve");
            //Console.WriteLine(index);

            //int[] numbers = { 45, 85, 96, 63, 74, 10, 25, 22, 36 };
            //Console.WriteLine("Dizinin En Büyük Elemanı: " + numbers.Max() + "Dizinin En Küçük Elamanı: " + numbers.Min());



            #endregion

            #region KullanicidanDegerAlma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lüfen {i + 1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();

            //}
            //Console.WriteLine();
            //Console.WriteLine("-----------------------");
            //for (int i = 0;i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            //int[] numbers = { 21, 42, 33, 54, 55, 66, 897, 748, 399, 2200 };
            //Console.WriteLine("Çift Sayılar");
            //Console.WriteLine();
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine("--------------");
            //Console.WriteLine("Tek Sayılar");
            //Console.WriteLine();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            #endregion
            //Console.Read();
        }
    }
}
