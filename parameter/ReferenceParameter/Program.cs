using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceParameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            addOne(ref x);
            Console.WriteLine(x);
        }

        static void addOne(ref int x)
        {
            x++;
        }
    }
}
