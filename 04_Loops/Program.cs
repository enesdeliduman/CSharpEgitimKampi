using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region FOR LOOP

            //int i;
            //for (i = 0; i <= 5; i++)
            //{
            //    Console.WriteLine("#CSsarpEgitimKampi");
            //}

            //for(int i = 0; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i < 50; i+=i)
            //{
            //    Console.WriteLine(i);
            //} 

            //Console.Write("Lütfen ekrana kaç kez yazılmasını istediğinizi giriniz: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 0; i <= finishValue; i++)
            //{
            //    Console.WriteLine(i + " " + "Yaşasın cumhuriyet!");
            //}

            #region LOOP USING WITH MAKING DECISION

            //for (int i = 1; i < 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalValue = 0;
            //for (int i = 0; i <= 10; i++)
            //{
            //    totalValue += i;
            //}

            //Console.WriteLine(totalValue);

            //int totalValue = 0;
            //for (int i = 1; i < 20; i++){
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //    }
            //}

            //Console.WriteLine(totalValue);

            //int count = 0;
            //for (int i = 1; i < 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            #endregion

            #region EXAMPLE PROJECT

            //int totalLoopValue = 24;
            //int totalBacterium = 1;

            //for (int i = 1; i <= totalLoopValue; i++)
            //{
            //    totalBacterium = totalBacterium * 2;
            //    Console.WriteLine(i + ". saatin sonunda: " + totalBacterium);
            //}
            //Console.WriteLine(totalBacterium);

            #endregion

            #endregion

            #region WHILE LOOP

            //int i = 0;
            //while (i <= 10)
            //{
            //    Console.WriteLine("Senden nefret ediyorum while");
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;

            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);

            #endregion

            #region EXAMPLE EXAM QUESTION

            //Console.Write("Sayıyı giriniz : ");
            //string number = Console.ReadLine();
            //int sum = 0;

            //for(int i = 0; i < number.Length; i++)
            //{
            //    sum += int.Parse(number[i].ToString());
            //}
            //Console.WriteLine(sum);

            Console.Write("Sayıyı giriniz : ");
            int number = int.Parse(Console.ReadLine());
            int ones, tens, hundreds;
            int sum = 0;

            ones = number % 10;
            hundreds = number / 100;
            tens = (number % 100) / 10;

            sum = ones + tens + hundreds;
            Console.WriteLine(sum);

            #endregion

            Console.Read();
        }
    }
}
