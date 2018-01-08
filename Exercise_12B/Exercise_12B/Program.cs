using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_12B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете броя на членовете на масива.");
            int n = int.Parse(Console.ReadLine());
            SortedSet arr = new SortedSet();
            Console.WriteLine("Въведете един по един членовете на масива.");
            for (int i = 0; i < n; i++)
            {
                arr.Add(decimal.Parse(Console.ReadLine()));
                Console.WriteLine(arr.ToString());
            }
            foreach (var element in arr.ToArray())
                Console.Write("{0}: ", element);
            Console.ReadLine();
        }
    }
}
