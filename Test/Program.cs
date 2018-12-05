using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using extlib;
using extlib.Types;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Hexadecimal8 a = 114;
            Hexadecimal32 b = 0x274885;
            Hexadecimal32 c = a + b;
            int a = c;

            Console.WriteLine(c);
            Console.WriteLine(c.ToInt());
            Console.ReadLine();
        }
    }
}
