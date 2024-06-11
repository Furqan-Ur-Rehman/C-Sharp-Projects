using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Property_Book_pg_295
{
    public abstract class Figure
    {
        public abstract float Dimensionone
        {
            set;
        }

        public abstract float Dimensiontwo
        {
            set;
        }
    }
    internal class Rectangle : Figure
    {
        float dimensionone;
        float dimensiontwo;

        override public float Dimensionone
        {
            set
            {
                if(value <= 0)
                {
                    dimensionone = 0;
                }

                else
                {
                    dimensionone = value;
                }
            }
        }
        
        override public float Dimensiontwo
        {
            set
            {
                if(value <=0)
                {
                    dimensiontwo = 0;   
                }

                else
                {
                    dimensiontwo = value;
                }
            }
        }
        
        float Area()
        {
            return dimensionone * dimensiontwo;
        }
        static void Main(string[] args)
        {

            Rectangle objRect = new Rectangle();
            objRect.Dimensionone = 20;
            objRect.Dimensiontwo = 4.23f;

            Console.WriteLine("Area of Rectangle is: " + objRect.Area());

            Console.Read();
        }
    }
}
