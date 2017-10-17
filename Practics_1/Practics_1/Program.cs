using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics_1
{
    class Program
    {
        static string buf;
        static double S1, S2;
        static int figure;

        
        static void Main(string[] args)
        {
            initProgramm();
            Console.WriteLine(Environment.NewLine + GetLargestInRect().GetArea());
            Console.ReadKey();
        }

        static void initProgramm()
        {
            Console.WriteLine("Choose the type of figure:" + Environment.NewLine + "Square - 1" + Environment.NewLine + "Disc - 2" + Environment.NewLine + "Triangle - 3" + Environment.NewLine + "Ellips - 4" + Environment.NewLine + "Rectangle - 5: " + Environment.NewLine);
            figure = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the width of area: ");
            buf = Console.ReadLine();
            if (!double.TryParse(buf, out S1))
            {
                throw new FormatException("Illegal value: real positive number requered");
            }
            else
            {
                if (S1 <= 0)
                    throw new ArgumentException("Value must be positive!");
            }

            Console.WriteLine("Enter the height of area: ");
            buf = Console.ReadLine();
            if (!double.TryParse(buf, out S2))
            {
                throw new FormatException("Illegal value: real positive number requered");
            }
            else
            {
                if (S2 <= 0)
                    throw new ArgumentException("Value must be positive!");
            }
        }

        public static GenShape GetLargestInRect()
        {
            GenShape obj;

            switch (figure)
            {
                case 1:
                    return obj = new Square(Math.Min(S1, S2));

                case 2:
                    return obj = new Disc(Math.Min(S1, S2)/2);

                case 3:
                    double smin = Math.Min(S1, S2);
                    double smax = Math.Max(S1, S2);

                    if (smax >= smin * 2)
                    {
                        return obj = new IsoscRectTriangle(smin * Math.Sqrt(2));
                    }
                    else if (smax >= smin * Math.Sqrt(2))
                    {
                        return obj = new IsoscRectTriangle(smax / Math.Sqrt(2));
                    }
                    else
                    {
                        return obj = new IsoscRectTriangle(smin);
                    }

                case 4:
                    return obj = new Ellips(Math.Max(S1, S2)/2, Math.Min(S1, S2)/2);

                case 5:
                    return obj = new Rectangle(S1, S2);
                default:
                    return null;
            }
        }
    }
}
