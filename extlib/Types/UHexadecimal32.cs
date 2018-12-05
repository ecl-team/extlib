using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace extlib.Types
{
    public struct UHexadecimal32
    {
        private string value;
        private const uint MinValue = uint.MinValue;
        private const uint MaxValue = uint.MaxValue;

        public UHexadecimal32(string v)
        {
            value = v;
        }

        public UHexadecimal32(uint v)
        {
            value = Convert.ToString(v, 16);
        }

        public static implicit operator UHexadecimal32(string v)
        {
            return new UHexadecimal32(v);
        }
        public static implicit operator UHexadecimal32(uint v)
        {
            return new UHexadecimal32(v);
        }
        public static implicit operator UHexadecimal32(UHexadecimal16 v)
        {
            return new UHexadecimal32(v.ToUShort());
        }
        public static implicit operator UHexadecimal32(HexadecimalByte v)
        {
            return new UHexadecimal32(v.ToByte());
        }

        public static UHexadecimal32 operator +(UHexadecimal32 left, UHexadecimal32 right)
        {
            return new UHexadecimal32(left.ToUInt() + right.ToUInt());
        }
        public static UHexadecimal32 operator -(UHexadecimal32 left, UHexadecimal32 right)
        {
            return new UHexadecimal32(left.ToUInt() - right.ToUInt());
        }
        public static UHexadecimal32 operator *(UHexadecimal32 left, UHexadecimal32 right)
        {
            return new UHexadecimal32(left.ToUInt() + right.ToUInt());
        }
        public static UHexadecimal32 operator /(UHexadecimal32 left, UHexadecimal32 right)
        {
            return new UHexadecimal32(left.ToUInt() / right.ToUInt());
        }
        public static UHexadecimal32 operator %(UHexadecimal32 left, UHexadecimal32 right)
        {
            return new UHexadecimal32(left.ToUInt() % right.ToUInt());
        }

        public static UHexadecimal32 operator ++(UHexadecimal32 value)
        {
            return new UHexadecimal32(value.ToUInt() + 1);
        }
        public static UHexadecimal32 operator --(UHexadecimal32 value)
        {
            return new UHexadecimal32(value.ToUInt() - 1);
        }

        public static bool operator ==(UHexadecimal32 left, UHexadecimal32 right)
        {
            return left.ToUInt() == right.ToUInt();
        }
        public static bool operator !=(UHexadecimal32 left, UHexadecimal32 right)
        {
            return left.ToUInt() != right.ToUInt();
        }
        public static bool operator <(UHexadecimal32 left, UHexadecimal32 right)
        {
            return left.ToUInt() < right.ToUInt();
        }
        public static bool operator >(UHexadecimal32 left, UHexadecimal32 right)
        {
            return left.ToUInt() > right.ToUInt();
        }
        public static bool operator <=(UHexadecimal32 left, UHexadecimal32 right)
        {
            return left.ToUInt() <= right.ToUInt();
        }
        public static bool operator >=(UHexadecimal32 left, UHexadecimal32 right)
        {
            return left.ToUInt() >= right.ToUInt();
        }

        public uint ToUInt()
        {
            return Convert.ToUInt32(value, 16);
        }

        public override string ToString()
        {
            return value;
        }
        public override bool Equals(object obj)
        {
            return this.ToUInt() == (uint)obj;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
