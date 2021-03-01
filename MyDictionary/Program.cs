using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Beyza");
            myDictionary.Add(2, "Mine");
            myDictionary.Add(3, "Aktaş");

            myDictionary.List();
        }
    }
}
