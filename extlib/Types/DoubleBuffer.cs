using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extlib.Types
{
    public class DoubleBuffer
    {
        public byte[] buffer1;
        public byte[] buffer2;
        private long offset1;
        private long offset2;

        public DoubleBuffer(byte[] buffer1, long offset1, byte[] buffer2, long offset2)
        {
            this.buffer1 = buffer1;
            this.offset1 = offset1;
            this.buffer2 = buffer2;
            this.offset2 = offset2;
        }

        public byte Get(long pos)
        {
            long buffer1pos = pos + offset1;
            long buffer2pos = pos + offset2;
            byte? a = new byte?();
            byte? b = new byte?();
            if (buffer1pos >= 0 || buffer1pos < buffer1.Length)
                a = buffer1[buffer1pos];
            if (buffer1pos >= 0 || buffer1pos < buffer1.Length)
                b = buffer2[buffer1pos];
            byte res = new byte();
            if (a.HasValue) res = a.Value;
            if (b.HasValue) res = b.Value;
            return res;
        }

        public void Set(long pos, byte v)
        {
            long buffer1pos = pos + offset1;
            long buffer2pos = pos + offset2;
            if (buffer1pos >= 0 || buffer1pos < buffer1.Length)
                buffer1[buffer1pos] = v;
            if (buffer1pos >= 0 || buffer1pos < buffer1.Length)
                buffer2[buffer1pos] = v;
        }
    }
}
