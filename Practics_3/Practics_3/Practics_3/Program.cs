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
            LinkedList<Human> list = new LinkedList<Human>();
            LinkedListNode<Human> node;

            Console.WriteLine("Enter the count of people :");
            if (!int.TryParse(Console.ReadLine(), out int cnt)) throw new ArgumentException("Positive decimal number required");

            for (int i = 0; i < cnt; i++)
            {
                list.AddLast(new Human(i));
            }

            node = list.First;

            for (int i = 0; i < cnt; i++)
            {
                Console.WriteLine(node.Value.getId());
                node = node.Next;
            }


            Console.WriteLine();
            Console.ReadKey();

            node = list.First;

            for (int i = 0; i < cnt; i++)
            {
                node = node.Next ?? list.First;

                Console.WriteLine(node.Value.getId());

                node = node.Next ?? list.First;
            }

            Console.ReadKey();
        }
    }
}
