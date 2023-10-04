using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Conversii
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar (in baza 10)");
            int n;
            n = int.Parse(Console.ReadLine());
            ConvertFrom10ToBinary(n);
            ConvertFrom10ToHex(n);
        }

        private static void ConvertFrom10ToHex(int n)
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
                    switch(d)
                    {
                        case 10:
                            Console.Write("A"); break;                           break;
                        case 11:
                            Console.Write("B"); break;  
                        case 12:    
                            Console.Write("C"); break;
                        case 13:
                            Console.Write("D"); break;     
                        case 14:
                            Console.Write("E"); break;
                        case 15:
                            Console.Write("F"); break;
                    }
                }
            }
            Console.WriteLine();
        }

        private static void ConvertFrom10ToBinary(int n)
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
