using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace extlib.Extensions
{
    public static class RandomExtensions
    {
        public static byte NextByte(this Random random)
        {
            byte[] a = new byte[1];
            random.NextBytes(a);
            return a[0];
        }
        public static byte NextByte(this Random random, byte min)
        {
            BigInteger range = byte.MaxValue - min;
            byte[] a = new byte[1];
            random.NextBytes(a);
            return a[0];
        }
        public static byte NextByte(this Random random, byte min, byte max)
        {
            BigInteger range = max - min;
            byte[] a = new byte[1];
            random.NextBytes(a);
            return (byte)(a[0] % range);
        }

        public static short NextShort(this Random random)
        {
            byte[] a = new byte[2];
            random.NextBytes(a);
            return BitConverter.ToInt16(a, 0);
        }
        public static short NextShort(this Random random, short min)
        {
            BigInteger range = short.MaxValue - min;
            byte[] a = new byte[2];
            random.NextBytes(a);
            return (short)(BitConverter.ToInt16(a, 0) % range);
        }
        public static short NextShort(this Random random, short min, short max)
        {
            BigInteger range = max - min;
            byte[] a = new byte[2];
            random.NextBytes(a);
            return (short)(BitConverter.ToInt16(a, 0) % range);
        }

        public static long NextLong(this Random random)
        {
            byte[] a = new byte[8];
            random.NextBytes(a);
            return BitConverter.ToInt64(a, 0);
        }
        public static long NextLong(this Random random, long min)
        {
            BigInteger range = long.MaxValue - min;
            byte[] a = new byte[8];
            random.NextBytes(a);
            return (long)(BitConverter.ToInt64(a, 0) % range);
        }
        public static long NextLong(this Random random, long min, long max)
        {
            BigInteger range = max - min;
            byte[] a = new byte[8];
            random.NextBytes(a);
            return (long)(BitConverter.ToInt64(a, 0) % range);
        }

        public static sbyte NextSByte(this Random random)
        {
            byte[] a = new byte[1];
            random.NextBytes(a);
            return (sbyte)(a[0] - sbyte.MaxValue - 1);
        }
        public static sbyte NextSByte(this Random random, sbyte min)
        {
            BigInteger range = sbyte.MaxValue - min;
            byte[] a = new byte[1];
            random.NextBytes(a);
            return (sbyte)((a[0] - sbyte.MaxValue - 1) % range);
        }
        public static sbyte NextSByte(this Random random, sbyte min, sbyte max)
        {
            BigInteger range = max - min;
            byte[] a = new byte[1];
            random.NextBytes(a);
            return (sbyte)((a[0] - sbyte.MaxValue - 1) % range);
        }

        public static ushort NextUShort(this Random random)
        {
            byte[] a = new byte[2];
            random.NextBytes(a);
            return (ushort)(BitConverter.ToInt16(a, 0) + short.MaxValue + 1);
        }
        public static ushort NextUShort(this Random random, ushort min)
        {
            BigInteger range = ushort.MaxValue - min;
            byte[] a = new byte[2];
            random.NextBytes(a);
            return (ushort)((BitConverter.ToInt16(a, 0) + short.MaxValue + 1) % range);
        }
        public static ushort NextUShort(this Random random, ushort min, ushort max)
        {
            BigInteger range = max - min;
            byte[] a = new byte[2];
            random.NextBytes(a);
            return (ushort)((BitConverter.ToInt16(a, 0) + short.MaxValue + 1) % range);
        }

        public static uint NextUInt(this Random random)
        {
            byte[] a = new byte[4];
            random.NextBytes(a);
            return (uint)(BitConverter.ToInt32(a, 0) + int.MaxValue + 1);
        }
        public static uint NextUInt(this Random random, uint min)
        {
            BigInteger range = uint.MaxValue - min;
            byte[] a = new byte[4];
            random.NextBytes(a);
            return (uint)((BitConverter.ToInt32(a, 0) + int.MaxValue + 1) % range);
        }
        public static uint NextUInt(this Random random, uint min, uint max)
        {
            BigInteger range = max - min;
            byte[] a = new byte[4];
            random.NextBytes(a);
            return (uint)((BitConverter.ToInt32(a, 0) + int.MaxValue + 1) % range);
        }

        public static ulong NextULong(this Random random)
        {
            byte[] a = new byte[8];
            random.NextBytes(a);
            return (ulong)(BitConverter.ToInt64(a, 0) + long.MaxValue + 1);
        }
        public static ulong NextULong(this Random random, ulong min)
        {
            BigInteger range = ulong.MaxValue - min;
            byte[] a = new byte[8];
            random.NextBytes(a);
            return (ulong)((BitConverter.ToInt64(a, 0) + long.MaxValue + 1) % range);
        }
        public static ulong NextULong(this Random random, ulong min, ulong max)
        {
            BigInteger range = max - min;
            byte[] a = new byte[8];
            random.NextBytes(a);
            return (ulong)((BitConverter.ToInt64(a, 0) + long.MaxValue + 1) % range);
        }
    }
}
