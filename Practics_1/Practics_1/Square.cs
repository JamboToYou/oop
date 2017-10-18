using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics_1
{
    class Square : GenShape
    {
        private double side;

        public Square(double side)
        {
            Side = side;
        }

        public double Side
        {
            get
            {
                return side;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Value must be positive!");
                }
                else
                {
                    side = value;
                }
            }
        }

        public override double GetArea()
        {
            return side * side;
        }

        public override double GetShapeHeight()
        {
            return side;
        }

        public override double GetShapeWidth()
        {
            return side;
        }
    }
}
