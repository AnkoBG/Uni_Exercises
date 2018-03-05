using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете число.");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }
            Console.ReadLine();

        }
        static ulong Fibonacci(int t, int c = 1, ulong n1 = 0, ulong n2 = 1)
        {
            if (t == c)
                return n1;
            return Fibonacci(t, ++c, n2, n1 + n2);
        }
    }
}

