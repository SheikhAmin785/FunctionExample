using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionExample
{
    class Example1
    {
        public static void Fmain()
        {
        void Mymethod<Myvalue>(Myvalue value)
            {
                Console.WriteLine("value is:"+value);
            }
            Mymethod<int>(123);
            Mymethod<string>("geek force");
            Mymethod<char>('g');
            Mymethod<double>(3234.11234);
        }
    }
}
