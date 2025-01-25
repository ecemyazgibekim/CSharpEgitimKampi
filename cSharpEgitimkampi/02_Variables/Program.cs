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
            #region Double Değişkenler
            //Console.OutputEncoding = System.Text.Encoding.Unicode; //TL sembolü için
            //Console.WriteLine("**** Fiyat Listesi****");
            //Console.WriteLine();
            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("--- Elma Birim Fiyatı :" + applePrice + "₺");
            //Console.WriteLine("--- Portakal Birim Fiyatı :" + orangePrice + "₺");
            //Console.WriteLine("--- Çilek Birim Fiyatı :" + strawberryPrice + "₺");
            //Console.WriteLine("--- Patates Birim Fiyatı :" + potatoPrice + "₺");
            //Console.WriteLine("--- Domates Birim Fiyatı :" + tomatoPrice + "₺");

            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice=strawberryGram * strawberryPrice;
            //double potatoTotalPrice=potatoGram * potatoPrice;
            //double tomatoTotalPrice= tomatoGram * tomatoGram;

            //Console.WriteLine("Alınan Ürün Elma- " + "Birim Fiyat: " + applePrice + "-Gramaj: " + appleGram + "-Toplam Tutar:" + appleTotalPrice);
            //Console.WriteLine("Alınan Ürün Portakal- " + "Birim Fiyat: " + orangePrice + "-Gramaj: " + orangeGram + "-Toplam Tutar:" + orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün Çilek- " + "Birim Fiyat: " + strawberryPrice + "-Gramaj: " + strawberryGram + "-Toplam Tutar:" + strawberryTotalPrice);
            //Console.WriteLine("Alınan Ürün Patates- " + "Birim Fiyat: " + potatoPrice + "-Gramaj: " + potatoGram + "-Toplam Tutar:" + potatoTotalPrice);
            //Console.WriteLine("Alınan Ürün Domates- " + "Birim Fiyat: " + tomatoPrice + "-Gramaj: " + tomatoGram + "-Toplam Tutar:" + tomatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + tomatoTotalPrice + potatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine("Alışveriş Toplam Tutarı:" + shoppingTotalPrice +"TL");
            //Console.Read();


            #endregion
            #region Char Değişkenler 
            //// string tanımlarken ""
            ////char tanımlarken ''
            //char symbol;
            //symbol = 'e';
            //Console.WriteLine(symbol);
            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler
            //Console.WriteLine("**** Charp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı:");
            //passengerName= Console.ReadLine();

            //Console.Write("Yolcu Soyadı:");
            //passengerSurname= Console.ReadLine(); // klavyeden girilen değeri passengerName üzerine yazacak

            //Console.Write("İlçe Bilgisi:");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi :");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaşı:");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No:");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("----------------------------");
            //Console.WriteLine("Yolcu Adı-Soyadı:" + passengerName + "-" + passengerSurname + " Yolcu Yaşı:" + passengerAge+ " İlçe/Şehir Bilgisi: "+  passengerDistrict+ "/" + passengerCity + " Yolcu Kimlik Numarası: " + passengerIdentityNumber);

            #endregion

            #region Klavyeden Tam Sayı Girişi ve Dönüşümler
            //consoledan girdiklerini string kabul ediyor c# 
            //parse ile dönüşüm yapman gerekiyor diğer veri tiplerini kullanmak için
            //int shoesPrice, computerPrice, chairPrice, tvPrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;
            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz:");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz:");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz:");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz:");
            //tvCount = int.Parse(Console.ReadLine());



            //int totalPrice = shoesCount * shoesPrice + computerPrice * computerCount + chairPrice * chairCount + tvCount * tvPrice;
            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice + "TL'dir.");
            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri
            //double exam1, exam2, exam3, result;
            //Console.Write("Lütfen 1. sınav notunuzu giriniz: ");
            //exam1=double.Parse(Console.ReadLine());


            //Console.Write("Lütfen 2. sınav notunuzu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. sınav notunuzu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: "+ result);

            #endregion

            #region Klavyeden Karakter Girişleri
            //karakter girişi olacağı için E veya K yazabilirsin ee yazınca mesela hata verecek
            char gender;
            Console.Write("Lütfen cinsiyet seçiniz(E / K):" );
            gender= char.Parse( Console.ReadLine() );
            Console.WriteLine("Seçtiğiniz Cinsiyet:" + gender);

            #endregion
            Console.Read();
        }
    }
}
