using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace field
{
    enum sex
    {
        male, female
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Character Peter = new Character("Peter", sex.male);

            Peter.level++;
            // Peter.characterSex = sex.female; 只读字段无法在类之外被修改
            Console.WriteLine(Character.amount);
            Console.WriteLine(Peter.level);
        }
    }

    class Character
    {
        // 静态字段
        public static int amount;
        // 静态只读字段
        public static readonly int maxAmount;
        // 实例字段
        public int level;
        public string name;
        // 实例只读字段
        public readonly sex characterSex;

        public Character(string name, sex csex)
        {
            this.level = 1;
            this.name = name;
            this.characterSex = csex;

            Character.amount++;
        }

        static Character()
        {
            maxAmount = 1000;   // 静态只读变量只能在静态构造器（或声明时）初始化
            amount = 0;
        }
    }
}
