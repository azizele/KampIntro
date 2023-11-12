using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> myDictionary= new MyDictionary<string>();
            myDictionary.Add("Aziz");
            myDictionary.Add("Hemrin");
            myDictionary.Add("Muhammed Can");
            myDictionary.Add("Lina");

            Console.WriteLine(myDictionary);
            
            Console.ReadKey();

        }
        
    }
}
