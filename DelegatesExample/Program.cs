using System;

namespace DelegatesExample
{
    public delegate void Mydelegate(String name);
    class Program
    {
        static void Main(string[] args)
        {
            Mydelegate del3 = delegate (string name)
            { Console.WriteLine($"Notification received for: {name}"); };

            del3("mmm");
        }
        static void kilo(int a, int b)
        {
            //do something
            Console.WriteLine("My program working fine");


        }
    
    }
}
