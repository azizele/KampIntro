using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Id = 100;
            product.Name = "Milk";
            product.StockAmount = 1000;

            Product product1 = new Product();
            product1.Id = 101;
            product1.Name = "Tea";
            product1.StockAmount = 1500;

            Product[] products = new Product[] { product,product1 };

            foreach (var s in products)
            {
                Console.WriteLine("Product ID : " + s.Id + "\nProduct Name : " + s.Name + "\nProduct Stock Amount : " + s.StockAmount);
                Console.WriteLine();
            }

            Console.WriteLine("-----------------------------");
            int a = 0;
            while (a < products.Length)
            {
                Console.WriteLine("Product ID : " + products[a].Id + "\nProduct Name : " + products[a].Name + "\nProduct Stock Amount : " + products[a].StockAmount);
                Console.WriteLine();
                a++;
            }

            Console.WriteLine("-----------------------------");

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Product ID : " + products[i].Id + "\nProduct Name : " + products[i].Name + "\nProduct Stock Amount : " + products[i].StockAmount);
                Console.WriteLine();
                //Console.WriteLine("Product ID : " + product.Id + "\nProduct Name : " + product.Name + "\nProduct Stock Amount : " + product.StockAmount);
                //Console.WriteLine("Product ID : " + product1.Id + "\nProduct Name : " + product1.Name + "\nProduct Stock Amount : " + product1.StockAmount);

            }

            Console.ReadKey();
        }
        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int StockAmount { get; set; }

        }


    }

}
