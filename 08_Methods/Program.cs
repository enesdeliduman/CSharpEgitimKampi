using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Methodlar
            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}

            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;

            //    Console.WriteLine(z);
            //}

            //Sum();


            #endregion


            #region Geriye değer döndürmeyen string parametreli metotlar

            //void WriteMethod(string CustomerName)
            //{
            //    Console.WriteLine(CustomerName);
            //}

            //WriteMethod("Mehmet Yıldırım");


            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri : " + name + " " + surName);
            //}

            //CustomerCard("mehmet", "yıldız");
            //CustomerCard("ayşegül", "kaya");


            #endregion

            #region Geriye değer döndürmeyen int parametreli metotlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    Console.WriteLine(number1 + number2 + number3);
            //}
            //Sum(23, 4, 2);

            #endregion

            #region Geriye değer döndüren metotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}

            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surName = "Kaya";

            //    return name + " " + surName;
            //}

            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye değer döndüren string parametreli metotlar

            //string CountryCard(string countrName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke : "+countrName + " - Başkent : " + capital + " - Bayrak rengi : " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke adını giriniz : ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti giriniz : ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak rengini giriniz : ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));
            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı - beyaz"));

            #endregion

            #region Geriye değer döndüren int parametereli metotlar

            //int Sum(int number1,int number2)
            //{
            //    int result =number1+ number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(3, 5));
            //Console.WriteLine(Sum(3235, 565));
            //Console.WriteLine(Sum(7875, 5123));

            #endregion

            #region Örnek Uygulama
            //string ExamResult(string student,int exam1,int exam2,int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3)/3;
            //    if (result >= 50)
            //    {
            //        return "Öğrencini sınavı geçti";
            //    }
            //    else
            //    {
            //        return "Öğrencini sınavı geçemedi";
            //    }
            //}

            //Console.WriteLine(ExamResult("Enes DELİDUMAN", 54, 52, 63));
            //Console.WriteLine(ExamResult("Ayşe Yerci", 84, 12, 98));
            #endregion

            Console.Read();
        }
    }
}
