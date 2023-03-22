using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game COD = new Game() { name = "COD", price = 60 };
            Book DasCaptical = new Book() { name = "DC", price = 10 };

            Box<Game> CodBox = new Box<Game>() { cargo = COD };
            Box<Book> BookBox = new Box<Book>() { cargo = DasCaptical };

            Console.WriteLine(CodBox.cargo.name);
            Console.WriteLine(BookBox.cargo.price);
        }
    }

    class Game
    {
        public string name;
        public int price;
    }

    class Book
    {
        public string name;
        public int price;
    }

    class Box <TCargo>
    {
        public TCargo cargo;
    }
}
