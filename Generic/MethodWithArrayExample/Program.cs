using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodWithArrayExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 3, 2, 4, 5, 2, 45, 4 };
            Console.WriteLine(string.Join(",",SortFormMaxToMin(a))); //自动判断类型
        }

        public static T[] SortFormMaxToMin<T>(T[] sortingArray) where T : IComparable // 约束泛型，使得它可以被比较
        {
            T[] result = sortingArray;

            for(int i = 0; i < sortingArray.Length; i++)
            {
                T maxValue = result[i];
                int maxIndex = i;
                for(int j = i+1; j < sortingArray.Length; j++)
                {
                    if (result[j].CompareTo(maxValue) > 0)
                    {
                        maxValue = result[j];
                        maxIndex = j;
                    }
                }
                result[maxIndex] = result[i];
                result[i] = maxValue;
            }

            return result;
        }
    }
}
