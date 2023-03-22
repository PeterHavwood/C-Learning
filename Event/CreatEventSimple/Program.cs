using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatEventSimple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer Peter = new Customer();
            Waiter Brown = new Waiter();
            Peter.Order += Brown.Action;

            // 事件Order只能出现在+=/-=的左边，在Customer类中除外
            // Peter.Order.Invoke(); 这个语句将报错

            Peter.Think();
            Peter.PayBill();
        }
    }

    public class OrderEventArgs : EventArgs
    {
        public string name;
        public int price;
    }

    public class Customer
    {
        public event EventHandler Order;
        public int bill { get; set; }
        public void PayBill()
        {
            Console.WriteLine("Pay ${0}",this.bill);
        }
        public void Think()
        {
            if (Order != null)
            {
                Order.Invoke(this,new OrderEventArgs(){ name = "Rice", price = 4 });
            }
        }
    }

    class Waiter
    {
        internal void Action(Object sender, EventArgs e)
        {
            Customer customer = sender as Customer;
            OrderEventArgs orderInfo = e as OrderEventArgs;
            Console.WriteLine("I will serve the "+ orderInfo.name);
            customer.bill += orderInfo.price;
        }
    }
}
