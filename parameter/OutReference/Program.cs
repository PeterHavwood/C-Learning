using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutReference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;  // 输出参数传递的变量并不要求有赋值，相反，其方法体中必须要有赋值
            string input = Console.ReadLine();
            bool inputIsRight = Int32.TryParse(input, out x);
            if(inputIsRight )
            {
                Console.WriteLine(x);
            }
        }
    }
}
