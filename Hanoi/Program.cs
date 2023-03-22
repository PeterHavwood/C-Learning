using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            int result;
            Hanoi m = new Hanoi();

            result = m.PrintResult(n);
            m.PrintMethod(n, 'a', 'b', 'c');

            Console.WriteLine(result);
        }
    }

    class Hanoi
    {
        public int PrintResult(int n)
        {
            if(n == 2)
            {
                return 3;
            }
            else
            {
                return 2 * PrintResult(n - 1) + 1;
            }
        }

        public void PrintMethod(int n,char StartPosition, char GoalPosition, char MediumPosition) 
        {
            if(n == 1)
            {
                Console.WriteLine("将" + 1 + "从" + StartPosition + "移动到" + GoalPosition);
            }
            else
            {
                PrintMethod(n - 1, StartPosition, MediumPosition, GoalPosition);
                Console.WriteLine("将" + n + "从" + StartPosition + "移动到" + GoalPosition);
                PrintMethod(n - 1, MediumPosition, GoalPosition, StartPosition);
            }
        }
    }
}
