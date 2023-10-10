using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _1010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int age;
            Console.WriteLine("How old are you?");
            try
            {
                //age = int.Parse(Console.ReadLine());
                age = 42;
                Console.WriteLine($"You are {age} years old.");
                Console.WriteLine("You are {0} years old.", age);
                Console.WriteLine("You are " + age + " years old.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }


            // variabila = nume pentru o locatie de memorie
            // int - tip de date System.Int32
            Console.WriteLine($"[{int.MinValue}, {int.MaxValue}]");
            // uint - intreg fara semn
            Console.WriteLine($"[{uint.MinValue}, {uint.MaxValue}]");
            // short - tip de date intreg pe 16 biti cu semn
            Console.WriteLine($"[{short.MinValue}, {short.MaxValue}]");
            // ushort - intreg fara semn pe 16 biti
            Console.WriteLine($"[{ushort.MinValue}, {ushort.MaxValue}]");
            // byte - tip de date intreg pe 8 biti fara semn
            Console.WriteLine($"[{byte.MinValue}, {byte.MaxValue}]");
            // sbyte - intreg cu semn pe 8 biti
            Console.WriteLine($"[{sbyte.MinValue}, {sbyte.MaxValue}]");
            // long - tip de date intreg pe 64 biti fara semn
            Console.WriteLine($"[{long.MinValue}, {long.MaxValue}]");
            // ulong - intreg cu semn pe 8 biti
            Console.WriteLine($"[{ulong.MinValue}, {ulong.MaxValue}]");
            BigInteger b1 = BigInteger.Parse("123456782345678345673456734545");
            BigInteger b2 = BigInteger.Parse("765425678765434567654345678988");
            Console.WriteLine(b1 + b2);

            float f = 3.14f; // 32 biti
            double d = 3.14; // 64 biti
            Console.WriteLine($"[{float.MinValue},{float.MaxValue}]");
            
            float suma = 0.0f;
            for (int i = 0; i < 1000000; i++)
            {
                suma = suma + 0.001f;
            }
            Console.WriteLine($"Suma este: {suma}");


            DateTime z2 = DateTime.Now;
            DateTime z1 = new DateTime(2005, 10, 31);
            Console.WriteLine(z2.Subtract(z1).TotalDays);
        }
    }
}
