using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("ThisJustForGetType");

            Type t = student.GetType();
            object o = Activator.CreateInstance(t,"Peter");
            MethodInfo ReportMet = t.GetMethod("Report");
            MethodInfo AddMet = t.GetMethod("Add");
            ReportMet.Invoke(o, null);
            AddMet.Invoke(0, new object[] { 1, 2 });
        }
    }

    internal class Student
    {
        public string name;
        public Student(string name)
        {
            this.name = name;
        }

        public void Report()
        {
            Console.WriteLine("My name is " + name);
        }
        public int Add(int x, int y)
        {
            return x + y;
        }
    }
}
