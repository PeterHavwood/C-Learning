using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomizedTypeExchangeOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stone StoneBySea = new Stone();
            StoneBySea.Age = 5000;
            Monkey Wukong = StoneBySea;

            Console.WriteLine(Wukong.Age);
        }
    }

    class Stone
    {
        public static implicit operator Monkey(Stone s)
        {
            Monkey m = new Monkey();
            m.Age = s.Age / 500;
            return m;
        }

        public int Age;
    }

    class Monkey
    {
        public int Age;
    }
}
