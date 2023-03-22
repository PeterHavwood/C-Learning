using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @new
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // new的作用是在堆内存中构造一个类的实例，调用其实例构造器（括号），还可以调用其初始化器（花括号），并返回一个内存地址给引用变量
            character King = new character(){Level = 100, Name = "Elden King" };

            // new可以与var配合创建匿名类型
            var Weapon = new { Name = "FrostKiller", Damage = 100, Endurance = 0.9};
            Console.WriteLine(Weapon.GetType().Name);
            Console.WriteLine(Weapon.Name);
        }
    }

    class character
    {
        public int Level;
        public string Name;
    }
}
