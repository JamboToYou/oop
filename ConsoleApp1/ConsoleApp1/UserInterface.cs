using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class UserInterface
    {
        private Application app;

        public UserInterface(Application app)
        {
            this.app = app;
        }

        public void ShowContacts()
        {
            LinkedList<Example> list = app.GetAllContacts();

            foreach (Example ex in list)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
