using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        private static int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 11, 15 };
        static void Main(string[] args)
        {
            int temp;
            for(int i = 0; i < arr.Length/2; i++)
            {
                temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }
            Console.Write("Членовете са:");
            foreach (int num in arr)
            {
                Console.Write(" {0}", num);
            }
            Console.ReadLine();
        }
    }
}
