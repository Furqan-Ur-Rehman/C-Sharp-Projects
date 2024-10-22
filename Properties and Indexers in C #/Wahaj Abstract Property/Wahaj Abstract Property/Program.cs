﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_property
{
    public abstract class figure
    {
        public abstract float DimensionOne
        {
            set;
        }
        public abstract float DimensionTwo
        {
            set;
        }

    }
    class Rectangle : figure

    {
        float _dimensionOne;
        float _dimensionTwo;
        public override float DimensionOne
        {
            set
            {
                if (value <= 0)
                {
                    _dimensionOne = 0;

                }
                else
                {
                    _dimensionOne = value;
                }
            }
        }
        public override float DimensionTwo
        {
            set
            {
                if (value <= 0)
                {
                    _dimensionTwo = 0;
                }
                else
                {
                    _dimensionTwo = value;
                }
            }


            float Area()
        {
            return _dimensionOne * _dimensionTwo;
        }

        internal class Program
        {

            static void Main(string[] args)
            {
                Rectangle objRectangle = new Rectangle();
                objRectangle.DimensionOne = 20;
                objRectangle.DimensionOne = 4.233F;
                Console.WriteLine("Area of rectangle :" + objRectangle.Area());

                Console.Read();
            }
        }
    }
