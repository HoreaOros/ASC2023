using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint n = 1258479u;
            ShowBits(n, 32);

            int pos = 28;
        
            Console.WriteLine($"Bitul de pe pozitia: {pos} are valoarea {GetBit(n, pos)}");
            
            SetBit(ref n, pos);
            ShowBits(n, 32);

            ResetBit(ref n, pos)
        }

        private static void ResetBit(ref uint n, int pos)
        {
            throw new NotImplementedException();
        }


        // 0101010011111
        // 0000001000000  |
        private static void SetBit(ref uint n, int pos)
        {
            n = n | (1u << pos);
        }

        private static uint GetBit(uint n, int pos)
        {
            return (n >> pos) & 1u;
        }

        // 101010101010
        // 100000000000  &
        // 010000000000
        // 001000000000
        // .........
        private static void ShowBits(uint n, int pad)
        {
            for (int i = pad - 1; i >= 0; i--)
            {
                Console.Write(((n & (1u << i)) != 0)?1:0);
            }
            Console.WriteLine();
        }
    }
}
