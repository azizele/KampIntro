using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegerVeReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!!");
            


            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 ?? 30 olur çünkü değer tip olarak çalışır sayi1 sayi2 nin
            //değerini alır birincisinde
            //sayi1 10 iken diğerinde ise değerini değiştirip sayi2 yapıyoruz

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] değeri 100 olur yanlış 999 olur çünkü sayılar1[0] referansını değiştirdik.
            //Git Changes Wiew dan açabilirsin 

            //acıklama 
            // sayilar veri tipi int double float decimal bool == bunlar değer tiplerdir 
            //array class interface == bunlar referans tiplerdir
            // bilgisayarda stack ve heap bölgesi var ,, int dediğin zaman değer tipler stack bölgesinde oluşur sayi1 değeri eşittir 10 diye okuruz
            //referans tipler değer tiplerden farklı olarak heap bölgesinde oluşur.
            //int[] sayilar1 dediğimizde stack bölümünde bu oluşur ve karşısında new yaptığımız an
            //referansı heap bölgesinde yazılır {10,20,30,} şeklinde
            // heap bölgesinde bir 101 numaları bölgede tutulur gibi düşünebiliriz. new anlamıda burda heap bölgesinde
            //bir alan oluştur demek diyoruz referans yapıyordurdurudrurduruduruduruduru.28.12.2022 /// 03,09,2023 burdayım tekrar ediyorum aferin 
            //referans değiştirdiğimizde Garbage collectör çöp toplayıcı boşta kalanı heap bölgesinde çöpe atar.





        }
    }
}
