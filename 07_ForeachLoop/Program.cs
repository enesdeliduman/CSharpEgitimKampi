using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach döngüsü

            //string[] cities =
            //{
            //    "milano","ankara","budapeşte","ankara","istanbul","varşova"
            //};

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 2345, 64524, 546, 23, 54451534, 55246, 62, 41554, 7565, 4653732, 544, 1 };
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numbers = { 2345, 64524, 546, 23, 54451534, 55246, 62, 41554, 7565, 4653732, 544, 1 };
            //foreach (int number in numbers) {
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 2345, 64524, 546, 23, 54451534, 55246, 62, 41554, 7565, 4653732, 544, 1 };
            //int total = 0;
            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total.ToString());

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "merhaba";
            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion


            #region Örnek sınav sistemi uygulaması

            Console.WriteLine("******* C# Eğitim Kampı Sınav Uygulaması *******");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("------------------------------");

            Console.Write("Sınıfınızda kaç öğrenci var : ");
            int studentCount = int.Parse(Console.ReadLine());

            Console.WriteLine("------------------------------");

            string[] studentNames = new string[studentCount];
            double[] studentExamAverages = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz : ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz : ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;
                }
                studentExamAverages[i] = totalExamResult / 3;
            }

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması : {studentExamAverages[i]}");

                if (studentExamAverages[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten geçemedi");
                }
            }

            #endregion
            Console.Read();
        }
    }
}
