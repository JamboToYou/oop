using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Practics_5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool end = false;
            ContactWorker cw;
            UserInterface ui;

            Console.WriteLine("Enter the directory to your contact file");
            
            cw = new ContactWorker(Console.ReadLine());
            ui = new UserInterface(cw);
                
            while (!end)
            {
                string option;
                Console.Clear();
                ui.ShowMainMenu();

                option = Console.ReadLine();

                Console.Clear();
                switch (option)
                {
                    case "1":
                        ui.ShowContacts();
                        break;

                    case "2":
                        ui.AddContact();
                        break;

                    case "3":
                        ui.DeleteContact();
                        break;

                    case "4":
                        ui.SearchContact();
                        break;

                    case "5":
                        end = true;
                        break;

                    default:
                        break;
                }

                Console.WriteLine("Press any key . . .");
                Console.ReadKey();
            }
            Console.ReadKey();
            
        }
    }
}