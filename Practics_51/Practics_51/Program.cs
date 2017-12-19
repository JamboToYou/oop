using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics_51
{
    class Program
    {
        static void Main(string[] args)
        {
            XMLWorker worker = new XMLWorker();

            LinkedList<Person> list = worker.GetAllPersons();

            foreach (Person person in list)
            {
                Console.WriteLine(person.ToString());
                Console.WriteLine("---====***===---||---====***===---");
            }

            Console.ReadKey();
        }
    }
}
