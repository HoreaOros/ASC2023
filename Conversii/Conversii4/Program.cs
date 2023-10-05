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
            int n;
            try
            {
                n = int.Parse(Console.ReadLine());
                //ConvertFromDecimalToBinary(n);
                //ConvertFromDecimalToHex(n);
                ConvertFromDecimal(n, 64);
                
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
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
