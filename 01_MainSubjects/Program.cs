using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
       

        static void Main(string[] args)
        {

            #region Yazdirma Komutlari

            // Console.WriteLine("Merhaba Dunya");
            // Console.Write("Selam");


            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1- Corbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soguk Baslangiclar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlilar");
            //Console.WriteLine("6-Icecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");





            #endregion


            #region String Degiskenler

            // string
            // Degisken_turu degisken_adi;

            //string name;
            //name = "Serhat";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Serhat";
            //customerSurname = "BASBOSTANCI";
            //customerPhone = "+90 500 000 00 00";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadikoy";
            //city = "Istanbul";

            //Console.WriteLine("**** Rezervasyon Karti ****");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------------------------------------");
            //Console.WriteLine("Musteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("Iletisim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("----------------------------------------------------------");

            //Console.WriteLine();

            //customerName = "Aysegul";
            //customerSurname = "Kaya";
            //customerPhone = "+90 400 300 00 00";
            //customerEmail = "test@gmail.com";
            //district = "Selcuk";
            //city = "Izmir";



            //Console.WriteLine("----------------------------------------------------------");
            //Console.WriteLine("Musteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("Iletisim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("----------------------------------------------------------");

            #endregion

            #region Int Degiskenler

            // int 

            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menu Fiyati ****");
            Console.WriteLine();
            Console.WriteLine("----Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("----Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("----Kola: " + cokePrice + " TL");
            Console.WriteLine("----Limonata: " + lemonadePrice + " TL");
            Console.WriteLine("----Kizartma: " + friesPrice+ " TL");
            Console.WriteLine("----Su: " + waterPrice + " TL");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menu Fiyati ****");

            Console.WriteLine();

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;


            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;



            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Hamburger Tutari: " + totalHamburgerPrice + " TL");
            Console.WriteLine("Pizza Tutari: " + totalPizzaPrice + " TL");
            Console.WriteLine("Kizartrma Tutari: " + totalFriesPrice + " TL");
            Console.WriteLine("Kola Tutari: " + totalCokePrice + " TL");
            Console.WriteLine("Limonata Tutari: " + totalLemonadePrice + " TL");
            Console.WriteLine("Su Tutari: " + totalWaterPrice + " TL");

            Console.WriteLine();

            int totalPrice = totalCokePrice + totalWaterPrice + totalLemonadePrice + totalHamburgerPrice + totalPizzaPrice + totalFriesPrice;

            Console.WriteLine("Toplam Odenecek Tutar: " + totalPrice + " TL");


            


            #endregion









            Console.Read();







        }
    }
}




// Yazdirma komutlari



