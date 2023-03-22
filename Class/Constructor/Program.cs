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
            BedRoom bedroom = new BedRoom(12);
            bedroom.TellArea();
        }
    }

    class Room
    {
        public Room(int a)
        {
            area = a;
        }

        public int area;
        public void TellArea()
        {
            Console.WriteLine(area);
        }
    }

    class BedRoom : Room
    {
        public BedRoom(int a) : base(a)  // 不加 ':base(a)' 会报错：构造器无法继承。
        {
        }
    }
}
