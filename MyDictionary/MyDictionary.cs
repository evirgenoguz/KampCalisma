using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T, V>
    {
        T[] itemKeys;
        V[] itemValues;
        public MyDictionary()
        {
            //keyleri ve valueleri ayrı ayrı dizilerde aynı indislerde tutacağım.
            itemKeys = new T[0];
            itemValues = new V[0];
            Console.WriteLine("Constructor Çalıştı");
        }
        public void Add(T itemKey, V itemValue)
        {
            T[] tempItemKeys = itemKeys;
            V[] tempItemValues = itemValues;

            itemKeys = new T[itemKeys.Length + 1];
            itemValues = new V[itemValues.Length + 1];

            //Console.WriteLine(itemKeys.Length);

            for (int i = 0; i < tempItemKeys.Length; i++)
            {
                itemKeys[i] = tempItemKeys[i];
                itemValues[i] = tempItemValues[i];
            }

            itemKeys[itemKeys.Length - 1] = itemKey;
            itemValues[itemValues.Length - 1] = itemValue;

            
            
            Console.WriteLine("Eklenen");

            Console.WriteLine("Key : " + itemKey + " Value : " + itemValue);
        }
    }
}
