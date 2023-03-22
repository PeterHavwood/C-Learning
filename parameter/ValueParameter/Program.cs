using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student oldStu = new Student(12,"Peter");
            Console.WriteLine(oldStu.GetHashCode() + " " + oldStu.name);
            ChangeName(oldStu);
            // 在这里可以发现原有对象也被改变了
            Console.WriteLine(oldStu.GetHashCode() + " " + oldStu.name);
        }

        static void ChangeName(Student student)
        {
            // student和oldStu指向的局部变量地址不同，但他们局部变量所储存的位置都是同一个对象在堆中的地址
            student.name = "Brown";
            Console.WriteLine(student.GetHashCode()+" "+student.name);
        }
    }

    class Student
    {
        public int id;
        public string name;
        
        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
