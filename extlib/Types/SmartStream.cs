using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using extlib.Extensions;

namespace extlib.Types
{
    public enum Slot
    {
        First, Second
    }
    public class SmartStream
    {
        public SmartStream(string path)
        {
            this.fs = new FileStream(path, FileMode.Open);
        }
        public SmartStream(FileStream fs)
        {
            this.fs = fs;
        }

        public void Read(long slot1pos, long slot2pos, int length)
        {
            this.slot1pos = slot1pos;
            this.slot2pos = slot2pos;
            this.Slot1 = fs.ReadBytes(slot1pos, length);
            this.Slot2 = fs.ReadBytes(slot2pos, length);
        }

        private long slot1pos, slot2pos;
        private byte[] Slot1, Slot2;
        private FileStream fs;
    }
}
