using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Oguz", "Ali", "Veli", "Ayşe" };
            //Console.WriteLine(isimler[0]);


            List<string> isimler2 = new List<string> { "Oguz", "Ali", "Veli", "Ayşe" };
            Console.WriteLine(isimler2[0]);

            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
        }
    }
}
