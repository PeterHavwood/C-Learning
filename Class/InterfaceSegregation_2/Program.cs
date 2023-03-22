using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BoomSmartPhone sp = new BoomSmartPhone();
            // sp表现为正常的手机，可以打电话、拍照片
            sp.Call();
            sp.TakePhoto();

            IBoom boomPhone = new BoomSmartPhone();
            // 通过类型转换可以正常使用
            BoomSmartPhone p = boomPhone as BoomSmartPhone;
            p.TakePhoto();
            // boomPhone才可以作为炸弹手机使用
            boomPhone.Boom();
        }
    }

    interface IPhone
    {
        void Call();
    }

    interface ICamera
    {
        void TakePhoto();
    }

    interface IBoom
    {
        void Boom();
    }

    class BoomSmartPhone : IPhone, ICamera, IBoom
    {
        void IBoom.Boom()
        {
            Console.WriteLine("Boooom!");
        }

        public void Call()
        {
            Console.WriteLine("Calling...");
        }

        public void TakePhoto()
        {
            Console.WriteLine("Taking a phtot...");
        }
    }
}
