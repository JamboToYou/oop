using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics_5
{
    class UserInterface
    {
        private static ContactWorker contactWorker;

        public UserInterface(ContactWorker cw)
        {
            contactWorker = cw;
        }

        internal void ShowMainMenu()
        {
            Console.WriteLine("Hi, User. This is contacts-view-app. Choose the option:" + Environment.NewLine +
                "1. Show contacts" + Environment.NewLine +
                "2. Add contact" + Environment.NewLine +
                "3. Delete contact" + Environment.NewLine +
                "4. Find contact by content in several tag" + Environment.NewLine +
                "5. Find contact by content" + Environment.NewLine +
                "6. Save to file" + Environment.NewLine +
                "7. Exit");
        }

        internal void ShowContacts()
        {
            ShowContactsList(contactWorker.GetContactsList());
        }

        private void ShowContactsList(LinkedList<Contact> ContactsList)
        {
            foreach (Contact contact in ContactsList)
            {
                Console.WriteLine(contact + Environment.NewLine + "----====----");
            }
        }

        internal void AddContact()
        {
            Contact contact;
            string Number;

            InputValue("first name", out string FirstName);

            InputValue("second name", out string SecondName);

            do
            {
                InputValue("number", out Number);
            } while (!int.TryParse(Number, out int buf));

            InputValue("email", out string EMail);

            contact = new Contact(FirstName,
                                  SecondName,
                                  Number,
                                  EMail);

            contactWorker.AddContact(contact);
        }

        private static void InputValue(string nameOfValue, out string Variable)
        {
            Console.Write("Enter the {0} : ", nameOfValue);
            Variable = Console.ReadLine();
        }

        internal bool DeleteContact()
        {
            this.ShowContacts();

            Console.WriteLine("Enter the ID of contact to remove or press enter to cancel : ");

            string buf = Console.ReadLine();
            if (buf == "") return true;

            if (!contactWorker.RemoveContactById(buf))
            {
                Console.WriteLine("Wrong type of ID!");
                return false;
            }
            
            return true;
        }

        internal bool FindContactByTagName()
        {
            string temp;
            string option;

            Console.WriteLine("Choose the option contact will be searched by :" + Environment.NewLine +
                                "1. First name" + Environment.NewLine +
                                "2. Second name" + Environment.NewLine +
                                "3. Number" + Environment.NewLine +
                                "4. EMail" + Environment.NewLine +
                                "5. Cancel");

            option = Console.ReadLine();
            if (option == "5") return true;

            Dictionary<string, string> vals = new Dictionary<string, string>
            {
                {"1", "FirstName"},
                {"2", "SecondName"},
                {"3", "Number"},
                {"4", "EMail"}
            };

            if (!vals.ContainsKey(option))
            {
                Console.WriteLine("Wrong option");
                return false;
            }

            Console.WriteLine("Search : ");
            temp = Console.ReadLine();

            LinkedList<Contact> contactsList = contactWorker.FindContactByTagName(vals[option], temp);

            ShowContactsList(contactsList);
            return true;
        }

        internal void FindContactByContent()
        {
            string temp;
            LinkedList<Contact> contactsList;

            Console.WriteLine("Search : ");
            temp = Console.ReadLine();


            contactsList = contactWorker.FindContactByContent(temp);
            this.ShowContactsList(contactsList);
        }

        internal void SaveContacts()
        {
            Console.WriteLine("Enter the directory and name of xml-file on the end :");

            contactWorker.SaveContactsTo(Console.ReadLine());
        }
    }
}
