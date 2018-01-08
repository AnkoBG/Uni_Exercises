using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_13B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете броя на членовете на масива.");
            int n = int.Parse(Console.ReadLine());
            SortedArray arr = new SortedArray();
            Console.WriteLine("Въведете един по един членовете на масива.");
            for (int i = 0; i < n; i++)
            {
                arr.Add(decimal.Parse(Console.ReadLine()));
                Console.WriteLine(arr.ToString()); //For debugging purposes
            }
            arr.BubbleSort();
            Console.WriteLine(arr.ToString());
            Console.ReadLine();
        }
    }
}
