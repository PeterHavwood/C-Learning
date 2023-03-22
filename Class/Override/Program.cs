using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gun gun = new Gun();
            gun.Damage = 10;
            gun.attack();

            Pistol pistol = new Pistol();
            pistol.Damage = 10; // 仍然可以写入，因为继承后的访问修饰符无法被改变
        }
    }

    internal class Weapon
    {
        private int damage=10;
        public virtual int Damage { get { return damage; } set { damage = value; } }

        public virtual void attack()
        {
            Console.WriteLine("Cause "+Damage.ToString());
        }
    }

    internal class Gun : Weapon
    {
        public override void attack()   // Override也包含了virtual的含义
        {
            Console.WriteLine("Pong! Cause " + (Damage*3).ToString());
        }
    }

    internal class Pistol : Gun
    {
        public override int Damage { get { return 5; } }

        public override void attack()
        {
            Console.WriteLine("Pong! Cause " + Damage.ToString());
        }
    }
}
