using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;

            Metot m = new Metot();
            m.Parametresiz_Hesapla(a, b);

            Console.WriteLine("Parametresiz_Hesapla() foksiyonu için değişken değerleri : a = " + a + " b : " + b);
            Console.WriteLine();
           
            m.Ref_Kullanarak_Hesapla(ref a, ref b);
            Console.WriteLine("Ref_Kullanarak_Hesapla() fonksiyonu için değişken değerleri : a = " + a + " b = " + b);
            Console.WriteLine();

            m.Out_Kullanarak_Hesapla(out a, out b);
            Console.WriteLine("Out_Kullanarak_Hesapla() foksiyonu için değişken değerleri : a = " + a + " b : " + b);
            Console.WriteLine();

            Console.ReadLine();


        }
        public class Metot
        {
            public void Parametresiz_Hesapla(int a, int b)
            {
                a = 1;
                b = 0002;

            }
            public void Ref_Kullanarak_Hesapla(ref int a, ref int b)
            {
                a = 3;
                b = 4;
            }
            public void Out_Kullanarak_Hesapla(out int a, out int b)
            {
                a = 5;
                b = 6;

            }
        }


    }

}
