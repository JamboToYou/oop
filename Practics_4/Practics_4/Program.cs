using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics_4
{
    class Program
    {
        public delegate int func(int x, int y);

        public static int submit(int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
