using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extlib.Extensions
{
    public static class FileStreamExtensions
    {
        public static byte[] ReadBytes(this FileStream fs, long pos, int length)
        {
            byte[] buffer = new byte[length];
            fs.Seek(pos, SeekOrigin.Begin);
            fs.Read(buffer, 0, length);
            return buffer;
        }
    }
}
