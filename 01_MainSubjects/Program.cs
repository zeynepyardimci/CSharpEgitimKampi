using System;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları

            //Console.WriteLine("Merhaba Dünya!");
            //Console.Write("Selam");

            //Console.WriteLine("***** Yemek kategorileri *****");
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek kategorileri *****");

            #endregion

            #region StringDeğişkenler

            //string
            //Değişken_türü değişken_adı;

            //string name;
            //name = "Zeynep";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "+90 500 400 30 20";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------------");
            //Console.WriteLine("Müşteri: "+ customerName + " "+ customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: "+ customerEmail);
            //Console.WriteLine("Adres: "+ district + "/" + city);
            //Console.WriteLine("------------------------------------------------");

            //Console.WriteLine();

            //customerName = "Ayşegül";
            //customerSurname = "Kaya";
            //customerPhone = "+90 400 300 80 70";
            //customerEmail = "test@gmail.com";
            //district = "Sapanca";
            //city = "Sakarya";

            //Console.WriteLine("------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("------------------------------------------------");





            #endregion

            #region Int Değişkenler

            //int
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokaPrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger Fiyatı: " + hamburgerPrice + " TL");
            Console.WriteLine("-----Kola Fiyatı: " + cokaPrice + " TL");
            Console.WriteLine("-----Su Fiyatı: " + waterPrice + " TL");
            Console.WriteLine("-----Kızartma Fiyatı: " + friesPrice + " TL");
            Console.WriteLine("-----Pizza Fiyatı: " + pizzaPrice + " TL");
            Console.WriteLine("-----Limonata Fiyatı: " + lemonadePrice + " TL");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatı ****");

            Console.WriteLine();
            int hamburgerCount;
            int cokaCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCokaPrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;

            hamburgerCount = 3;
            cokaCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokaPrice = cokaCount * cokaPrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + " TL");
            Console.WriteLine("Kola Tutarı: " + totalCokaPrice + " TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + " TL");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + " TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + " TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + " TL");

            Console.WriteLine();

            int totalPrice = totalCokaPrice + totalWaterPrice + totalLemonadePrice + totalHamburgerPrice + totalPizzaPrice + totalFriesPrice;

            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + " TL");




            #endregion




            Console.Read();
        }
    }
}




//Yazdırma Komutları