using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            int rand = r.Next(1, 101);

            int num = 0;
            uint tries = 0;

            Console.WriteLine("Познайте числото между 1 и 100.\n");

            while (num != rand)
            {
                while(!int.TryParse(Console.ReadLine(),out num))
                    Console.WriteLine("\nВъведете ЧИСЛО.");

                if (num > rand)
                    Console.WriteLine("\nНадолу\n");
                else
                    Console.WriteLine("\nНагоре\n");
                    ++tries;
            }
            Console.WriteLine("\nПознахте от {0} опита.\nЧислото е {1}.", tries,num);
            Console.ReadKey();
        }
    }
}
    