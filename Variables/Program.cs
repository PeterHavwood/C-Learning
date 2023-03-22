using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Character.TotalNumber= 0;

            Character Peter = new Character();
            Peter.Level= 1;

            // 局部变量 - 常量：初始化器不可忽略
            const int MaxNumber = 9999;
        }
    }

    class Character
    {   
        // 静态变量 - 隶属于类而非类成员的变量
        public static int TotalNumber;
        // 实例变量（成员变量、字段） - 属于类成员的变量
        public int Level;

        public int Damage(int Level, int DamageOfWeapen)    // 值参数
        {
            // 局部变量
            int Result = Level * DamageOfWeapen;
            return Result;
        }

        object
        
    }
}
