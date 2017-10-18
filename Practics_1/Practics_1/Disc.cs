using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics_1
{
    class Disc : GenShape
    {
        private double radius;

        public Disc(double radius)
        {
            Radius = radius;
        }

        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Value must be positive!");
                }
                else
                {
                    radius = value;
                }
            }
        }

        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }

        public override double GetShapeHeight()
        {
            return radius * 2;
        }

        public override double GetShapeWidth()
        {
            return radius * 2;
        }
    }
}
