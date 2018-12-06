using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extlib.Types
{
    public struct MultiArray<T>
    {
        private T[][] arrays;
        private long length;

        public MultiArray(T[][] arrays,  long length)
        {
            foreach (T[] array in arrays)
            {
                if (array.Length > length)
                    throw new IndexOutOfRangeException();
            }

            this.arrays = arrays;
            this.length = length;
        }

        public T[][] Get(long index)
        {
            return null;
        }
    }
}
