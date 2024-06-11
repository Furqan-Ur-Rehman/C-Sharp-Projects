using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Example_pg_292
{
    class Product
    {
        string _productName;
        int _productID;
        float _price;

        public Product(string Name, int Val)
        {
            _productName = Name;
            _productID = Val;
        }

        public float Price {


            get {
                return _price;
            }

            set
            {
                if (value < 0)
                {
                    _price = 0;
                }

                else
                {
                    _price = value;
                }
            }

        }

        public void Display()
        {
            Console.WriteLine("Product Name: " + _productName);
            Console.WriteLine("Product ID:" + _productID);
            Console.WriteLine("Price:" + _price + "Rs.");
        }
        class Goods
        {
            static void Main(string[] args)
            {
                Product objProduct = new Product("HardDisk", 101);
                objProduct.Price = 345.25f;
                objProduct.Display();

                Console.Read();
            }
        }
    }
