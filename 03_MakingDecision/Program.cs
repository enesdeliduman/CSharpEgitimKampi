using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If - Else
            //Console.Write("LÜtfen şifreyi giriniz: ");
            //string password = Console.ReadLine();
            //if (password == "root")
            //{
            //    Console.WriteLine("Şifre doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre yanlış");
            //}

            //string capital, country;
            //Console.Write("Başkenti giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi giriniz: A");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.Write("Veriler doğrulandı");
            //}
            //else
            //{
            //    Console.Write("Hatalı bilgi");
            //}

            //int number;
            //Console.WriteLine("Sayıyı giriniz");
            //number = int.Parse(Console.ReadLine());

            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı yanlış");

            //}

            //int exam1, exam2, exam3, average;
            //string result="Hata";

            //Console.Write("Sınav 1 : ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav 2 : ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav 3 : ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların ortalaması : " + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç orta";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç iyi";
            //}
            //if (average > 84)
            //{
            //    result = "Sonuç çok iyi";
            //}

            //Console.WriteLine(result);

            //string city;
            //Console.WriteLine("Lütfen şehir girişi yapınız");
            //city = Console.ReadLine();
            //if (city == "samsun" | city == "ankara" | city == "istanbul" | city == "trabzon")
            //{
            //    Console.WriteLine("Şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil");
            //}

            //Console.WriteLine("Lütfen kullanıcı adını giriniz");
            //string userName = Console.ReadLine();
            //if (userName != "admin")
            //{
            //    Console.WriteLine("Kullanıcı adı hatalı");
            //}
            //else
            //{
            //    Console.WriteLine("Hoşgeldiniz");
            //}
            #endregion

            #region Mod Operator

            //int number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen birinci sayıyı giriniz : ");
            //var number1=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen ikinci sayıyı giriniz : ");
            //var number2 = int.Parse(Console.ReadLine());

            //var result=number1%number2;

            //Console.WriteLine("Birinci sayının ikinci sayıya bölümünden kalan : " + result);


            //int number;
            //Console.Write("Lütfen sayıyı giriniz : ");
            //number = int.Parse(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine(number + "bir çift sayıdır");
            //}
            //else
            //{
            //    Console.WriteLine(number + " bir tek sayıdır");
            //}
            #endregion

            #region Decision Structures Witch Char Variables
            //char team;
            //Console.Write("Lütfen takım sembolünü giriniz : ");
            //team = char.Parse(Console.ReadLine());
            //if (team == 'g' | team == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //else if (team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //else
            //{
            //    Console.WriteLine("Takım bulunamadı");
            //}
            #endregion

            #region Exam Project
            //Console.WriteLine("***** CSharp Eğitim Kampı Restoran *****");
            //Console.WriteLine("");
            //Console.WriteLine("*----------------------------*");
            //Console.WriteLine("1-) Ana yemekler");
            //Console.WriteLine("2-) Çorbalar");
            //Console.WriteLine("3-) Pizzalar");
            //Console.WriteLine("4-) İçecekler");
            //Console.WriteLine("5-) Tatlılar");
            //Console.WriteLine("*----------------------------*");
            //Console.WriteLine("");

            //Console.Write("Lütfen detayını görmek istediğiniz menü numararsını giriniz");
            //var menuItem = Console.ReadLine();
            //if (menuItem == "1")
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine("*--------------* Ana yemekler *--------------*");
            //    Console.WriteLine("1-) Köri soslu tavuk");
            //    Console.WriteLine("2-) Kızartma tabağı");
            //    Console.WriteLine("3-) Kurufasulye pilav");
            //    Console.WriteLine("4-) Fırında somon");
            //    Console.WriteLine("5-) Patlıcan musakka");
            //    Console.WriteLine("*--------------* Ana yemekler *--------------*");
            //    Console.WriteLine("");
            //}
            //else if (menuItem == "2")
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine("*--------------* Çorbalar *--------------*");
            //    Console.WriteLine("1-) Mercimek");
            //    Console.WriteLine("2-) Ezogelin");
            //    Console.WriteLine("*--------------* Çorbalar *--------------*");
            //    Console.WriteLine("");
            //}
            //else if (menuItem == "3")
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine("*--------------* Pizzalar *--------------*");
            //    Console.WriteLine("1-) Akdeniz pizza");
            //    Console.WriteLine("2-) Margarita");
            //    Console.WriteLine("*--------------* Pizzalar *--------------*");
            //    Console.WriteLine("");
            //}
            //else if (menuItem == "4")
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine("*--------------* İçecekler *--------------*");
            //    Console.WriteLine("1-) Coco cola");
            //    Console.WriteLine("2-) Pepsi");
            //    Console.WriteLine("3-) Ayran");
            //    Console.WriteLine("*--------------* İçecekler *--------------*");
            //    Console.WriteLine("");
            //}
            //else if (menuItem == "5")
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine("*--------------* Tatlılar *--------------*");
            //    Console.WriteLine("1-) Baklava");
            //    Console.WriteLine("2-) Şekerpare");
            //    Console.WriteLine("2-) Sütlaç");
            //    Console.WriteLine("*--------------* Tatlılar *--------------*");
            //    Console.WriteLine("");
            //}
            #endregion

            #region Switch Case

            //Console.Write("Lütfen ay girişi yapınız");
            //int monthNumber = int.Parse(Console.ReadLine());
            //switch (monthNumber)
            //{
            //    case 1:
            //        Console.Write("Ocak");
            //        break;
            //    case 2:
            //        Console.Write("Şubat");
            //        break;
            //    case 3:
            //        Console.Write("Mart");
            //        break;
            //    case 4:
            //        Console.Write("Nisan");
            //        break;
            //    case 5:
            //        Console.Write("Mayıs");
            //        break;
            //    case 6:
            //        Console.Write("Haziran");
            //        break;
            //    case 7:
            //        Console.Write("Temmuz");
            //        break;
            //    case 8:
            //        Console.Write("Ağustos");
            //        break;
            //    case 9:
            //        Console.Write("Eylül");
            //        break;
            //    case 10:
            //        Console.Write("Ekim");
            //        break;
            //    case 11:
            //        Console.Write("Kasım");
            //        break;
            //    case 12:
            //        Console.Write("Aralık");
            //        break;
            //    default:
            //        Console.WriteLine("Hatalı giriş");
            //        break;
            //}

            #endregion

            #region Calculator with Switch Case
            //int number1, number2, result;
            //char symbol;

            //Console.Write("Birinci sayıyı giriniz : ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("İkinci sayıyı giriniz : ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen yapmak istediğiniz işlemi giriniz");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam : " + result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark : " + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım : " + result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm : " + result);
            //        break;
            //}
            #endregion
           
            Console.Read();
        }
    }
}
