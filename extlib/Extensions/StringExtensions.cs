using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extlib.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Splits the <see cref="string"/> every certain amount of steps.
        /// </summary>
        /// <param name="str"></param>
        /// <param name="every"></param>
        /// <returns></returns>
        public static string[] Split(this string str, int every)
        {
            List<string> a = new List<string>();
            char[] b = str.ToCharArray();
            string c = "";
            for (int i = 0; i < str.Length; i++)
            {
                c += b[i];
                if ((i + 1) % every == 0)
                {
                    a.Add(c);
                    c = "";
                }
            }
            return a.ToArray();
        }

        /// <summary>
        /// Splits the <see cref="string"/> in specific positions
        /// </summary>
        /// <param name="str"></param>
        /// <param name="positions"></param>
        /// <returns></returns>
        public static string[] Split(this string str, int[] positions)
        {
            List<string> a = new List<string>();
            char[] b = str.ToCharArray();
            string c = "";
            for (int i = 0; i < str.Length; i++)
            {
                c += b[i];
                if (positions.Contains(i))
                {
                    a.Add(c);
                    c = "";
                }
            }
            return a.ToArray();
        }

        public static byte[] GetBytes(this string str)
        {
            return Encoding.ASCII.GetBytes(str);
        }
    }
}
