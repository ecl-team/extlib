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
            if (slot2pos - slot1pos < length)
            {
                this.slot2pos = slot1pos + length;
            }
            else
                this.slot2pos = slot2pos;
            this.Slot1 = fs.ReadBytes(this.slot1pos, length);
            this.Slot2 = fs.ReadBytes(this.slot2pos, length);
        }

        public byte[] Get()
        {
            return this.Slot1;
        }

        public byte[] Get(Slot slot)
        {
            if (slot == Slot.First)
                return this.Slot1;
            if (slot == Slot.Second)
                return this.Slot2;
            return null;
        }

        public byte Get(long pos)
        {
            if (pos < slot2pos)
                return Slot1[pos - slot1pos];
            else
                return Slot2[pos - slot2pos];
        }

        public void Set(long pos, byte Byte)
        {
            if (pos < slot2pos)
                Slot1[pos - slot1pos] = Byte;
            else
                Slot2[pos - slot2pos] = Byte;
        }

        private long slot1pos, slot2pos;
        private byte[] Slot1, Slot2;
        private FileStream fs;
    }
}
