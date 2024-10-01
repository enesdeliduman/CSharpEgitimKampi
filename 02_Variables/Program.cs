using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Variable

            //double number = 4.85;
            //Console.WriteLine(number);


            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();
            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("----- Elma birim fiyati: " + applePrice);
            //Console.WriteLine("----- Portakal birim fiyati: " + orangePrice);
            //Console.WriteLine("----- Cilek birim fiyati: " + strawberryPrice);
            //Console.WriteLine("----- Patates birim fiyati: " + potatoPrice);
            //Console.WriteLine("----- Domates birim fiyati: " + tomatoPrice);

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("");
            //Console.WriteLine("Elmanin toplam fiyati: " + appleTotalPrice);
            //Console.WriteLine("Portakalin toplam fiyati: " + orangeTotalPrice);
            //Console.WriteLine("Cilegin toplam fiyati: " + strawberryTotalPrice);
            //Console.WriteLine("Patatesin toplam fiyati: " + potatoTotalPrice);
            //Console.WriteLine("Domatesin toplam fiyati: " + tomatoTotalPrice);

            //double totalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine("");
            //Console.WriteLine("Toplam fiyat: " + totalPrice.ToString());

            #endregion

            #region Char Variable

            //char symbol = 'a';
            //Console.WriteLine(symbol);

            #endregion

            #region Data Input From Keyboard - String

            //Console.WriteLine("***** CSHARP HAVA YOLLARI YOLCU BİLGİSİ *****");
            //Console.WriteLine("");
            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;


            //Console.Write("Yolcu adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu tc: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine("");

            //Console.WriteLine("----------");

            //Console.WriteLine("Yolcu: " + passengerName + " " + passengerSurname + " " + passengerDistrict + "/" + passengerCity + " " + passengerAge + " " + passengerIdentityNumber);

            #endregion

            #region Data Input From Keyboard - Int and Convert

            //int shoesPrice, computerPrice, chairPrice, tvPrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen ayakkabı adedini giriniz");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen bilgisayar adedini giriniz");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen sandalye adedini giriniz");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen televizyon adedini giriniz");
            //tvCount = int.Parse(Console.ReadLine());


            //var totalPrice = (shoesPrice * shoesCount) + (computerCount * computerPrice) + (chairCount * chairPrice) + (tvPrice * tvCount);

            //Console.WriteLine();
            //Console.WriteLine("Ödemeniz gereken toplam tutar: " + totalPrice);

            #endregion

            #region Data Input From Keyboard - Double 

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen birinci sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen ikinci sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen üçüncü sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.Write(result);

            #endregion

            #region Data Input From Keyboard - Char

            char gender;
            Console.Write("Lütfen cinsiyet seçiniz: ");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Seçtiğiniz cinsiyet: "+gender);

            #endregion

            Console.Read();
        }
    }
}
