using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace extlib.Types
{
    public struct UHexadecimal16
    {
        private string value;
        private const ushort MIN_VALUE = ushort.MinValue;
        private const ushort MAX_VALUE = ushort.MaxValue;

        public UHexadecimal16(string v)
        {
            value = v;
        }

        public UHexadecimal16(ushort v)
        {
            value = Convert.ToString(v, 16);
        }

        public static implicit operator UHexadecimal16(string v)
        {
            return new UHexadecimal16(v);
        }
        public static implicit operator UHexadecimal16(ushort v)
        {
            return new UHexadecimal16(v);
        }
        public static implicit operator UHexadecimal16(HexadecimalByte v)
        {
            return new UHexadecimal16(v.ToByte());
        }

        public static UHexadecimal16 operator +(UHexadecimal16 left, UHexadecimal16 right)
        {
            return new UHexadecimal16((ushort)(left.ToUShort() + right.ToUShort()));
        }
        public static UHexadecimal16 operator -(UHexadecimal16 left, UHexadecimal16 right)
        {
            return new UHexadecimal16((ushort)(left.ToUShort() - right.ToUShort()));
        }
        public static UHexadecimal16 operator *(UHexadecimal16 left, UHexadecimal16 right)
        {
            return new UHexadecimal16((ushort)(left.ToUShort() + right.ToUShort()));
        }
        public static UHexadecimal16 operator /(UHexadecimal16 left, UHexadecimal16 right)
        {
            return new UHexadecimal16((ushort)(left.ToUShort() / right.ToUShort()));
        }
        public static UHexadecimal16 operator %(UHexadecimal16 left, UHexadecimal16 right)
        {
            return new UHexadecimal16((ushort)(left.ToUShort() % right.ToUShort()));
        }

        public static UHexadecimal16 operator ++(UHexadecimal16 value)
        {
            return new UHexadecimal16((ushort)(value.ToUShort() + 1));
        }
        public static UHexadecimal16 operator --(UHexadecimal16 value)
        {
            return new UHexadecimal16((ushort)(value.ToUShort() - 1));
        }

        public static bool operator ==(UHexadecimal16 left, UHexadecimal16 right)
        {
            return left.ToUShort() == right.ToUShort();
        }
        public static bool operator !=(UHexadecimal16 left, UHexadecimal16 right)
        {
            return left.ToUShort() != right.ToUShort();
        }
        public static bool operator <(UHexadecimal16 left, UHexadecimal16 right)
        {
            return left.ToUShort() < right.ToUShort();
        }
        public static bool operator >(UHexadecimal16 left, UHexadecimal16 right)
        {
            return left.ToUShort() > right.ToUShort();
        }
        public static bool operator <=(UHexadecimal16 left, UHexadecimal16 right)
        {
            return left.ToUShort() <= right.ToUShort();
        }
        public static bool operator >=(UHexadecimal16 left, UHexadecimal16 right)
        {
            return left.ToUShort() >= right.ToUShort();
        }

        public ushort ToUShort()
        {
            return Convert.ToUInt16(value, 16);
        }

        public override string ToString()
        {
            return value;
        }
        public override bool Equals(object obj)
        {
            return this.ToUShort() == (ushort)obj;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
