using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics_4
{
    class Program
    {
        public delegate double Func(double arg);

        public static double Function(double arg)
        {
            return arg * arg + 2 * arg + 1;
        }

        public static void analyzing(Func function, double epsilon, double borderLeft, double borderRight, out double minimalValue, out double maximalValue)
        {
            double rez, min = 0, max = 0;
            for (double x = borderLeft; x <= borderRight; x += epsilon)
            {
                rez = function(x);
                if (rez > max) max = rez;
                else if (rez < min) min = rez;
            }
            minimalValue = min;
            maximalValue = max;
        }

        public static void initProgram(out Func function, out double epsilon, out double borderLeft, out double borderRight)
        {
            function = Function;
            parseDoubleValue(out epsilon, "epsilon", true);
            parseDoubleValue(out borderLeft, "left border", false);
            parseDoubleValue(out borderRight, "right border", false);
            if (borderRight < borderLeft)
            {
                throw new Exception("Right border has to be bigger than left");
            }

        }

        public static void parseDoubleValue(out double value, string nameOfValue, bool checkToNegativeValue)
        {
            Console.WriteLine("Enter the {0}: ", nameOfValue);
            if (double.TryParse(Console.ReadLine(), out value))
            {
                if (value < 0 && checkToNegativeValue) throw new ArgumentException("Illegal value for {0}", nameOfValue);
            }
            else throw new ArgumentException("Illegal type of value for {0}", nameOfValue);
        }

        static void Main(string[] args)
        {
            double minimalValue;
            double maximalValue;
            double epsilon;
            double borderLeft, borderRight;
            Func function;

            initProgram(out function, out epsilon, out borderLeft, out borderRight);
            analyzing(function, epsilon, borderLeft, borderRight, out minimalValue, out maximalValue);

            Console.WriteLine(minimalValue + Environment.NewLine + maximalValue);
            Console.ReadKey();
        }
    }
}
