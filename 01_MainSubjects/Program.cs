using System;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region WRİTE COMMANDS
            // Console.WriteLine("Hello World!");
            // Console.Write("Whatsup?");

            // Console.WriteLine("***** YEMEK KATEGORİLERİ *****");
            // Console.WriteLine("");
            // Console.WriteLine("1-) Çorbalar");
            // Console.WriteLine("2-) Ana yemekler");
            // Console.WriteLine("3-) Soğuk başlangıçlar");
            // Console.WriteLine("4-) Salatalar");
            // Console.WriteLine("5-) Tatlılar");
            // Console.WriteLine("6-) İçecekler");
            // Console.WriteLine("");
            // Console.WriteLine("***** YEMEK KATEGORİLERİ *****");
            #endregion

            #region VARIABLES

            // => variable_type variable_name

            #region STRING VARIABLE

            // string name;
            // name = "Enes";
            // Console.WriteLine(name);

            // string customerName;
            // string customerSurname;
            // string customerPhoneNumber;
            // string customerEmail, customerCity, customerDistrict;

            // customerName = "ENES";
            // customerSurname = "DELİDUMAN";
            // customerPhoneNumber = "+90 555 555 55 55";
            // customerEmail = "enesduman124@gmail.com";
            // customerCity = "Samsun";
            // customerDistrict = "Bafra";

            // Console.WriteLine("**** REZERVASYON KARTI ****");
            // Console.WriteLine("");
            // Console.WriteLine("------------------");
            // Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            // Console.WriteLine("İletişim: " + customerPhoneNumber);
            // Console.WriteLine("Email: " + customerEmail);
            // Console.WriteLine("Adres: " + customerDistrict + "/" + customerCity);
            // Console.WriteLine("------------------");

            // customerName = "Gökçe";
            // customerSurname = "Türkoğlu";
            // customerPhoneNumber = "+90 555 555 55 55";
            // customerEmail = "gokce@turkoglu.com";
            // customerCity = "Samsun";
            // customerDistrict = "Atakum";

            // Console.WriteLine("------------------");
            // Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            // Console.WriteLine("İletişim: " + customerPhoneNumber);
            // Console.WriteLine("Email: " + customerEmail);
            // Console.WriteLine("Adres: " + customerDistrict + "/" + customerCity);
            // Console.WriteLine("------------------");

            #endregion

            #region INT VARIABLE

            // int number = 24;
            // Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 40;
            int waterPrice = 10;
            int fricePrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 50;

            Console.WriteLine("**** Restoran Menüsü ****");
            Console.WriteLine("");
            Console.WriteLine("-----Kola: " + cokePrice + "TL");
            Console.WriteLine("-----Hamburger: " + hamburgerPrice + "TL");
            Console.WriteLine("-----Su: " + waterPrice + "TL");
            Console.WriteLine("-----Pizza: " + pizzaPrice + "TL");
            Console.WriteLine("-----Kızartma: " + fricePrice + "TL");
            Console.WriteLine("-----Limonata: " + lemonadePrice + "TL");

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friceCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice = 0;
            int totalCokePrice = 0;
            int totalWaterPrice = 0;
            int totalFricePrice = 0;
            int totalPizzaPrice = 0;
            int totalLemonadePrice = 0;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friceCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFricePrice = friceCount * fricePrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;

            Console.WriteLine("");
            Console.WriteLine("Hamburger tutarı: " + totalHamburgerPrice + "TL");
            Console.WriteLine("İçecek: " + totalCokePrice + "TL");
            Console.WriteLine("Su: " + totalWaterPrice + "TL");
            Console.WriteLine("Kızartma: " + totalFricePrice + "TL");
            Console.WriteLine("Pizza: " + totalPizzaPrice + "TL");
            Console.WriteLine("Limonata: " + totalLemonadePrice + "TL");

            int totalPrice = totalHamburgerPrice + totalCokePrice + totalFricePrice + totalPizzaPrice + totalLemonadePrice + totalWaterPrice;
            Console.WriteLine("");
            Console.WriteLine("Toplam fiyat: " + totalPrice);
            #endregion

            #endregion

            Console.Read();
        }
    }
}