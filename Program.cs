using System;

namespace FunctionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            void Addvalue(int a ,int b)
            {
                Console.WriteLine("value of a is:"+a);
                Console.WriteLine("value of b is"+b);
                Console.WriteLine("value of {0}",a+b);
            }
            Addvalue(20, 30);
        }
    }
}
