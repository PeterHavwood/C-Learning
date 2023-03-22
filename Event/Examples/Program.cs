using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Form form = new Form();
            Controller controller = new Controller(form);   // 构造时完成订阅
            form.ShowDialog();

            MyForm myForm = new MyForm();
            myForm.Click += myForm.ClickAction; //自己（的事件）和自己（的方法）订阅
            myForm.ShowDialog();
        }
    }

    class Controller
    {
        private Form form;
        public Controller(Form form)
        {
            this.form = form;
            // 事件订阅：form的click事件与controller的FormClicked方法（事件处理器）订阅
            this.form.Click += this.FormClicked;
        }

        private void FormClicked(object sender, EventArgs e)
        {
            this.form.Text = "Hello World!";
        }
    }

    class MyForm : Form
    {
        internal void ClickAction(object sender, EventArgs e)
        {
            this.Text = "Hello World!_2";
        }
    }
}
