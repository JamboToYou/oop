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
            LinkedListNode<Human> nodeToDelete;

            Console.WriteLine("Enter the count of people :");
            if (!int.TryParse(Console.ReadLine(), out int cnt)) throw new ArgumentException("Positive decimal number required");

            for (int i = 0; i < cnt; i++)
            {
                list.AddLast(new Human(i));
            }

            node = list.First;

            for (int i = 0; i < cnt; i++)
            {
                Console.WriteLine("Human in the ring :" + node.Value.getId());
                node = node.Next;
            }


            Console.WriteLine();
            Console.ReadKey();

            node = list.First;

            for (int i = 0; i < cnt - 1; i++)
            {
                node = node.Next ?? list.First;
                PrintEliminatedHuman(node);
                nodeToDelete = node;

                node = node.Next ?? list.First;

                list.Remove(nodeToDelete);
            }

            Console.WriteLine("The man #" + list.First.Value.getId() + " is the Last Hero!");

            Console.ReadKey();
        }

        private static void PrintEliminatedHuman(LinkedListNode<Human> node)
        {
            Console.WriteLine("Human #" + node.Value.getId() + " has eliminated");
        }
    }
}
