using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student Peter = new Student(1,"Peter");
            Citizen<string> PeterCitizen = new Citizen<string>() { ID = "##!!#" };

            Console.WriteLine(Peter.ID);
            Console.WriteLine(PeterCitizen.ID);
        }
    }

    // 实现接口时直接特化接口
    internal class Student : IUnique<int>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Student(int iD, string name)
        {
            ID = iD;
            Name = name;
        }
    }

    // 通过泛型类实现接口
    internal class Citizen<TID> : IUnique<TID>
    {
        public TID ID { get; set; }
    }

    // 泛型接口
    internal interface IUnique <TID>
    {
        TID ID { get; set; }
    }
}
