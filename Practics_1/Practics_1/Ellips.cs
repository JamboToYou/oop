using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics_1
{
    class Ellips : GenShape
    {
        private double bigRadius;
        private double smallRadius;

        public double BigRadius {
            get
            {
                return bigRadius;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Value must be positive!");
                }
                else
                {
                    bigRadius = value;
                }
            }
        }

        public double SmallRadius
        {
            get
            {
                return smallRadius;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Value must be positive!");
                }
                else
                {
                    smallRadius = value;
                }
            }
        }

        public Ellips(double BigRadius, double SmallRadius)
        {
            if (BigRadius <= 0 || SmallRadius <= 0)
            {
                throw new ArgumentException("Values must be positive!");
            }
            else
            {
                bigRadius = BigRadius;
                smallRadius = SmallRadius;
            }
            
        }

        public override double GetArea()
        {
            return Math.PI * bigRadius * smallRadius;
        }
    }
}
