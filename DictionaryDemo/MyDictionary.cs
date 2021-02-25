using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryDemo
{
    class MyDictionary<K,V>
    {
        K[] number;
        V[] names;

        public MyDictionary()
        {
            number = new K[0];
            names = new V[0];
        }
        public void Add(K KeyItem, V ValueItem)
        {
            K[] tempArray = number;
            number = new K[number.Length + 1];
            V[] tempArray2 = names;
            names = new V[names.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                number[i] = tempArray[i];
            }
            number[number.Length - 1] = KeyItem;

            
            for (int i = 0; i < tempArray2.Length; i++)
            {
                names[i] = tempArray2[i];
            }
            names[names.Length - 1] = ValueItem;

        }

        public int count
        {
            get { return number.Length; }

        }
    }
}
