using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read_and_Write_Property_book_pg_292
{
    class Product
    {
        string productName;
        int productID;
        float price;

        //Create parameterized Constructor for set values
        public Product(string Name, int id)
        {
            productName = Name;
            productID = id;
        }

        //Create Read & Write Only property

        public float Price
        {
            get
            {
                return price;
            }

            set
            {
                if(value < 0)
                {
                    price = 0;
                }

                else
                {
                    price = value;
                }
            }

            
        }

        public void Display()
        {
            Console.WriteLine("Product Name: " + productName);
            Console.WriteLine("Product ID: " + productID);

        }
    }
    internal class Goods
    {
        static void Main(string[] args)
        {

            Product objproductName = new Product("Hard Disk",101);

            objproductName.Price = 500;
            objproductName.Display();
            Console.WriteLine("Product Price: " + objproductName.Price);

            Console.Read();
        }
    }
}
