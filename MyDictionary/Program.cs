using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyDictionary<string, int> isimId = new MyDictionary<string, int>();
            isimId.Add("Oguz", 1);
        }
    }
}
