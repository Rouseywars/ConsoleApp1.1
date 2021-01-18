using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._1
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите координату x1: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Введите координату y1: ");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("Введите координату x2: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Введите координату y2: ");
            double y2 = double.Parse(Console.ReadLine());
            Vector Luboe = new Vector(x1, y1, x2, y2);
            Luboe.Vyvod();
            Luboe.TwoVector();
            Luboe.Nowyi();
            Console.ReadKey();
        }
    }
}
