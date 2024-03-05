using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {         
            Console.WriteLine("Введите значение x:");
            double x = double.Parse(Console.ReadLine());

            double result = 8 * Math.Sin(2 * x) - Math.Cos(2 * x);

            Console.WriteLine("Результат вычисления функции:" , result);
            Console.ReadKey();
        }
    }
}
