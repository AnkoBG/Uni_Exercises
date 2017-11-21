using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static int rows, cols;
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете редовете на матрицата :");
            rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведете колоните на матрицата :");
            cols = int.Parse(Console.ReadLine());
            int[,] arr = new int[rows, cols];
            Console.WriteLine("Въведете стойностите на масива ред по ред:");
            for (int i = 0; i < rows; i++)
            {
                int counter = 0;
                string[] sn = Console.ReadLine().Split();
                foreach(string n in sn)
                {
                    arr[i,counter] = int.Parse(n);
                    counter++;
                }
            }
            int colmax = 0;
            int rowmax = 0;
            for(int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (arr[i,j] >= arr[rowmax, colmax])
                    {
                        colmax = j;
                        rowmax = i;
                    }
                }
            }
            Console.WriteLine("Най голямото число е {0}, със координати {1},{2}.",arr[rowmax,colmax],colmax + 1,rowmax + 1);
            Console.ReadLine();
        }
    }
}
