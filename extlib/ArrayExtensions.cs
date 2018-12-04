using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extlib
{
    public static class ArrayExtensions
    {
        /// <summary>
        /// Combines all <see cref="System.Char"/> elements into a <see cref="System.String"/>
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static string AsString(this char[] array)
        {
            string a = "";
            for (int i = 0; i < array.Length; i++)
            {
                a += array[i];
            }
            return a;
        }

        public static T[] Resize<T>(this T[] array, int size)
        {
            char[] e;
            Array.Resize(ref array, size);
            return array;
        }
    }
}
