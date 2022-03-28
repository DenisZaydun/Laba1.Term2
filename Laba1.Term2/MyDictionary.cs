using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1.Term2
{
    class MyDictionary<TKey, TValue> where TKey : IEquatable<TKey>
    {
        public PairClass<TKey, TValue>[] dict;


        public MyDictionary(int length)
        {
            dict = new PairClass<TKey, TValue>[length];
        }

        public int index = 0;
        public void Add(TKey key, TValue value)
        {
            foreach (PairClass<TKey, TValue> keys in dict)
            {
                if (key.Equals(keys.Key))
                {
                    Console.WriteLine("Такий ключ вже існує");
                    break;
                }
                else
                {
                    dict[index].Key = key;
                    dict[index].Value = value;
                    index++;
                    break;
                }
            }

            /*for (int i = 0; i < dict.Length; i++)
            {
                if (key.Equals(dict[i].Key))
                {
                    Console.WriteLine("Такий ключ вже існує");
                    break;
                }
                else
                {
                    dict[index].Key = key;
                    dict[index].Value = value;
                    index++;
                    break;
                }
            }*/
        }

        public TValue Get(TKey key)
        {
            foreach (PairClass<TKey, TValue> keys in dict)
            {
                if (key.Equals(keys.Key))
                {
                    return keys.Value;
                }

            }
            return default(TValue);

            /*for (int i = 0; i < dict.Length; i++)
            {
                if (dict[i].Key.Equals(key))
                {
                    return dict[i].Value;
                }
            }
            return default(TValue);
            }*/
        }

        public int Count()
        {
            return index + 1;
        }
    }
}