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
            //int n;
            //Console.WriteLine("Introduceți un număr in baza 10:");
            //n = int.Parse(Console.ReadLine());

            //ConvertFromDecimalToBinary(n);
            //ConvertFromDecimalToHex(n);


            string number = "2AB";
            int fromBase = 16;
            Console.WriteLine(ConvertToDecimal(number, fromBase));


            number = "10011";
            fromBase = 2;
            Console.WriteLine(ConvertToDecimal(number, fromBase));


            number = "10021";
            fromBase = 2;
            Console.WriteLine(ConvertToDecimal(number, fromBase));


        }

        /// <summary>
        /// Convertește un număr din baza fromBase (2-16) in baza 10
        /// </summary>
        /// <param name="number">Numărul care se convertește</param>
        /// <param name="fromBase">Baza din care se face conversia</param>
        /// <returns>Valoare lui number in baza 10</returns>
        private static int ConvertToDecimal(string number, int fromBase)
        {
            int result = 0;

            if (fromBase < 2 || fromBase > 16)
                throw new ArgumentException("Baza este in afara limitelor acceptate");

            string digits = "0123456789ABCDEF";


            foreach (char item in number)
            {
                int index = digits.IndexOf(item, 0, fromBase);
                if (index == -1)
                    throw new ArgumentException($"Numărul nu este corect în baza {fromBase}");

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
                        default:
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
                Console.Write($"{stack.Pop()}");
            }
            Console.WriteLine();
        }
    }
}
