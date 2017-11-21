using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static int[] array = new int[10000];
        static int[] numbers = new int[array.Length];
        static Random rand = new Random();
        static int counter = 0;
        static string result = "";
        static int num;
        static void Main(string[] args)
        {
            Initialization();
            CalcAndDisplay();
        }
        static void Initialization()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1, 101);
            }
        }
        static int GetNumber()
        {
            Console.WriteLine("Въведете числото което търсите:");
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Въведете целочислена стойност");
            }
            return num;
        }
        static void CalcAndDisplay()
        {
            int num = GetNumber();
            for (int index = 0; index < array.Length; index++)
            {
                if (array[index] == num)
                {
                    numbers[counter] = index + 1;
                    counter++;
                }
            }
            for (int i = 0; i < counter; i++)
            {
                result += " " + numbers[i].ToString() + ",";
            }
            Console.Write("Броя съвпадения са {0} а позициите им са:", counter);
            Console.WriteLine(result);
            Console.ReadLine();
            CalcAndDisplay();
        }
    }
}
