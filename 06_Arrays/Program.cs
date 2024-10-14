using System;
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
            #region Temel dizi örnekleri

            //string[] colors = new string[4];
            //colors[0] = "Siyah";
            //colors[1] = "Sarı";
            //colors[2] = "Kırmızı";
            //colors[3] = "Beyaz";

            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //int[] numbers = new int[10];
            //numbers[0] = 1234;
            //numbers[1] =2232;
            //numbers[2] = 345;
            //numbers[3] = 423;
            //numbers[7] = 854;

            //string[] cities = { "prag", "roma", "atina", "ankara", "bursa" };
            //Console.WriteLine(cities[2]);

            #endregion

            #region Dizideki tüm elemanları listeleme

            //string[] colors = { "sarı", "kırmızı", "beyaz", "mavi", "yeşil", "turuncu", "pembe" };

            //for(int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //} 

            //int[] numbers = { 154, 2123, 3089, 4234, 5097, };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', '/', '*', '-' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArray = { 23, 235, 84, 53, 25, 261, 453, 51, 61, 11465, 61, 435 };
            //int number = myArray[0];
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > number)
            //    {
            //        number = myArray[i];
            //    }
            //}
            //Console.WriteLine(number);

            #endregion

            #region Dizi metodları

            //string[] persons = { "ali", "mert", "mehmet", "enes", "beyza", "beyza(stajyer)", "ilyas" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 45, 65, 23, 65, 23, 1, 86, 34 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 45, 65, 23, 65, 23, 1, 86, 34 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //string[] customers = { "ali", "buse", "ayşegül", "merve", "çınar", "kaya" };
            //int index = Array.IndexOf(customers, "merve");
            //Console.WriteLine(index);

            //int[] numbers = { 1245, 325442, 542634, 41345413, 514534, 63465426, 7123, 23454328 };
            //Console.WriteLine("Dizinin en büyük elemanı : " + numbers.Max());
            //Console.WriteLine("Dizinin en küçük elemanı : " + numbers.Min());

            #endregion

            #region Kullanıcıdan değer alma
            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. şehir ismini giriniz : ");
            //    var city = Console.ReadLine();
            //    cities[i] = city;
            //}
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------");
            //Console.WriteLine();
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine($"{i+1}. şehir : {cities[i]}");
            //}

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    sum+= numbers[i];
            //}
            //Console.WriteLine(sum);

            int[] numbers = { 21, 32, 33, 64, 35, 86, 27, 38, 19, 220 };
            Console.WriteLine("Çift sayılar");
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            Console.WriteLine("Tek sayılar");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            #endregion

            Console.Read();
        }
    }
}
