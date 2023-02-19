using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class ProductManager
    {
        //encapsulation
        public void Add(Product product)//101 numara ile referans alındı gibi gibi olur
        {
            Console.WriteLine(product.ProductName + " eklendi.");

        }
        public void Update(Product product)//101 numara ile referans alındı gibi gibi olur
        {
            Console.WriteLine(product.ProductName + " güncellendi.");

        }

        // void demek geriye dönüş yapmayan metottur.ama int double static gibi dönüşler yazarsan bunu başka bir yerde kullanabilirsin 
        //ama void yaparsan geriye dönüş yapamassın. Örneğin kredi puanını çıkardı ve başka bi yerde bu sonucu kullancaksın
        // burda işte tekrar kullanım var bundan dolayı int string diyebiliriz kullanmak için

        //public int Topla(int sayi1, int sayi2)
        //{
        //    return sayi1 + sayi2;
        //}
        //public void Topla2(int sayi1, int sayi2)
        //{
        //    Console.WriteLine(sayi1 + sayi2);
        //}

    }
}
