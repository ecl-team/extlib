using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extlib.Extensions
{
    public static class ArrayExtensions
    {
        /// <summary>
        /// Combines all <see cref="char"/> elements into a <see cref="string"/>
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

        /// <summary>
        /// Combines all <see cref="char"/> elements into a <see cref="string"/>
        /// </summary>
        /// <param name="array"></param>
        /// <param name="between"></param>
        /// <returns></returns>
        public static string AsString(this char[] array, string between)
        {
            string a = "";
            for (int i = 0; i < array.Length; i++)
            {
                if (i != 0)
                    a += between;
                a += array[i];
            }
            return a;
        }

        /// <summary>
        /// Turns the <see cref="byte"/> array into a <see cref="BitArray"/>.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static BitArray ToBitArray(this byte[] array)
        {
            return new BitArray(array);
        }

        /// <summary>
        /// Returns a new <see cref="Array"/> with a new size.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public static T[] Resize<T>(this T[] array, int size)
        {
            Array.Resize(ref array, size);
            return array;
        }
    }
}
