using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anos_5
{
    class Product
    {
        string ProductName;
        int ProductId;
        float Price;
        public Product(string Name, int val)
        {
            ProductName = Name;
            ProductId = val;
        }
        public float Price
        {
            get { return Price; }
            set { if (value < 0)
                {
                    Price = 0;
                }
            else
                {
                    Price = value;
                }
            }
        }
        public void Display()
        {
            Console.WriteLine("Product Name"+ProductName);
            Console.WriteLine("Product Id"+ProductId);
            Console.WriteLine("Price"+Price+"$");
        }
    }
    class Goods
    {
        static void Main(string[] args)
        {
            Product obj = new Product("Hard Disk", 101);
            obj.Price = 345.25F;
            obj.Display();
        }
    }
}
