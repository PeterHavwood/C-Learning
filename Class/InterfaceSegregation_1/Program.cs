using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 3, 4, 5 };
            ArrayList nums2 = new ArrayList{ 1, 2, 3, 4, 5 };
            EnumOnlyCollection nums3 = new EnumOnlyCollection(nums1);

            Console.WriteLine(Sum(nums3));
        }


        internal static int Sum(IEnumerable nums)
        {
            int sum = 0;
            foreach (var item in nums)
            {
                sum += (int)item;
            }
            return sum;
        }
    }

    // 自定义一个类型，只实现IEnumerable接口而不实现ICollection接口
    class EnumOnlyCollection : IEnumerable
    {
        private int[] ints;
        public EnumOnlyCollection(int[] ints) 
        {
            this.ints = ints; 
        }

        // IEnumerable接口只实现放回迭代器的方法
        public IEnumerator GetEnumerator()
        {
            return new Enumerator(this);
        }

        // 自定义迭代器类实现IEnumerator接口, 作为成员类防止污染命名空间
        public class Enumerator : IEnumerator
        {
            private EnumOnlyCollection collection;
            private int head;
            public Enumerator(EnumOnlyCollection collection)
            {
                this.collection = collection;
                head = -1;
            }

            public object Current
            {
                get
                {
                    return collection.ints[head]; 
                }
            }

            public bool MoveNext()
            {
                if(++head < collection.ints.Length)
                {
                    return true;
                }
                else 
                {
                    return false; 
                }
            }

            public void Reset()
            {
                head = -1;
            }
        }
    }

}
