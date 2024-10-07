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
            //    double number; //float da kullanılır ondalıklı sayılar için ancak double'a göre daha kısıtlıdır. 
            //    number = 4.87;
            //    Console.WriteLine(number);

            //    Console.Read();
            //


            //Console.WriteLine("*****Fiyat Listesi*****");

            //double applePrice, tomatoPrice, patatoPrice, lemonPrice;

            //applePrice = 22.90;
            //tomatoPrice = 12.35;
            //patatoPrice = 10.52;
            //lemonPrice = 23.20;

            //Console.WriteLine("Elma Birim Fiyatı = " + applePrice + " TL");
            //Console.WriteLine("Domates Birim Fiyatı = " + tomatoPrice + " TL");
            //Console.WriteLine("Patates Birim Fiyatı = " + patatoPrice + " TL");
            //Console.WriteLine("Limon Birim Fiyatı = " + lemonPrice + " TL");

            //double appleGram, tomatoGram, patatoGram, lemonGram;

            //appleGram = 1.225;
            //tomatoGram = 2.345;
            //patatoGram = 3.21;
            //lemonGram = 1.000;

            //double appleTotalPrice = appleGram * applePrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;
            //double potatoTotalPrice = patatoGram * patatoPrice;
            //double lemonTotalPrice = lemonGram * lemonPrice;
            //Console.WriteLine();

            //Console.WriteLine("Elmanın Fiyatı = " + applePrice + " Alınan Kilo= " + appleGram + "  Toplam Fiyat = " + appleTotalPrice);
            //Console.WriteLine("Patatesin Fiyatı = " + patatoPrice + " Alınan Kilo= " + patatoGram + "  Toplam Fiyat = " + potatoTotalPrice);
            //Console.WriteLine("Domatesin Fiyatı = " + tomatoPrice + " Alınan kilo = " + tomatoGram + "  toplam fiyat =" + tomatoTotalPrice);
            //Console.WriteLine("Limonun Fiyatı = " + lemonPrice + " Alınan kilo = " + lemonGram + "  toplam fiyat =" + lemonTotalPrice);

            //Console.WriteLine();

            //double totalprice;
            //totalprice = lemonTotalPrice + appleTotalPrice + tomatoTotalPrice + potatoTotalPrice;
            //Console.WriteLine("Toplamda ödenecek tutar = " + totalprice);



            //Console.Read();


            #endregion

            #region Char Değişkenler
            //// tek tırnak ' ile gösterilir.

            //char symbol;
            //symbol= 'A';
            //Console.WriteLine(symbol);


            #endregion

            #region Klavyeden Veri Girişleri (String Değişkenler)

            //Console.WriteLine("*****YILMAZ HAVA YOLLARI YOLCU BİLGİLERİ EKRANI*****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerAge, passengerCity, passengerIDNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("Yolcu Yaşı: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu Şehri: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Kimlik No: ");
            //passengerIDNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("YOLCU BİLGİLERİ:");
            //Console.WriteLine("Yolcu Ad Soyad = " + passengerName + " " + passengerSurname);
            //Console.WriteLine("Yolcu Şehri = " + passengerCity);
            //Console.WriteLine("Yolcu kimlik = " + passengerIDNumber);

            //Console.Read();



            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler (Int Değişkenler)

            ////Parse dönüşüm metodudur. mesela int.parse() stringi integera çevirir.

            //int shoesPrice, skirtPrice, tshirtPrice, bagPrice;
            //shoesPrice = 1200;
            //skirtPrice = 350;
            //tshirtPrice = 235;
            //bagPrice = 1110;

            //int shoesCount, skirtCount, tshirtCount, bagCount;
            //Console.Write("Lütfen aldığınız ayakkabı sayısını girin: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Aldığınız etek sayısını girin: ");
            //skirtCount = int.Parse(Console.ReadLine());

            //Console.Write("Aldğınız T-shirt sayısını girin: ");
            //tshirtCount = int.Parse(Console.ReadLine());

            //Console.Write("Aldığınız çanta sayısını girin: ");
            //bagCount = int.Parse(Console.ReadLine());

            //Console.WriteLine();
            //int totalPrice = shoesCount * shoesPrice + skirtCount * skirtPrice + tshirtCount * tshirtPrice + bagCount * bagPrice;

            //Console.WriteLine("Ödemeniz gereken toplam tutar =" + totalPrice);

            //Console.Read();


            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri (Double Değişkenler)

            //double exam1, exam2, exam3, result;

            //Console.Write("1. Sınav notunuzu giriniz: ");
            //exam1= double.Parse(Console.ReadLine());

            //Console.Write("2. Sınav notunuzu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("3. Sınav notunuzu giriniz: "); //bu şekilde çıktı aldığımızda , kullanacağız. kodu yazarken . da olur.
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine("Ders Ortalamanız; " + result);

            #endregion

            #region Klavyeden Karakter Girişleri (Char Değişkenler)

            //char gender;  //char 'da sadece 1 tane karakter olmalı.
            //Console.Write("LÜtfen cinsiyet seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz cinsiyet: " + gender);

            #endregion
        }
    }
}
