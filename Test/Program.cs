using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using extlib.Extensions;
using extlib.Types;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            byte? e = new byte?();
            Console.WriteLine(e.HasValue);
            Console.ReadLine();
        }
    }
}
