using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal Cost_i, Cost_u, Demand0, Demand_u, Price_umax, Profit_max;

            Console.WriteLine("Въведете Началните разходи:");
            Cost_i = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Въведете Разходите за 1 продукт:");
            Cost_u = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Въведете Началното търсене на продукта:");
            Demand0 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Въведете Търсенето на 1 бройка продукт:");
            Demand_u = decimal.Parse(Console.ReadLine());

            Price_umax = (Cost_u * Demand_u + Demand0) / (2 * Demand_u);
            Profit_max = -Demand_u * Price_umax * Price_umax + (Cost_u * Demand_u + Demand0) * Price_umax - Cost_u * Demand0 - Cost_i;

            Console.WriteLine("Profit(max) = {0}\nPrice_unit(max) = {1}",Math.Round(Profit_max,2).ToString(), Math.Round(Price_umax,2).ToString());
            Console.ReadLine();
        }
    }
}
