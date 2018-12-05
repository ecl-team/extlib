using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace extlib.Types
{
    public struct Hexadecimal8
    {
        private string value;
        private const sbyte MIN_VALUE = sbyte.MinValue;
        private const sbyte MAX_VALUE = sbyte.MaxValue;

        public Hexadecimal8(string v)
        {
            value = v;
        }

        public Hexadecimal8(sbyte v)
        {
            value = Convert.ToString(v, 16);
        }

        public static implicit operator Hexadecimal8(string v)
        {
            return new Hexadecimal8(v);
        }
        public static implicit operator Hexadecimal8(sbyte v)
        {
            return new Hexadecimal8(v);
        }
        
        public static implicit operator long(Hexadecimal8 v)
        {
            return v.ToSByte();
        }
        public static implicit operator int(Hexadecimal8 v)
        {
            return v.ToSByte();
        } 
        public static implicit operator short(Hexadecimal8 v)
        {
            return v.ToSByte();
        }
        public static implicit operator sbyte(Hexadecimal8 v)
        {
            return v.ToSByte();
        }

        public static Hexadecimal8 operator +(Hexadecimal8 left, Hexadecimal8 right)
        {
            return new Hexadecimal8((sbyte)(left.ToSByte() + right.ToSByte()));
        }
        public static Hexadecimal8 operator -(Hexadecimal8 left, Hexadecimal8 right)
        {
            return new Hexadecimal8((sbyte)(left.ToSByte() - right.ToSByte()));
        }
        public static Hexadecimal8 operator *(Hexadecimal8 left, Hexadecimal8 right)
        {
            return new Hexadecimal8((sbyte)(left.ToSByte() + right.ToSByte()));
        }
        public static Hexadecimal8 operator /(Hexadecimal8 left, Hexadecimal8 right)
        {
            return new Hexadecimal8((sbyte)(left.ToSByte() / right.ToSByte()));
        }
        public static Hexadecimal8 operator %(Hexadecimal8 left, Hexadecimal8 right)
        {
            return new Hexadecimal8((sbyte)(left.ToSByte() % right.ToSByte()));
        }

        public static Hexadecimal8 operator ++(Hexadecimal8 value)
        {
            return new Hexadecimal8((sbyte)(value.ToSByte() + 1));
        }
        public static Hexadecimal8 operator --(Hexadecimal8 value)
        {
            return new Hexadecimal8((sbyte)(value.ToSByte() - 1));
        }

        public static bool operator ==(Hexadecimal8 left, Hexadecimal8 right)
        {
            return left.ToSByte() == right.ToSByte();
        }
        public static bool operator !=(Hexadecimal8 left, Hexadecimal8 right)
        {
            return left.ToSByte() != right.ToSByte();
        }
        public static bool operator <(Hexadecimal8 left, Hexadecimal8 right)
        {
            return left.ToSByte() < right.ToSByte();
        }
        public static bool operator >(Hexadecimal8 left, Hexadecimal8 right)
        {
            return left.ToSByte() > right.ToSByte();
        }
        public static bool operator <=(Hexadecimal8 left, Hexadecimal8 right)
        {
            return left.ToSByte() <= right.ToSByte();
        }
        public static bool operator >=(Hexadecimal8 left, Hexadecimal8 right)
        {
            return left.ToSByte() >= right.ToSByte();
        }

        public sbyte ToSByte()
        {
            return Convert.ToSByte(value, 16);
        }

        public override string ToString()
        {
            return value;
        }
        public override bool Equals(object obj)
        {
            return this.ToSByte() == (sbyte)obj;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
