using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace extlib.Types
{
    public struct UHexadecimal64
    {
        private string value;
        private const int MinValue = int.MinValue;
        private const int MaxValue = int.MaxValue;

        public UHexadecimal64(string v)
        {
            value = v;
        }

        public UHexadecimal64(ulong v)
        {
            value = v.ToString("x");
        }

        public static implicit operator UHexadecimal64(string v)
        {
            return new UHexadecimal64(v);
        }
        public static implicit operator UHexadecimal64(ulong v)
        {
            return new UHexadecimal64(v);
        }
        public static implicit operator UHexadecimal64(UHexadecimal32 v)
        {
            return new UHexadecimal64(v.ToUInt());
        }
        public static implicit operator UHexadecimal64(UHexadecimal16 v)
        {
            return new UHexadecimal64(v.ToUShort());
        }
        public static implicit operator UHexadecimal64(HexadecimalByte v)
        {
            return new UHexadecimal64(v.ToByte());
        }

        public static UHexadecimal64 operator +(UHexadecimal64 left, UHexadecimal64 right)
        {
            return new UHexadecimal64(left.ToULong() + right.ToULong());
        }
        public static UHexadecimal64 operator -(UHexadecimal64 left, UHexadecimal64 right)
        {
            return new UHexadecimal64(left.ToULong() - right.ToULong());
        }
        public static UHexadecimal64 operator *(UHexadecimal64 left, UHexadecimal64 right)
        {
            return new UHexadecimal64(left.ToULong() + right.ToULong());
        }
        public static UHexadecimal64 operator /(UHexadecimal64 left, UHexadecimal64 right)
        {
            return new UHexadecimal64(left.ToULong() / right.ToULong());
        }
        public static UHexadecimal64 operator %(UHexadecimal64 left, UHexadecimal64 right)
        {
            return new UHexadecimal64(left.ToULong() % right.ToULong());
        }

        public static UHexadecimal64 operator ++(UHexadecimal64 value)
        {
            return new UHexadecimal64(value.ToULong() + 1);
        }
        public static UHexadecimal64 operator --(UHexadecimal64 value)
        {
            return new UHexadecimal64(value.ToULong() - 1);
        }

        public static bool operator ==(UHexadecimal64 left, UHexadecimal64 right)
        {
            return left.ToULong() == right.ToULong();
        }
        public static bool operator !=(UHexadecimal64 left, UHexadecimal64 right)
        {
            return left.ToULong() != right.ToULong();
        }
        public static bool operator <(UHexadecimal64 left, UHexadecimal64 right)
        {
            return left.ToULong() < right.ToULong();
        }
        public static bool operator >(UHexadecimal64 left, UHexadecimal64 right)
        {
            return left.ToULong() > right.ToULong();
        }
        public static bool operator <=(UHexadecimal64 left, UHexadecimal64 right)
        {
            return left.ToULong() <= right.ToULong();
        }
        public static bool operator >=(UHexadecimal64 left, UHexadecimal64 right)
        {
            return left.ToULong() >= right.ToULong();
        }

        public ulong ToULong()
        {
            return Convert.ToUInt64(value, 16);
        }

        public override string ToString()
        {
            return value;
        }
        public override bool Equals(object obj)
        {
            return this.ToULong() == (ulong)obj;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
