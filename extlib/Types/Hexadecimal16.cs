using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace extlib.Types
{
    public struct Hexadecimal16
    {
        private string value;
        private const short MIN_VALUE = short.MinValue;
        private const short MAX_VALUE = short.MaxValue;

        public Hexadecimal16(string v)
        {
            value = v;
        }

        public Hexadecimal16(short v)
        {
            value = Convert.ToString(v, 16);
        }

        public static implicit operator Hexadecimal16(string v)
        {
            return new Hexadecimal16(v);
        }
        public static implicit operator Hexadecimal16(short v)
        {
            return new Hexadecimal16(v);
        }
        public static implicit operator Hexadecimal16(Hexadecimal8 v)
        {
            return new Hexadecimal16(v.ToSByte());
        }
        public static implicit operator Hexadecimal16(HexadecimalByte v)
        {
            return new Hexadecimal16(v.ToByte());
        }

        public static implicit operator long(Hexadecimal16 v)
        {
            return v.ToShort();
        }
        public static implicit operator int(Hexadecimal16 v)
        {
            return v.ToShort();
        }
        public static implicit operator short(Hexadecimal16 v)
        {
            return v.ToShort();
        }

        public static Hexadecimal16 operator +(Hexadecimal16 left, Hexadecimal16 right)
        {
            return new Hexadecimal16((short)(left.ToShort() + right.ToShort()));
        }
        public static Hexadecimal16 operator -(Hexadecimal16 left, Hexadecimal16 right)
        {
            return new Hexadecimal16((short)(left.ToShort() - right.ToShort()));
        }
        public static Hexadecimal16 operator *(Hexadecimal16 left, Hexadecimal16 right)
        {
            return new Hexadecimal16((short)(left.ToShort() + right.ToShort()));
        }
        public static Hexadecimal16 operator /(Hexadecimal16 left, Hexadecimal16 right)
        {
            return new Hexadecimal16((short)(left.ToShort() / right.ToShort()));
        }
        public static Hexadecimal16 operator %(Hexadecimal16 left, Hexadecimal16 right)
        {
            return new Hexadecimal16((short)(left.ToShort() % right.ToShort()));
        }

        public static Hexadecimal16 operator ++(Hexadecimal16 value)
        {
            return new Hexadecimal16((short)(value.ToShort() + 1));
        }
        public static Hexadecimal16 operator --(Hexadecimal16 value)
        {
            return new Hexadecimal16((short)(value.ToShort() - 1));
        }

        public static bool operator ==(Hexadecimal16 left, Hexadecimal16 right)
        {
            return left.ToShort() == right.ToShort();
        }
        public static bool operator !=(Hexadecimal16 left, Hexadecimal16 right)
        {
            return left.ToShort() != right.ToShort();
        }
        public static bool operator <(Hexadecimal16 left, Hexadecimal16 right)
        {
            return left.ToShort() < right.ToShort();
        }
        public static bool operator >(Hexadecimal16 left, Hexadecimal16 right)
        {
            return left.ToShort() > right.ToShort();
        }
        public static bool operator <=(Hexadecimal16 left, Hexadecimal16 right)
        {
            return left.ToShort() <= right.ToShort();
        }
        public static bool operator >=(Hexadecimal16 left, Hexadecimal16 right)
        {
            return left.ToShort() >= right.ToShort();
        }

        public short ToShort()
        {
            return Convert.ToInt16(value, 16);
        }

        public override string ToString()
        {
            return value;
        }
        public override bool Equals(object obj)
        {
            return this.ToShort() == (short)obj;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
