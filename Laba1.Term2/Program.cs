using System;

namespace Laba1.Term2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>(3);
            list.Add(1);
            list.Add(2);
            list.Add(4);
            Console.WriteLine(list.Get(0)); 
            Console.WriteLine(list.Count());

            MyDictionary<int, string> dictionary = new MyDictionary<int, string>(6);
            dictionary.Add(8, "qwerty");
            dictionary.Add(15, "bhdcsjn");
            dictionary.Add(7, "zva");
            Console.WriteLine(dictionary.Get(15));
            Console.WriteLine(dictionary.Count());
        }
    }
}
