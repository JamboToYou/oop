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

        public Disc(double Radius)
        {
            if (Radius <= 0)
            {
                throw new ArgumentException("Value must be positive!");
            }
            else
            {
                radius = Radius;
            }
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
    }
}
