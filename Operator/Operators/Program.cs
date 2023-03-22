using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // typeof
            Type IntType = typeof(int);
            Console.WriteLine(IntType.Name);

            // - + ~
            int x = int.MinValue;
            int y = -x;
            int z = ~x;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            Console.WriteLine("可以把最前面一位理解为符号位");

            // 由Convert类的静态方法ToString返回字符串，并使用string类的方法PadLeft
            string StrX = Convert.ToString(x,2).PadLeft(32,'0');
            string StrY = Convert.ToString(y, 2).PadLeft(32, '0');
            string StrZ = Convert.ToString(z, 2).PadLeft(32, '0');
            Console.WriteLine(StrX);
            Console.WriteLine(StrY);
            Console.WriteLine(StrZ);

            // ++ -- 前置时首先执行该操作符；后置时首先执行左边的操作符
            int a = 100;
            int b = a--;
            int c = 1+a--;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            // 类型转换 cast (T)x
            uint m = ushort.MaxValue + 1;
            Console.WriteLine(sizeof(ushort));
            ushort n = (ushort)m;
            string StrM = Convert.ToString(m, 2);
            string StrN = Convert.ToString(n, 2);
            Console.WriteLine(n);
            Console.WriteLine(StrM);
            Console.WriteLine(StrN);
        }
    }
}
