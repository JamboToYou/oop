using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics_1
{
    class IsoscelesRectangularTriangle : GenShape
    {
        private double side;
        public Emplacement empl;

        public IsoscelesRectangularTriangle(double side, Emplacement empl)
        {
            Side = side;
            Empl = empl;
        }

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
            return side * side / 2;
        }

        public override double GetShapeHeight()
        {
            switch (empl)
            {
                case Emplacement.Vertical:
                    return side * Math.Sqrt(2);
                case Emplacement.Horizontal:
                    return side / Math.Sqrt(2);
                case Emplacement.InCorner:
                    return side;
                default:
                    throw new Exception("Invalid emplacement");
            }
        }

        public override double GetShapeWidth()
        {
            switch (empl)
            {
                case Emplacement.Horizontal:
                    return side * Math.Sqrt(2);
                case Emplacement.Vertical:
                    return side / Math.Sqrt(2);
                case Emplacement.InCorner:
                    return side;
                default:
                    throw new Exception("Invalid emplacement");
            }
        }
    }
}
