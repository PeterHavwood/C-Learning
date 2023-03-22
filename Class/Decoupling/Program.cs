using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoupling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Character Peter = new Character();
            Peter.GetWeapon(new Bat(5));
            Peter.Strengthen(3);
            Peter.Attack();
        }
    }

    class Character
    {
        private IWeapon weapon;
        
        public void GetWeapon(IWeapon weapon)
        {
            this.weapon = weapon;
        }

        public void Attack()
        {
            this.weapon?.Attack();
        }

        public void Strengthen(int power)
        {
            this.weapon?.Strengthen(power);    
        }
    }

    interface IWeapon
    {
        int Damage { get; set; }
        void Attack();
        void Strengthen(int power);
    }

    class Gun : IWeapon
    {
        public int Damage { get; set; }

        public Gun(int damage) { Damage = damage; }

        public void Attack()
        {
            Console.WriteLine("Pa! Cause {0} damage!", Damage);
        }

        public void Strengthen(int power)
        {
            Damage += power;
            Console.WriteLine("The gun has strengthen the damage to {0}!", Damage);
        }
    }

    class Bat : IWeapon
    {
        public int Damage { get; set; }

        public Bat(int damage) { Damage = damage; }

        public void Attack()
        {
            Console.WriteLine("Pong! Cause {0} damage!", Damage);
        }

        public void Strengthen(int power)
        {
            Damage += power;
            Console.WriteLine("The bat has strengthen the damage to {0}!", Damage);
        }
    }
}
