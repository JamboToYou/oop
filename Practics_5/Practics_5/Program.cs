using System;
using System.Collections.Generic;
using System.IO;
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
            ContactWorker cw = new ContactWorker();
            UserInterface ui = new UserInterface(cw);
                
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
                        while (!ui.DeleteContact()) ;
                        break;

                    case "4":
                        while(!ui.FindContactByTagName()) ;
                        break;

                    case "5":
                        ui.FindContactByContent();
                        break;

                    case "6":
                        ui.SaveContacts();
                        break;

                    case "7":
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