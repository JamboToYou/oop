using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics_1
{
    class Rectangle : GenShape
    {
        private double width;
        private double height;

        public Rectangle(double width, double weight)
        {
            Width = width;
            Height = height;
        }

        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Value must be positive!");
                }
                else
                {
                    width = value;
                }
            }
        }
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Value must be positive!");
                }
                else
                {
                    height = value;
                }
            }
        }

        public override double GetArea()
        {
            return width * height;
        }

        public override double GetShapeHeight()
        {
            return Height;
        }

        public override double GetShapeWidth()
        {
            return Width;
        }
    }
}
