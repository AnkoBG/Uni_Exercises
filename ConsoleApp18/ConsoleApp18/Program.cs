using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 1;
            int i = 0;

            using (FileStream writer = new FileStream("important.txt", FileMode.Create))

            {
                using (StreamWriter wr = new StreamWriter(writer))
                { 
                    do
                    {
                        i++;
                        string s = i + ". Аз ще програмирам по 6 часа на седмица.";
                        wr.WriteLine(s);
                        a += 1;
                    }
                    while (a <= 1000);
            
            }
                   
                Console.ReadLine();
            }
        }
    }
}
