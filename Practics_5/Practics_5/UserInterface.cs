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
                "4. Search contact" + Environment.NewLine + 
                "5. Exit");
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
            string Number = "t";

            ParseValue("first name", out string FirstName);

            ParseValue("second name", out string SecondName);

            while(!int.TryParse(Number, out int buf))
            {
                ParseValue("number", out Number);
            }

            ParseValue("email", out string EMail);

            contact = new Contact(0,
                                FirstName,
                                SecondName,
                                Number,
                                EMail);

            contactWorker.AddContact(contact);
        }

        private static void ParseValue(string nameOfValue, out string Variable)
        {
            Console.Write("Enter the {0} : ", nameOfValue);
            Variable = Console.ReadLine();
        }

        internal void DeleteContact()
        {
            Console.WriteLine("Enter the ID of contact to remove :");
            this.ShowContacts();

            if (int.TryParse(Console.ReadLine(), out int ID))
            {
                if (ID < 0 || ID > contactWorker.GetLastId())
                {
                    Console.WriteLine("Wrong ID!");
                    DeleteContact();
                }
                else
                {
                    contactWorker.RemoveContactById(ID);
                }
            }
            else
            {
                Console.WriteLine("Wrong type of ID!");
                DeleteContact();
            }
        }

        internal void SearchContact()
        {
            string temp;
            string option;

            Console.WriteLine("Choose the option contact will be searched by :" + Environment.NewLine +
                                "1. First name" + Environment.NewLine +
                                "2. Second name" + Environment.NewLine +
                                "3. Number" + Environment.NewLine +
                                "4. EMail");

            option = Console.ReadLine();

            Console.WriteLine("Search : ");
            temp = Console.ReadLine();

            switch (option)
            {
                case "1":
                    ShowContactsList(contactWorker.FindByTagName("FirstName", temp));
                    break;

                case "2":
                    ShowContactsList(contactWorker.FindByTagName("SecondName", temp));
                    break;

                case "3":
                    ShowContactsList(contactWorker.FindByTagName("Number", temp));
                    break;

                case "4":
                    ShowContactsList(contactWorker.FindByTagName("EMail", temp));
                    break;

                default:
                    Console.WriteLine("Illegal option");
                    SearchContact();
                    break;
            }
        }
    }
}
