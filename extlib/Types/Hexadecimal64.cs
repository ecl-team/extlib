using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace extlib.Types
{
    public struct Hexadecimal64
    {
        private string value;
        private const int MIN_VALUE = int.MinValue;
        private const int MAX_VALUE = int.MaxValue;

        public Hexadecimal64(string v)
        {
            value = v;
        }

        public Hexadecimal64(long v)
        {
            value = Convert.ToString(v, 16);
        }

        public static implicit operator Hexadecimal64(string v)
        {
            return new Hexadecimal64(v);
        }
        public static implicit operator Hexadecimal64(long v)
        {
            return new Hexadecimal64(v);
        }
        public static implicit operator Hexadecimal64(Hexadecimal32 v)
        {
            return new Hexadecimal64(v.ToInt());
        }
        public static implicit operator Hexadecimal64(UHexadecimal32 v)
        {
            return new Hexadecimal64(v.ToUInt());
        }
        public static implicit operator Hexadecimal64(Hexadecimal16 v)
        {
            return new Hexadecimal64(v.ToShort());
        }
        public static implicit operator Hexadecimal64(UHexadecimal16 v)
        {
            return new Hexadecimal64(v.ToUShort());
        }
        public static implicit operator Hexadecimal64(Hexadecimal8 v)
        {
            return new Hexadecimal64(v.ToSByte());
        }
        public static implicit operator Hexadecimal64(HexadecimalByte v)
        {
            return new Hexadecimal64(v.ToByte());
        }

        public static Hexadecimal64 operator +(Hexadecimal64 left, Hexadecimal64 right)
        {
            return new Hexadecimal64(left.ToLong() + right.ToLong());
        }
        public static Hexadecimal64 operator -(Hexadecimal64 left, Hexadecimal64 right)
        {
            return new Hexadecimal64(left.ToLong() - right.ToLong());
        }
        public static Hexadecimal64 operator *(Hexadecimal64 left, Hexadecimal64 right)
        {
            return new Hexadecimal64(left.ToLong() + right.ToLong());
        }
        public static Hexadecimal64 operator /(Hexadecimal64 left, Hexadecimal64 right)
        {
            return new Hexadecimal64(left.ToLong() / right.ToLong());
        }
        public static Hexadecimal64 operator %(Hexadecimal64 left, Hexadecimal64 right)
        {
            return new Hexadecimal64(left.ToLong() % right.ToLong());
        }

        public static Hexadecimal64 operator ++(Hexadecimal64 value)
        {
            return new Hexadecimal64(value.ToLong() + 1);
        }
        public static Hexadecimal64 operator --(Hexadecimal64 value)
        {
            return new Hexadecimal64(value.ToLong() - 1);
        }

        public static bool operator ==(Hexadecimal64 left, Hexadecimal64 right)
        {
            return left.ToLong() == right.ToLong();
        }
        public static bool operator !=(Hexadecimal64 left, Hexadecimal64 right)
        {
            return left.ToLong() != right.ToLong();
        }
        public static bool operator <(Hexadecimal64 left, Hexadecimal64 right)
        {
            return left.ToLong() < right.ToLong();
        }
        public static bool operator >(Hexadecimal64 left, Hexadecimal64 right)
        {
            return left.ToLong() > right.ToLong();
        }
        public static bool operator <=(Hexadecimal64 left, Hexadecimal64 right)
        {
            return left.ToLong() <= right.ToLong();
        }
        public static bool operator >=(Hexadecimal64 left, Hexadecimal64 right)
        {
            return left.ToLong() >= right.ToLong();
        }

        public long ToLong()
        {
            return Convert.ToInt64(value, 16);
        }

        public override string ToString()
        {
            return value;
        }
        public override bool Equals(object obj)
        {
            return this.ToLong() == (int)obj;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
