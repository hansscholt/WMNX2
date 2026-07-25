using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMNX2
{
    class Tools
    {
        public static void Encode(byte[] data)
        {
            for (int a = 1; a < data.Length; a++)
            {
                data[a] = (byte)((data[a] - ((a * 1234567) >> 8)) ^ data[a - 1]);
            }
        }

        public static void Decode(byte[] data)
        {
            for (int a = data.Length - 1; a > 0; a--)
            {
                data[a] = (byte)((data[a] ^ data[a - 1]) + ((a * 1234567) >> 8));
            }
        }

        public static byte[] Combine(byte[] a1, byte[] a2, byte[] a3)
        {
            byte[] ret = new byte[a1.Length + a2.Length + a3.Length];
            Array.Copy(a1, 0, ret, 0, a1.Length);
            Array.Copy(a2, 0, ret, a1.Length, a2.Length);
            Array.Copy(a3, 0, ret, a1.Length + a2.Length, a3.Length);
            return ret;
        }
    }
}
