using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] tKeys;
        TValue[] tValues;
        public MyDictionary() 
        {
            tKeys = new TKey[0];
            tValues = new TValue[0];
        }
        public void Add(TKey key, TValue value) 
        {
            TKey[] _tKeys = tKeys;
            tKeys = new TKey[tKeys.Length + 1];
            for (int i = 0; i < _tKeys.Length; i++)
            {
                tKeys[i] = _tKeys[i];
            }
            tKeys[tKeys.Length - 1] = key;
            TValue[] _tValues = tValues;
            tValues = new TValue[tValues.Length + 1];
            for (int i = 0; i < _tValues.Length; i++)
            {
                tValues[i] = _tValues[i];
            }
            tValues[tValues.Length - 1] = value;
        }
        public int Counter 
        {
            get 
            {
                return tKeys.Length;
            }
        }
        public void Iterate() 
        {
            for (int i = 0; i < tKeys.Length; i++)
            {
                Console.WriteLine(tKeys[i]+ ".eleman");
                Console.WriteLine(tValues[i]);
            }
        }
    }
}
