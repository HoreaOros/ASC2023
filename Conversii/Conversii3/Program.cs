using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversii3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());

            //ConvertFromDecimalToBinary(n);
            //ConvertFromDecimalToHex(n);



            //int number = 0b10011;
            //Console.WriteLine(number);
            //int hexNumber = 0x2AB;
            //Console.WriteLine(hexNumber);

            //string number = "10012";
            //int fromBase = 3;
            //Console.WriteLine(ConvertToDecimal(number, fromBase));

            //number = "2AB";
            //fromBase = 16;
            //Console.WriteLine(ConvertToDecimal(number, fromBase));


            Console.WriteLine(C9(8567));

        }


        /// <summary>
        /// Calculeaza complementul fata de 9 al unui numar
        /// </summary>
        /// <param name="v">Numărul pentru care se calculează complementul fata de 9</param>
        /// <returns>Complementul fata de 9 al parametrului</returns>
        /// <example>8567 ==> 1432</example>
        private static int C9(int v)
        {
            int result = 0, p = 1, cifra;
            while (v > 0)
            {
                cifra = v % 10;
                v = v / 10;
                result = result + (9 - cifra) * p;
                p = p * 10;
            }
            return result;
        }

        /// <summary>
        /// Convertește un număr din baza fromBase in baza 10
        /// </summary>
        /// <param name="number">Numărul care se convertește</param>
        /// <param name="fromBase">Baza din care se face conversia</param>
        private static int ConvertToDecimal(string number, int fromBase)
        {
            if (fromBase < 2 || fromBase > 16)
                throw new ArgumentException("Baza nu este in intervalul [2,16]");

            string digits = "0123456789ABCDEF";
            int result = 0;
            foreach (char c in number)
            {
                int index = digits.IndexOf(c, 0, fromBase);
                if (index == -1)
                    throw new ArgumentException($"Numărul nu este corect in baza {fromBase}");
                result = result * fromBase + index; 
            }

            return result;
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
                if (d < 10)
                {
                    Console.Write(d);
                }
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
