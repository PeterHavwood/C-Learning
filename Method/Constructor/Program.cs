using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weapon FrostMorn = new Weapon("FrostMorn", 114.514);
            Console.WriteLine(FrostMorn.Name);
            Console.WriteLine(FrostMorn.Damage);

            Weapon Nan = new Weapon();
            Console.WriteLine(Nan.Name);
            Console.WriteLine(Nan.Damage);
        }
    }

    class Weapon
    {
        public string Name;
        public double Damage;
        public int Level;

        // 两个构造器方法是 方法重载 的例子（形参不同）
        public Weapon()    // 无参数构造器（替换了默认构造器）
        {
            this.Name = "No Name";
            this.Damage = 0;
            this.Level = 1;
        }

        public Weapon(string name, double damage)      // 含参数构造器
        {
            this.Name = name;
            this.Damage = damage;
            this.Level = 1;
        }
    }
}
