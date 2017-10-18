using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics_1
{
    class Program
    {

        
        static void Main(string[] args)
        {
            double S1 = 0, S2 = 0;
            int figure = 0;

            initProgramm(S1, S2, figure);
            Console.WriteLine(Environment.NewLine + GetLargestInRect(S1, S2, figure).GetArea());
            Console.ReadKey();
        }

        static void initProgramm(double S1, double S2, int figure)
        {
            Console.WriteLine("Choose the type of figure:" + Environment.NewLine + "Square - 1" + Environment.NewLine + "Disc - 2" + Environment.NewLine + "Triangle - 3" + Environment.NewLine + "Ellips - 4" + Environment.NewLine + "Rectangle - 5: " + Environment.NewLine);
            figure = int.Parse(Console.ReadLine());

            ParseS(S1);
            ParseS(S2);
        }

        public static void ParseS(double S)
        {
            string buf;
            Console.WriteLine("Enter the width of area: ");
            buf = Console.ReadLine();
            if (!double.TryParse(buf, out S))
            {
                throw new FormatException("Illegal value: real positive number requered");
            }
            else
            {
                if (S <= 0)
                    throw new ArgumentException("Value must be positive!");
            }
        }

        public static GenShape GetLargestInRect(double S1, double S2, int figure)
        {
            switch (figure)
            {
                case 1:
                    return GetSquare(S1, S2);

                case 2:
                    return GetDisc(S1, S2);

                case 3:
                    return GetIsoscelesRectangularTriangle(S1, S2);

                case 4:
                    return GetEllips(S1, S2);

                case 5:
                    return GetRectangle(S1, S2);
                default:
                    return null;
            }
        }

        public static GenShape GetSquare(double S1, double S2)
        {
            return new Square(Math.Min(S1, S2));
        }

        public static GenShape GetDisc(double S1, double S2)
        {
            return new Disc(Math.Min(S1, S2) / 2);
        }
        public static GenShape GetIsoscelesRectangularTriangle(double S1, double S2)
        {
            double smin = Math.Min(S1, S2);
            double smax = Math.Max(S1, S2);

            if (smax >= smin * 2)
            {
                if (S1 >= S2)
                    return new IsoscelesRectangularTriangle(smin * Math.Sqrt(2), Emplacement.Horizontal);
                else
                    return new IsoscelesRectangularTriangle(smin * Math.Sqrt(2), Emplacement.Vertical);
            }
            else if (smax >= smin * Math.Sqrt(2))
            {
                if (S1 >= S2)
                    return new IsoscelesRectangularTriangle(smin * Math.Sqrt(2), Emplacement.Horizontal);
                else
                    return new IsoscelesRectangularTriangle(smin * Math.Sqrt(2), Emplacement.Vertical);
            }
            else
            {
                return new IsoscelesRectangularTriangle(smin, Emplacement.InCorner);
            }
        }
        public static GenShape GetEllips(double S1, double S2)
        {
            if (S1 >= S2)
                return new Ellips(Math.Max(S1, S2) / 2, Math.Min(S1, S2) / 2, Emplacement.Horizontal);
            else
                return new Ellips(Math.Max(S1, S2) / 2, Math.Min(S1, S2) / 2, Emplacement.Vertical);
        }

        public static GenShape GetRectangle(double S1, double S2)
        {
            return new Rectangle(S1, S2);
        }
    }
}
