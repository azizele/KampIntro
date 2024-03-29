﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueAndRefencesType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int, decimal,float,enum,boolen,value types // değer tipler stack bölgesinde oluşur 
            int sayi1 = 10;
            int sayi2 = 20;

            sayi1 = sayi2;

            sayi2 = 100;

            Console.WriteLine("Sayi 1 : " + sayi1);

            //arrays,class,interface... reference types // diziler sınıflar interfaceler refereans tipler olduğu için
            //heap bölgesinde oluşur bu yüzden bunun cevabı 1000 çıkar. Çünkü referans tip olduğu için referansı değişir ama yukardaki örnekte değerini değiştirirsen de
            //referrans tip olmadığı için ilk değeri kalır değeri sadece değişir. new lediğin zaman heap bölgesinde referans oluşur bunu unutma new oldumu refereans oldu artık.

            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };

            sayilar1 = sayilar2;
            sayilar2[0] = 1000;

            Console.WriteLine("Sayilar1[0] =" + sayilar1[0]);

            Person person1 = new Person();
            Person person2=new Person();
            person1.FirstName = "Engin";

            person2 = person1;
            person1.FirstName = "Derin";

            Console.WriteLine(person2.FirstName);


            
            Customer customer = new Customer();
            customer.FirstName = "Salih";
            Employee employee= new Employee();

            Person person3 = customer;

            Console.ReadKey();
        }


    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    //base class : Person dır temel sınıf Person dır 
    class Customer:Person
    {
        public string CreaditCardNumber { get; set; }

    }
    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }
}
