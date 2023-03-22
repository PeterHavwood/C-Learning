using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace params_name_optionalParameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 使用params关键字后可以输入任意多参数（为一个数组中成员）
            int x = SumIntArray(1,2,3);
            Console.WriteLine(x);
            // 下面的方法重载也使用了params关键字（最后三个参数）
            Console.WriteLine("{0}+{1}={2}",1,2,3);

            // 具名参数
            Console.WriteLine(NumAddString(num:1, str:"2"));

            //可选参数，省略后使用默认值
            Console.WriteLine(NumAddString());
        }

        static int SumIntArray(params int[] intArray)
        {
            int result = 0;
            foreach (var x in intArray)
            {
                result += x;
            }
            return result;
        }

        static int NumAddString(int num = 0, string str = "0")
        {
            return num + Int32.Parse(str);
        }
    }
}
