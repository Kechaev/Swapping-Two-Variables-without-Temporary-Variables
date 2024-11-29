using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SwappingTwoVariablesNoTemp
{
    class Program
    {
        static void Main(string[] args)
        {
            IntegerSwap();
            Console.WriteLine();
            CharSwap();
            Console.WriteLine();
            StringSwap();
            Console.ReadLine();
        }

        static void IntegerSwap()
        {
            int var1 = 32;
            int var2 = 27;

            Console.WriteLine("Initial:");
            Console.WriteLine($"1. {var1}\n2. {var2}");

            var1 = var1 ^ var2;
            var2 = var2 ^ var1;
            var1 = var1 ^ var2;

            Console.WriteLine("Post-swap:");
            Console.WriteLine($"1. {var1}\n2. {var2}");
        }

        static void CharSwap()
        {
            char var1 = 'a';
            char var2 = 'b';

            int bits1 = Convert.ToInt32(var1);
            int bits2 = Convert.ToInt32(var2);

            Console.WriteLine("Initial:");
            Console.WriteLine($"1. {var1}\n2. {var2}");
            Console.WriteLine($"1. {bits1}\n2. {bits2}");

            bits1 = bits1 ^ bits2;
            bits2 = bits2 ^ bits1;
            bits1 = bits1 ^ bits2;

            var1 = Convert.ToChar(bits1);
            var2 = Convert.ToChar(bits2);

            Console.WriteLine("Post-swap:");
            Console.WriteLine($"1. {var1}\n2. {var2}");
        }

        static void StringSwap()
        {
            string var1 = "Hello World";
            string var2 = "Program";
            
            int max = Math.Max(var1.Length, var2.Length);

            char[] chars1 = new char[max];
            char[] chars2 = new char[max];

            for (int i = 0; i < max; i++)
            {
                if (i < var1.Length)
                {
                    chars1[i] = var1[i];
                }
                if (i < var2.Length)
                {
                    chars2[i] = var2[i];
                }
            }

            int[] ints1 = new int[max];
            int[] ints2 = new int[max];

            for (int i = 0; i < max; i++)
            {
                ints1[i] = Convert.ToInt32(chars1[i]);
                ints2[i] = Convert.ToInt32(chars2[i]);
            }

            Console.WriteLine("Initial:");
            foreach (char c in chars1)
            {
                Console.Write(c);
            }
            Console.WriteLine();
            foreach (char c in chars2)
            {
                Console.Write(c);
            }
            Console.WriteLine();

            for (int i = 0; i < max; i++)
            {
                ints1[i] = ints1[i] ^ ints2[i];
            }
            for (int i = 0; i < max; i++)
            {
                ints2[i] = ints2[i] ^ ints1[i];
            }
            for (int i = 0; i < max; i++)
            {
                ints1[i] = ints1[i] ^ ints2[i];
            }

            for (int i = 0; i < max; i++)
            {
                chars1[i] = Convert.ToChar(ints1[i]);
                chars2[i] = Convert.ToChar(ints2[i]);
            }

            var1 = "";
            var2 = "";

            for (int i = 0; i < max; i++)
            {
                var1 += chars1[i];
                var2 += chars2[i];
            }

            Console.WriteLine("Post-swap:");
            foreach (char c in chars1)
            {
                Console.Write(c);
            }
            Console.WriteLine();
            foreach (char c in chars2)
            {
                Console.Write(c);
            }
            Console.WriteLine();
        }
    }
}
