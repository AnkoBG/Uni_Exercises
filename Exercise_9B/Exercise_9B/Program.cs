using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8B
{
    class Program
    {
        static decimal[,] arr;

        static int choice;

        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("\n1. Въвеждане на матрица nxn, 0<n<1000");
                Console.WriteLine("2. Извеждане на сумата на елементите по главния диагонал");
                Console.WriteLine("3. Намиране на най-малкия елемент по вторичния и диагонал");
                Console.WriteLine("4. Проверка дали матрицата е диагонална");
                Console.WriteLine("0. Изход");

                choice = ReadInt("Въведете команда: ");

                switch (choice)
                {
                    case 1:
                        PopulateMatrix();
                        break;

                    case 2:
                        if (MatrixExists(arr))
                        {
                            Console.WriteLine("Сумата по главния диагонал е: {0}", MainDiagonalSum(arr));
                        }
                        else
                            Console.WriteLine("Моля първо въведете матрица");
                        break;

                    case 3:
                        if (MatrixExists(arr))
                        {
                            Console.WriteLine("Най малкото число по вторичния диагонал е: {0}", SecondaryDiagonalMinValue(arr));
                        }
                        else
                            Console.WriteLine("Моля първо въведете матрица");
                        break;

                    case 4:
                        if (MatrixExists(arr))
                        {
                            if (MatrixIsDiagonal(arr))
                                Console.WriteLine("Матрицата е диагонална");
                            else
                                Console.WriteLine("Матрицата не е диагонална");
                        }
                        else
                            Console.WriteLine("Моля първо въведете матрица");
                        break;
                }
            }
            while (choice != 0);
        }

        static void PopulateMatrix()
        {
            int n = ReadInt("Въведете размера на матрицата:");
            arr = new decimal[n, n];
            Console.WriteLine("Въведете елементите на матрицата ред по ред:");
            for (int i = 0; i < n; i++)
            {
                int counter = 0;
                string[] sn = Console.ReadLine().Split();
                foreach (string m in sn)
                {
                    arr[i, counter] = int.Parse(m);
                    counter++;
                }
            }
        }
        static bool MatrixExists(decimal[,] arr)
        {
            if(arr == null)
            {
                return false;
            }
            return true;
        }
        static decimal MainDiagonalSum(decimal[,] array)
        {
            decimal sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
                sum += array[i, i];
            return sum;
        }
        static decimal SecondaryDiagonalMinValue(decimal[,] array)
        {
            decimal minValue = decimal.MaxValue;
            for (int i = 0; i < array.GetLength(0); i++)
                if (minValue > array[array.GetLength(0) - i - 1, i])
                    minValue = array[array.GetLength(0) - i - 1, i];
            return minValue;
        }
        static bool MatrixIsDiagonal(decimal[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    if (i!=j)
                    {
                        if (array[i, j] != 0)
                            return false;
                    }
                }
            }
            return true;
        }
        static int ReadInt(string prompt)
        {
            int input;
            bool success;
            do
            {
                Console.WriteLine(prompt);
                success = int.TryParse(Console.ReadLine(), out input);
                if (!success)
                {
                    Console.WriteLine("Моля въведете число!");
                }
            }
            while (!success);
            return input;
        }
    }
}
