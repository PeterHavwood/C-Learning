using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 强耦合
            Nokia nokia = new Nokia();
            Customer Peter = new Customer(nokia, "Peter");
            Peter.Call();

            // 依赖注入
            var sc = new ServiceCollection();
            sc.AddScoped(typeof(IPhone),typeof(Nokia));
            sc.AddScoped<Customer>();
            var sp = sc.BuildServiceProvider();
            
            Customer Tim = sp.GetService<Customer>();
            Tim.Call();
        }
    }

    interface IPhone
    {
        void Call(string userName);
    }

    interface ICamera
    {
        void TakePhoto();
    }

    class Nokia : IPhone, ICamera
    {
        public void Call(string userName)
        {
            Console.WriteLine(userName + "'s Nokia is calling...Ding....");
        }

        public void TakePhoto()
        {
            Console.WriteLine("Ca! Nokia takes a photo");
        }
    }

    class Customer
    {
        public string name;
        private IPhone _phone;
        public Customer(IPhone phone, string name)
        {
            _phone = phone;
            this.name = name;
        }

        public void Call()
        {
            _phone.Call(this.name);
        }
    }
}
