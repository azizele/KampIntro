using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryOdev
{
    public class MyDictionary<T>
    {
        T[] _array;
        T[] _tempArray;

        public MyDictionary()
        {
            _array=new T[0];    
        }

        public void Add(T item)
        {
            _tempArray = _array;
            _array=new T[_array.Length+1];

            for (int i = 0; i < _tempArray.Length; i++)
            {
                _tempArray[i] = _array[i];
            }
            _array[_array.Length - 1] = item;
        }
    }
}
