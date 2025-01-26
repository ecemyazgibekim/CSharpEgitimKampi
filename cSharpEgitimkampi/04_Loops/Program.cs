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
            #region For Döngüsü
            //Programlamada toplamada mesela her sayının üstüne bir sonraki eklenerek devam edilir
            //1,2,3,4,5
            //1+2=3+3=6+4=10+5=15 şeklinde

            //For(x;y;z)
            //x:başlangıç,  y: bitiş , z: artış veya azalış

            //debug için break point konulu ve f11 ile ilerlenir
            //int i;
            //for (i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //int i;
            //for (i = 0; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i <= 50; i+=3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi giriniz:");
            //int finishValue= int.Parse(Console.ReadLine());

            //for (int i = 1;  i <= finishValue;  i++) {
            //    Console.WriteLine("Yaşasın cumhuriyet!");
            //}
            #endregion
            #region For Döngüsü ile Karar Yapıları
            //5 e tam bölünen sayılar gibi örnekler
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalvalue = 0;
            //for(int i=1; i<=10; i++)
            //{
            //    totalvalue += i;
            //}
            //Console.WriteLine(totalvalue);


            //int totalValue = 0;
            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //    }

            //}
            //Console.WriteLine(totalValue);
            //1-50 7 ye tam bölünen kaç sayı var
            //int count = 0;
            //for (int i = 1; i < 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}
            //    Console.WriteLine(count);


            //bir bakteri türü her saatin sonunda kendini ikiye bölerek çoğalıyor
            //yeni oluşan bakteriler de her saatin sonunda 2 ye bölünerek çoğalıyor
            //24 saatin sonunda bu ortamda kaç bakteri olacak
            //for bizim saatimizi gösterecek aslında

            //int bacterium=1;
            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ".Saatin Sonunda:" + bacterium);
            //}

            #endregion

            #region While Döngüsü
            //While - şart sağlandığı müddetçe anlamına geliyor
            //while(şart)
            //{
            //işlemler
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba döngüler");
            //    i++;            
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
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
            #region Örnek Sınav Sorusu
            //klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız
            Console.Write("Sayıyı giriniz:");
            int number=int.Parse(Console.ReadLine());
            int ones, tens, hundreds;
            int sum=0;

            ones = number % 10;
            tens = (number % 100) / 10;
            hundreds = number / 100;

            Console.WriteLine(ones);
            Console.WriteLine(tens);
            Console.WriteLine(hundreds);
            sum = ones + tens + hundreds;
            Console.WriteLine(sum);



            #endregion
            Console.Read();
        }
    }
}
