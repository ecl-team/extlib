using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extlib
{
    public static class ArrayExtensions
    {
        public static T[] Resize<T>(this T[] array, int size)
        {
            Array.Resize(ref array, size);
            return array;
        }
    }
}
