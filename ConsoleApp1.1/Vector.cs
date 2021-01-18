using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._1
{
    class Vector
    {
        public double x1;
        public double y1;
        public double x2;
        public double y2;
        public double x3;
        public double y3;

        public Vector(double x1, double y1, double x2, double y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }
        public void Vyvod()
        {
            Console.WriteLine($"x1 = {x1}, y1 = {y1}, x2 = {x2}, y2 = {y2}; длина вектора = {Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)), 3)}");
        }
        public void TwoVector()
        {
            Console.WriteLine($"x1 = {x1 * 2}, y1 = {y1 * 2}, x2 = {x2 * 2}, y2 = {y2 * 2}; длина удвоенного вектора = {Math.Round(Math.Sqrt(Math.Pow(x2 * 2 - x1 * 2, 2) + Math.Pow(y2 * 2 - y1 * 2, 2)), 3)}");
        }
        public void Nowyi()
        {
            this.x3 = x2;
            this.y3 = y1;
            Console.WriteLine($"S = {Math.Round(0.5 * Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2)) * Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2)), 3)}");
        }
    }
}
