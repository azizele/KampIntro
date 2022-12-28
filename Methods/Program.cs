using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 =new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 98;
            urun1.Id = 213213;
            
            Urun urun2 = new Urun();
            urun2.Adi = "Kiraz";
            urun2.Acıklama="Nefis Kiraz";


            Console.WriteLine("Merhaba Abdulaziz Nerde Bu CSharp projelerin");
            Console.WriteLine("Hello World!");
            Console.WriteLine("----------Metotlar-----------");
            //instance - örnek 
            //encapsulation 
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
           

            sepetManager.Ekle2("Armut", "Yeşil armut", 12,10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12,9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12,8);
        

            Console.ReadKey();

        }


    }
}




//Dont repeat yourself -DRY - Clean Code - Best Practice(En iyi Uygulama-En iyi Pratik )