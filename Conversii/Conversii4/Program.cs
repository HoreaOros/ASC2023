using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Conversii4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int n;
            //try
            //{
            //    //n = int.Parse(Console.ReadLine());
            //    //ConvertFromDecimalToBinary(n);
            //    //ConvertFromDecimalToHex(n);
            //    //ConvertFromDecimal(n, 64);

            //}
            //catch (ArgumentException e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //int b = 0b10011;
            //Console.WriteLine(b);
            //int h = 0x2AB;
            //Console.WriteLine(h);

            string number = "10011";
            int fromBase = 2;
            Console.WriteLine(ConvertToDecimal(number, fromBase));


            number = "2AB";
            fromBase = 16;
            Console.WriteLine(ConvertToDecimal(number, fromBase));


            number = "2ABE";
            fromBase = 12;
            Console.WriteLine(ConvertToDecimal(number, fromBase));
        }

        private static int ConvertToDecimal(string number, int fromBase)
        {
            if (fromBase < 2 || fromBase > 16)
            {
                throw new ArgumentException("Baza nu este in intervalul [2, 16]");
            }
            string digits = "0123456789ABCDEF";

            int result = 0;

            int len = number.Length;
            foreach (char c in number)
            {
                int index = digits.IndexOf(c, 0, fromBase);
                if (index == -1) 
                {
                    throw new ArgumentException($"Numarul {number} invalid in baza {fromBase}");
                }
                // result = result * fromBase + index;
                result = result + index * (int)Math.Pow(fromBase, len - 1);
                len--;
            }
            return result;
        }

        private static void ConvertFromDecimal(int n, int toBase)
        {
            if (toBase > 16)
                throw new ArgumentException("toBase too large");

            Stack<int> stack = new Stack<int>();
            while (n > 0)
            {
                stack.Push(n % toBase);
                n = n / toBase;
            }
            while (stack.Count > 0)
            {
                int d = stack.Pop();
                if (d < 10)
                    Console.Write(d);
                else
                {
                    switch (d)
                    {
                        case 10:
                            Console.Write("A");
                            break;
                        case 11:
                            Console.Write("B");
                            break;
                        case 12:
                            Console.Write("C");
                            break;
                        case 13:
                            Console.Write("D");
                            break;
                        case 14:
                            Console.Write("E");
                            break;
                        case 15:
                            Console.Write("F");
                            break;
                    }
                }
            }
            Console.WriteLine();
        }

        private static void ConvertFromDecimalToHex(int n)
        {
            Stack<int> stack = new Stack<int>();
            while (n > 0)
            {
                stack.Push(n % 16);
                n = n / 16;
            }
            while (stack.Count > 0)
            {
                int d = stack.Pop();
                if(d < 10)
                    Console.Write(d);
                else
                {
                    switch (d) 
                    {
                        case 10:
                            Console.Write("A");
                            break;
                        case 11:
                            Console.Write("B");
                            break;
                        case 12:
                            Console.Write("C");
                            break;
                        case 13:
                            Console.Write("D");
                            break;
                        case 14:
                            Console.Write("E");
                            break;
                        case 15:
                            Console.Write("F");
                            break;
                    }
                }
            }
            Console.WriteLine();
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
                Console.Write(stack.Pop());
            }
            Console.WriteLine();
        }
    }
}
