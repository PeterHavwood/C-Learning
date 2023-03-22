using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Racecar racecar = new Racecar();
            racecar.Start();
            racecar.Acceleration(10);
            Console.WriteLine(racecar.Speed);
            racecar.Stop();
            Console.WriteLine(racecar.Speed);
        }
    }

    internal interface IVehicle
    {
        int Speed { get; set; } //也可以声明属性
        void Start();
        void Stop();
        void Acceleration(int fuel);
    }

    abstract class Car : IVehicle
    {
        public int Speed { get; set; }

        abstract public void Acceleration(int fuel); //保留了一个仍有待实现

        public void Start()
        {
            Speed = 5;
        }

        public void Stop()
        {
            Speed = 0;
        }
    }

    class Racecar : Car
    {
        public override void Acceleration(int fuel)
        {
            Speed += fuel * 5;
        }
    }
}
