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
        public Emplacement empl;

        public Emplacement Empl
        {
            get
            {
                return empl;
            }
            set
            {
                if (value.GetType() == empl.GetType())
                {
                    empl = value;
                }
                else
                {
                    throw new ArgumentException("Invalid type");
                }
            }
        }

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

        public Ellips(double bigRadius, double smallRadius, Emplacement empl)
        {
            BigRadius = bigRadius;
            SmallRadius = smallRadius;
            Empl = empl;
            
        }

        public override double GetArea()
        {
            return Math.PI * bigRadius * smallRadius;
        }

        public override double GetShapeHeight()
        {
            switch (empl)
            {
                case Emplacement.Horizontal:
                    return smallRadius * 2;

                case Emplacement.Vertical:
                    return bigRadius * 2;

                default:
                    return smallRadius * 2;
            }
        }

        public override double GetShapeWidth()
        {
            switch (empl)
            {
                case Emplacement.Vertical:
                    return smallRadius * 2;

                case Emplacement.Horizontal:
                    return bigRadius * 2;

                default:
                    return bigRadius * 2;
            }
        }
    }
}
