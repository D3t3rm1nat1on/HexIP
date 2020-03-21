using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static string Hex(int a)
        {
            string str = Convert.ToString(a, 2);
            if (str.Length < 8)
                str = new string('0', 8 - str.Length) + str;
            return str;
        }

        static void Main(string[] args)
        {
            int N = 2;
            int M = 5;

            Console.WriteLine($"192.168.{N}.{2 * M}\t {Hex(N)}.{Hex(2 * M)}");
            Console.WriteLine($"192.168.{N}.{3 * M}\t {Hex(N)}.{Hex(3 * M)}");
            Console.WriteLine($"192.168.{N}.{4 * M}\t {Hex(N)}.{Hex(4 * M)}");
            Console.WriteLine($"192.168.{M}.{15 * N}\t {Hex(M)}.{Hex(15 * M)}");
            Console.WriteLine($"192.168.{M}.{16 * N}\t {Hex(M)}.{Hex(16 * M)}");
            Console.WriteLine($"192.168.{M}.{18 * N}\t {Hex(M)}.{Hex(18 * M)}");
        }
    }
}