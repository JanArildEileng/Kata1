using System;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Dev World!");

            Testlib.Class1 class1=new Testlib.Class1() {

            };

            Console.WriteLine($"class1={class1}");
        }
    }
}
