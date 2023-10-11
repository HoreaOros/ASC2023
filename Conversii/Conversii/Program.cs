using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Conversii
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Introduceti un numar (in baza 10)");
            //int n;
            //n = int.Parse(Console.ReadLine());
            //ConvertFrom10ToBinary(n);
            //ConvertFrom10ToHex(n);

            int fromBase = 2;
            string number = "10110";
            ConvertToBase10(fromBase, number);
            Console.WriteLine($"Numarul {number} convertit in baza 10 este {ConvertToBase10(fromBase, number)}");


            fromBase = 16;
            number = "CAFE";
            Console.WriteLine($"Numarul {number} convertit in baza 10 este {ConvertToBase10(fromBase, number)}");

            //fromBase = 12;
            //number = "CAFE";
            //Console.WriteLine($"Numarul {number} convertit in baza 10 este {ConvertToBase10(fromBase, number)}");

            fromBase = 17;
            number = "CAFE";
            Console.WriteLine($"Numarul {number} convertit in baza 10 este {ConvertToBase10(fromBase, number)}");


            // Complement fata de 9
            Console.WriteLine(C9(1259));
        }

        /// <summary>
        /// Calculeaza complementul fata de 9 al argumentului
        /// </summary>
        /// <param name="v">Numarul pentru care calculam complementul</param>
        /// <returns>Complementul fata de 9 al argumentului</returns>
        /// <example>1259 => 8740</example>
        private static int C9(int v)
        {
            // TODO : implementare complement fata de 9
        }


        /// <summary>
        /// Converteste un numar dintr-o baza sursa in baza 10
        /// </summary>
        /// <param name="fromBase">Baza sursa</param>
        /// <param name="number">Numarul in baza sursa</param>
        private static int ConvertToBase10(int fromBase, string number)
        {
            if (fromBase < 2 || fromBase > 16)
                throw new ArgumentException("Baza sursa este <out of range>");
            string digits = "0123456789ABCDEF";
            int result = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int baseValue;
                int digit = digits.IndexOf(number[i], 0, fromBase);
                if (digit == -1)
                    throw new ArgumentException("Numarul nu este corect");
                result = result * fromBase + digit;
            }

            return result;
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
