using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student() { Id = 1 };
            Student stu2 = new Student() { Id = 2 };
            Student stu3 = new Student() { Id = 3 };

            Action action1 = new Action(stu1.DoHomework);
            Action action2 = new Action(stu2.DoHomework);
            Action action3 = new Action(stu3.DoHomework);

            //间接同步调用
            action1.Invoke();
            action2.Invoke();
            action3.Invoke();

            Console.WriteLine("=============================================");

            //间接（隐式）异步调用
            action1.BeginInvoke(null, null);
            action2.BeginInvoke(null, null);
            action3.BeginInvoke(null, null);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Main threading doing homework for {0} hour(s).", i + 1);
                Thread.Sleep(500);
            }
        }
    }

    class Student
    {
        public int Id { get; set; }
        
        public void DoHomework()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Student {0} has doing homework for {1} hour(s).", this.Id, i + 1);
                Thread.Sleep(500);
            }
        }
    }
}
