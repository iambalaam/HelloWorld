using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Something thing = new Something();
            int number = thing.GetAnInt();
            Console.WriteLine(number);
        }
    }
}
