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
            #region If Else
            //Console.WriteLine("Lütfen şifreyi giriniz:");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre doğru!");
            //}
            //else 
            //{
            //    Console.WriteLine("Şifre yanlış");            
            //}

            //string capital, country;
            //Console.Write("Başkenti giriniz:");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi giriniz:");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{ //büyük harfle yazarsan mesela doğru algılamayacak çünkü küçük harfle kontrol ekledik su an
            //    Console.WriteLine("veriler doğru");
            //}
            //else
            //{
            //    Console.WriteLine("hatalı bilgi");


            //}

            //int number;
            //Console.Write("Sayi giriniz:");
            //number=int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı doğru!");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı hatalı!");
            //}

            //int exam1, exam2, exam3, average;
            //string result="Hata"; // ilk değere hiçbir şey girmezsen bunu yazsın ilk değeri ya burda ya ifte vermen gerek yoksa hata alırsın çünkü resultın ilk değeri olmazsa null dönecek

            //Console.Write("Sınav1:");
            //exam1=int.Parse(Console.ReadLine());
            //Console.Write("Sınav2:");
            //exam2=int.Parse(Console.ReadLine());
            //Console.Write("Sınav3:");
            //exam3=int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların Ortalaması:" + average);

            //if(average>0 & average <= 50)
            //{
            //    result = "Sonuç vasat";
            //}
            //if(average>50 & average <= 70)
            //{
            //    result = "Sonuç orta";
            //}
            //if(average>70 & average <= 84)
            //{
            //    result = "Sonuç iyi";
            //}
            //if (average > 84)
            //{
            //    result = "Sonuç çok iyi";
            //}
            //Console.WriteLine(result); 


            //string city;
            //Console.Write("Lütfen şehir girişi yapınız:");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")

            //    {
            //        Console.Write("şehir mevcut");
            //    }
            //else
            //    {
            //    Console.Write("şehir mevcut değil");

            //    }


            //Console.Write("Lütfen kullanıcı adını giriniz:");
            //string username=Console.ReadLine();

            //if (username != "admin")
            //{
            //    Console.Write("Bu kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.Write("Hoş geldiniz!");
            //}
            //Console.Read();

            #endregion
            #region Mod İşlemleri
            //bölümünden kalanı bulmak % ile ifade ediliyor
            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.Write(result);

            //Console.Write("Lütfen 1.sayıyı giriniz:");
            //int number1= int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.sayıyı giriniz:");
            //int number2= int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.Write("1.sayının 2.sayıya bölümünden kalan: " + result);

            //Console.Write("Lütfen sayıyı giriniz:");
            //int number= int.Parse(Console.ReadLine());

            //if(number % 2 == 0)
            //{
            //    Console.Write("Sayı çifttir");
            //}
            //else
            //{
            //    Console.Write("Sayı tektir.");
            //}
            #endregion
            #region Char Değişkenler ile Karar Yapıları
            //char team;
            //Console.Write("Lütfen takım sembolünü giriniz:");
            //team=char.Parse(Console.ReadLine());   

            //if(team =='g' | team== 'G')
            //{
            //    Console.Write("Galatasaray");
            //}
            //if(team =='f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}
            //if(team =='b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}
            //else
            //{
            //    Console.Write("Takım bulunamadı!");
            //}
            #endregion
            #region Örnek Proje Uygulaması

            //Console.WriteLine("****** C# Eğitim Kampı Restorant ******");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine();


            //string menuItem;
            //Console.Write("Detayını görmek istediğiniz menüyü seçiniz:");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------Ana Yemekler------");
            //    Console.WriteLine("1-Fırında Somon");
            //    Console.WriteLine("2-Fasülye Pilav");
            //    Console.WriteLine("3-Karnabahar Yemeği");
            //    Console.WriteLine("------Ana Yemekler------");

            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------Çorbalar------");
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorbası");
            //    Console.WriteLine("------Çorbalar------");
            //    Console.WriteLine();

            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------Pizzalar------");
            //    Console.WriteLine("1-Ton Balıklı Pizza");
            //    Console.WriteLine("2-Çıtır Tavuklu Pizza");
            //    Console.WriteLine("------Pizzalar------");
            //    Console.WriteLine();

            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------İçecekler------");
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Karışık Meyve Suyu");
            //    Console.WriteLine("------İçecekler------");
            //    Console.WriteLine();

            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------Tatlılar------");
            //    Console.WriteLine("1-Profiterol");
            //    Console.WriteLine("2-Damla Sakızlı Muhallebi");
            //    Console.WriteLine("------Tatlılar------");
            //    Console.WriteLine();

            //}
            #endregion
            #region Switch-Case
            //karar yapılarında birden fazla şart kontrolü olabilir
            //switch kod bloğunun anahtarı, case ise bu anahtarın durumları
            //Console.Write("Lütfen Ay Girişi Yapınız:"); 
            //int monthNumber=int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.WriteLine("Ocak"); break;
            //    case 2: Console.WriteLine("Şubat"); break;
            //    case 3: Console.WriteLine("Mart"); break;
            //    case 4: Console.WriteLine("Nisan"); break;
            //    case 5: Console.WriteLine("Mayıs"); break;
            //    case 6: Console.WriteLine("Haziran"); break;
            //    case 7: Console.WriteLine("Temmuz"); break;
            //    case 8: Console.WriteLine("Ağustos"); break;
            //    case 9: Console.WriteLine("Eylül"); break;
            //    case 10: Console.WriteLine("Ekim"); break;
            //    case 11: Console.WriteLine("Kasım"); break;
            //    case 12: Console.WriteLine("Aralık"); break;
            //    default: Console.WriteLine("Hatalı veri girişi yaptınız!"); break;
            //}
            #endregion
            #region Basit Düzeyde Bir Switch Case Hesap Makinesi
            //int number1, number2,result;
            //char symbol;

            //Console.Write("1.sayıyı giriniz:");
            //number1=int.Parse(Console.ReadLine());
            //Console.Write("2. sayıyı giriniz:");
            //number2=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen yapmak istediğiniz işlemi giriniz:");
            //symbol=char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.Write("Toplama işlemi sonucunuz: " + result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.Write("Çıkartma işlemi sonucunuz: " + result);
            //        break;

            //    case '*':
            //        result = number1 * number2;
            //        Console.Write("Çarpma işlemi sonucunuz: " + result);
            //        break;

            //    case '/':
            //        result = number1 / number2;
            //        Console.Write("Bölme işlemi sonucunuz: " + result);
            //        break;
            //}
            #endregion

            Console.Read();
        }
    }
    }

