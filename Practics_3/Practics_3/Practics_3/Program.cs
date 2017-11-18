using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Ring<Human> humanRing = new Ring<Human>();
            //humanRing.reset();
            int countOfPeople;

            for (int i = 0; i < 5; i++)
            {
                humanRing.add(new Human(i));
            }

            humanRing.addEnum();
            humanRing.moveNext();
            humanRing.moveNext();

            for (int i = 0; i < 5; i++)
            {
                humanRing.moveNext();
                Console.WriteLine(humanRing.current());
            }
            Console.ReadKey();

        }
    }
}
