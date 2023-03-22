using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace property
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Character Peter = new Character("Peter");

            string input = Console.ReadLine();
            while(input != "stop")
            {
                int inputAmount = 0;

                try
                {
                    inputAmount = Int32.Parse(input);
                }
                catch(FormatException)
                {
                    Console.WriteLine("Please enter a number.");
                }
                catch(OverflowException)
                {
                    Console.WriteLine("The number is out of range of Int32.");
                }

                Peter.health = Peter.health + inputAmount;
                Console.WriteLine(Peter.health);

                input = Console.ReadLine();
            }
            
        }
    }

    class Character
    {
        public string name;
        public int level;
        private int currentHealth = 5;
        public int maxHealth = 20;

        public static Exception lowHealth = new Exception("The health is too low.");
        public static Exception outRangeHealth = new Exception("Character is at max health.");

        public int health // 属性是对字段的包装，因此传递出去/修改的变量是被包装的currentHealth
        {
            get
            {
                return this.currentHealth;
            }
            set
            {

                if (value >= 0 && value <= maxHealth)
                {
                    currentHealth = value;
                }
                else if(value < 0)
                {
                    currentHealth = 0;
                }
                else
                {
                    currentHealth = maxHealth;
                }
            }
        }

        public Character(string name)
        {
            this.name = name;
            this.level = 1;
        }
    }
}
