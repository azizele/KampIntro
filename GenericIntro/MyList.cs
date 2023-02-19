using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    public class MyList<T>
    {
        T[] items; //items diye T tipi kullanıcı belirleyen bir varlık nesne oluşturuldu.
        //constructor
        public MyList()
        {
            items = new T[0]; //items için karşı kümede yani heap bölgesinde yeni bir referans oluşturuldu T tipinde 0 dan başlayan dizi 
        }

        public void Add(T item)
        {
            T[] tempArray = items; //temp geciçi array referansını unutmaması için diğer referanstaki elemanları geri almak için 
            items = new T[items.Length + 1]; // bir referans artırıldı items ın referans numarası bir artırıldı 
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];//geride kalanları geri getirmek için yapılır items[0] için tempArray[0] getirilir for ile bunları dönüp ekrana yazar
            }

            items[items.Length - 1] = item;
        }
    }
}
