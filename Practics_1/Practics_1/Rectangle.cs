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

        public Rectangle(double Width, double Height)
        {
            if (Width <= 0 || Height <= 0)
            {
                throw new ArgumentException("Value must be positive!");
            }
            else
            {
                width = Width;
                height = Height;
            }
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
    }
}
