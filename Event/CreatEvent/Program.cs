using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatEvent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer Peter = new Customer();
            Waiter Brown = new Waiter();
            Peter.Order += Brown.Action;    // 订阅事件
            // Peter是事件拥有者，事件是Order；Brown是事件接收者，事件处理器是Action

            Peter.GotoRestraunt();
        }
    }

    // 此委托传递的是事件处理器，其有两个参数：事件拥有者和事件参数
    public delegate void OrderEventHandler(Customer customer, OrderEventArgs e);

    public class OrderEventArgs : EventArgs
    {
        public string name { get; set; }
        public int size { get; set; }
    }

    public class Customer
    {
        // 声明的委托（负责传递事件处理器）：被隐藏
        private OrderEventHandler orderEventHandler;

        // 定义的事件：上面声明的委托的包装器
        public event OrderEventHandler Order
        {
            add
            {
                this.orderEventHandler += value;
            }
            remove
            {
                this.orderEventHandler -= value;
            }
        }

        public int bill;
        public void PayBill()
        {
            Console.WriteLine("Customer: I will pay ${0}.", bill);
        }
        public void Think()
        {
            string mealName;
            int mealSize;
            Console.WriteLine("Waiter: What do you want?");
            mealName = Console.ReadLine();
            Console.WriteLine("Waiter: Whcih size do you want?");
            mealSize = Int32.Parse(Console.ReadLine());

            if(orderEventHandler != null)
            {
                // 事件发生，调用事件处理器（委托）
                orderEventHandler.Invoke(this,new OrderEventArgs() { name = mealName, size = mealSize });
            }
        }
        public void GotoRestraunt()
        {
            this.Think();
            this.PayBill();
        }
    }

    public class Waiter
    {
        internal void Action(Customer customer, OrderEventArgs e)
        {
            customer.bill += 10 * e.size;
            Console.WriteLine("Waiter: I will serve you: " + e.name);
        }
    }
}
