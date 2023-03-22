using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tyr_catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a;
            string b;
            a = Console.ReadLine();
            b = Console.ReadLine();
            
            int result = Calculator.Add(a, b);
            Console.WriteLine(result);
        }
    }

    class Calculator
    {
        public static int Add(string a, string b)
        {
            // 不能在try的块语句中声明：超出作用域
            int num_a = 0;
            int num_b = 0;
            int result = 0;
            bool isWrong = false;

            try
            {
                num_a = Int32.Parse(a);
                num_b = Int32.Parse(b);
            }
            catch(ArgumentNullException)
            {
                Console.WriteLine("There's nothing entered.");
                isWrong = true;
            }
            catch(FormatException)
            {
                Console.WriteLine("Please enter a number.");
                isWrong = true;
            }
            catch(OverflowException)
            {
                Console.WriteLine("The number is out of range of Int32.");
                isWrong = true;
            }

            try
            {
                result = checked(num_a + num_b);
            }
            catch(OverflowException)
            {
                Console.WriteLine("The sum is out of range of Int32.");
                isWrong = true;
            }
            finally
            {
                if (isWrong)
                    Console.WriteLine("The function goes with something wrong.");
                else
                    Console.WriteLine("The function goes well!");
            }


            return num_a+ num_b;
        }
    }
}
