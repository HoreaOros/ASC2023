using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversii2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Introduceti un numar in baza 10:");
            n = int.Parse(Console.ReadLine());

            ConvertFromDecimalToBinary(n);


        }

        private static void ConvertFromDecimalToBinary(int n)
        {
            Stack<int> stack = new Stack<int>();
            while (n > 0)
            {
                stack.Push(n % 2);
                n = n / 2;
            }


            while (stack.Count > 0)
            {
                Console.Write($"{stack.Pop()}");
            }
            Console.WriteLine();
        }
    }
}
