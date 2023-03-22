using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDebug
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.GetConeVolume(1.3, 4.2));  // 在这里试试 逐语句 F11
        }
    }

    class Calculator
    {
        public static double GetCircleArea(double r)
        {
            double result = Math.PI * r * r;    // 在这里试试 跳出 shift + F11
            return result;
        }

        public static double GetCylindarVolume(double r, double h)
        {
            double result = GetCircleArea(r) * h;
            return result;
        }

        public static double GetConeVolume(double r, double h)
        {
            double result = GetCylindarVolume(r, h) / 3;    // 在这里试试 逐过程 F10
            return result;
        }
    }
}
