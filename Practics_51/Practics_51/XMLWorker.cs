using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Practics_51
{
    class XMLWorker
    {
        private XDocument xDoc;
        private string path;

        public XMLWorker()
        {
            //Инициализируем путь и открываем XML файл

            path = "Inventory.xml";
            xDoc = XDocument.Load(path);
        }

        public LinkedList<Person> GetAllPersons()
        {
            LinkedList<Person> list = new LinkedList<Person>();

            foreach (XElement person in xDoc.Root.Elements())
            {
                list.AddLast(new Person(person.Element("FSTNAME").Value,
                    person.Element("LSTNAME").Value,
                    person.Element("PHONE").Value,
                    person.Element("EMAIL").Value));
            }

            return list;
        }
    }
}
