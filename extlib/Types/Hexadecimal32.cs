using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace extlib.Types
{
    public struct Hexadecimal32
    {
        private string value;
        private const int MIN_VALUE = int.MinValue;
        private const int MAX_VALUE = int.MaxValue;

        public Hexadecimal32(string v)
        {
            value = v;
        }

        public Hexadecimal32(int v)
        {
            value = Convert.ToString(v, 16);
        }

        public static implicit operator Hexadecimal32(string v)
        {
            return new Hexadecimal32(v);
        }
        public static implicit operator Hexadecimal32(int v)
        {
            return new Hexadecimal32(v);
        }
        public static implicit operator Hexadecimal32(Hexadecimal16 v)
        {
            return new Hexadecimal32(v.ToShort());
        }
        public static implicit operator Hexadecimal32(UHexadecimal16 v)
        {
            return new Hexadecimal32(v.ToUShort());
        }
        public static implicit operator Hexadecimal32(Hexadecimal8 v)
        {
            return new Hexadecimal32(v.ToSByte());
        }
        public static implicit operator Hexadecimal32(HexadecimalByte v)
        {
            return new Hexadecimal32(v.ToByte());
        }

        public static implicit operator long(Hexadecimal32 v)
        {
            return v.ToInt();
        }
        public static implicit operator int(Hexadecimal32 v)
        {
            return v.ToInt();
        }

        public static Hexadecimal32 operator +(Hexadecimal32 left, Hexadecimal32 right)
        {
            return new Hexadecimal32(left.ToInt() + right.ToInt());
        }
        public static Hexadecimal32 operator -(Hexadecimal32 left, Hexadecimal32 right)
        {
            return new Hexadecimal32(left.ToInt() - right.ToInt());
        }
        public static Hexadecimal32 operator *(Hexadecimal32 left, Hexadecimal32 right)
        {
            return new Hexadecimal32(left.ToInt() + right.ToInt());
        }
        public static Hexadecimal32 operator /(Hexadecimal32 left, Hexadecimal32 right)
        {
            return new Hexadecimal32(left.ToInt() / right.ToInt());
        }
        public static Hexadecimal32 operator %(Hexadecimal32 left, Hexadecimal32 right)
        {
            return new Hexadecimal32(left.ToInt() % right.ToInt());
        }

        public static Hexadecimal32 operator ++(Hexadecimal32 value)
        {
            return new Hexadecimal32(value.ToInt() + 1);
        }
        public static Hexadecimal32 operator --(Hexadecimal32 value)
        {
            return new Hexadecimal32(value.ToInt() - 1);
        }

        public static bool operator ==(Hexadecimal32 left, Hexadecimal32 right)
        {
            return left.ToInt() == right.ToInt();
        }
        public static bool operator !=(Hexadecimal32 left, Hexadecimal32 right)
        {
            return left.ToInt() != right.ToInt();
        }
        public static bool operator <(Hexadecimal32 left, Hexadecimal32 right)
        {
            return left.ToInt() < right.ToInt();
        }
        public static bool operator >(Hexadecimal32 left, Hexadecimal32 right)
        {
            return left.ToInt() > right.ToInt();
        }
        public static bool operator <=(Hexadecimal32 left, Hexadecimal32 right)
        {
            return left.ToInt() <= right.ToInt();
        }
        public static bool operator >=(Hexadecimal32 left, Hexadecimal32 right)
        {
            return left.ToInt() >= right.ToInt();
        }

        public int ToInt()
        {
            return Convert.ToInt32(value, 16);
        }

        public override string ToString()
        {
            return value;
        }
        public override bool Equals(object obj)
        {
            return this.ToInt() == (int)obj;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
