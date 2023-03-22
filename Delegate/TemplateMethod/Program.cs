using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 接下来需要实例方法，所以创建实例很重要
            ProductFactory factory = new ProductFactory();
            WrapFactory wrapFactory = new WrapFactory();

            // 委托本质上是类（引用类型），因此需要声明，并用new关键字创建实例。
            Func<Product> factory1 = new Func<Product>(factory.CakeProduct);
            Func<Product> factory2 = new Func<Product>(factory.BreadProduct);

            // 委托可以作参数传递给函数
            Box cakeBox = wrapFactory.WrapProduct(factory1);
            Console.WriteLine(cakeBox.product.name);

            Box breadBox = wrapFactory.WrapProduct(factory2);
            Console.WriteLine(breadBox.product.name);
        }
    }

    class Product
    {
        public string name;
    }

    class Box
    {
        public Product product;
    }

    class WrapFactory
    {
        // 模板方法，只有GetProduct()方法需要委托类型参数传递
        public Box WrapProduct(Func<Product> GetProduct)
        {
            Box box = new Box();
            Product product = GetProduct();
            box.product = product;
            return box;
        }
    }

    class ProductFactory
    {
        public Product CakeProduct()
        {
            Product product = new Product();
            product.name = "Cake";
            return product;
        }
        public Product BreadProduct()
        {
            Product product = new Product();
            product.name = "Bread";
            return product;
        }
    }
}
