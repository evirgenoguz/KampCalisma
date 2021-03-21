using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MyDelegate();
    public delegate void MyDelegate2(string text);
    public delegate int MyDelegate3(int number1, int number2);

    class Program
    {
        static void Main(string[] args)
        {
            Customeranager customeranager = new Customeranager();
            //customeranager.SendMessage();
            //customeranager.ShowAlert();

            MyDelegate myDelegate = customeranager.SendMessage;
            myDelegate += customeranager.ShowAlert;
            myDelegate -= customeranager.SendMessage;

            MyDelegate2 myDelegate2 = customeranager.SendMessage2;
            myDelegate2 += customeranager.ShowAlert2;

            myDelegate2("Hello");

            myDelegate();

            Console.WriteLine("---------------------------");

            Matematik matematik = new Matematik();
            MyDelegate3 myDelegate3 = matematik.Topla;
            var sonuc = myDelegate3(2, 3);
            Console.WriteLine(sonuc);

            Console.ReadLine();
        }
    }

    class Customeranager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello");
        }
        public void ShowAlert()
        {
            Console.WriteLine("Be Careful!");
        }
        public void SendMessage2(string message)
        {
            Console.WriteLine(message);
        }
        public void ShowAlert2(string alert)
        {
            Console.WriteLine(alert);
        }
    }

    class Matematik
    {
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
    }
}
