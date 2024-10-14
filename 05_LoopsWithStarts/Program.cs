using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStarts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ALT ALTA 10 YILDIZ OLUŞTURMA

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("*");
            }

            #endregion

            #region YAN YANA 10 YILDIZ OLUŞTURMA

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}

            #endregion

            #region YAN YANA 10 YILDIZ VE HER SATIRDA ALT ALTA 10 YILDIZ

            //for(int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("**********");
            //}

            #endregion

            #region DİK ÜÇGEN

            //for(int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine();
            //    for(int x = 0; x <= i; x++)
            //    {
            //        Console.Write("*");
            //    }
            //}

            #endregion

            #region TERS DİK ÜÇGEN

            //for(int i = 10; i >= 0; i--)
            //{
            //    Console.WriteLine();
            //    for (int x = 0; x <= i; x++)
            //    {
            //        Console.Write("*");
            //    }
            //}

            #endregion

            #region DİK VE TERS DİK ÜÇGEN

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int x = 1; x <= i; x++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 4; i >= 0; i--)
            //{
            //    for (int x = 0; x <= i; x++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region BAKLAVA DİLİMİ

            //int n = 5;
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n - 1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for(int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("");
            //}


            //for(int i = n - 1; i >= 1; i--)
            //{
            //    for(int j = n - 1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k<=2*i;k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion


            #region PİRAMİT

            //int n = 5;
            //for(int i = 1; i <= n; i++)
            //{
            //    for(int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region TERS PİRAMİT

            //int n = 5;
            //for(int i = n; i >= 1; i--)
            //{
            //    for(int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for(int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write('*');
            //    }
            //    Console.WriteLine("*");
            //}
                 
            #endregion
            
            
            Console.Read();
        }
    }
}
