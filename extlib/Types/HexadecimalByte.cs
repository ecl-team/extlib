using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace extlib.Types
{
    public struct HexadecimalByte
    {
        private string value;
        private const byte MIN_VALUE = byte.MinValue;
        private const byte MAX_VALUE = byte.MaxValue;

        public HexadecimalByte(string v)
        {
            value = v;
        }

        public HexadecimalByte(byte v)
        {
            value = Convert.ToString(v, 16);
        }

        public static implicit operator HexadecimalByte(string v)
        {
            return new HexadecimalByte(v);
        }
        public static implicit operator HexadecimalByte(byte v)
        {
            return new HexadecimalByte(v);
        }

        public static HexadecimalByte operator +(HexadecimalByte left, HexadecimalByte right)
        {
            return new HexadecimalByte((byte)(left.ToByte() + right.ToByte()));
        }
        public static HexadecimalByte operator -(HexadecimalByte left, HexadecimalByte right)
        {
            return new HexadecimalByte((byte)(left.ToByte() - right.ToByte()));
        }
        public static HexadecimalByte operator *(HexadecimalByte left, HexadecimalByte right)
        {
            return new HexadecimalByte((byte)(left.ToByte() + right.ToByte()));
        }
        public static HexadecimalByte operator /(HexadecimalByte left, HexadecimalByte right)
        {
            return new HexadecimalByte((byte)(left.ToByte() / right.ToByte()));
        }
        public static HexadecimalByte operator %(HexadecimalByte left, HexadecimalByte right)
        {
            return new HexadecimalByte((byte)(left.ToByte() % right.ToByte()));
        }

        public static HexadecimalByte operator ++(HexadecimalByte value)
        {
            return new HexadecimalByte((byte)(value.ToByte() + 1));
        }
        public static HexadecimalByte operator --(HexadecimalByte value)
        {
            return new HexadecimalByte((byte)(value.ToByte() - 1));
        }

        public static bool operator ==(HexadecimalByte left, HexadecimalByte right)
        {
            return left.ToByte() == right.ToByte();
        }
        public static bool operator !=(HexadecimalByte left, HexadecimalByte right)
        {
            return left.ToByte() != right.ToByte();
        }
        public static bool operator <(HexadecimalByte left, HexadecimalByte right)
        {
            return left.ToByte() < right.ToByte();
        }
        public static bool operator >(HexadecimalByte left, HexadecimalByte right)
        {
            return left.ToByte() > right.ToByte();
        }
        public static bool operator <=(HexadecimalByte left, HexadecimalByte right)
        {
            return left.ToByte() <= right.ToByte();
        }
        public static bool operator >=(HexadecimalByte left, HexadecimalByte right)
        {
            return left.ToByte() >= right.ToByte();
        }

        public byte ToByte()
        {
            return Convert.ToByte(value, 16);
        }

        public override string ToString()
        {
            return value;
        }
        public override bool Equals(object obj)
        {
            return this.ToByte() == (byte)obj;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
