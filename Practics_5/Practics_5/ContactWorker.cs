using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Practics_5
{
    class ContactWorker
    {
        private static XDocument xdoc;
        private static string FileName;
        private static int lastId;

        public ContactWorker()
        {
            int Id = -1;
            LoadContactsFile("Contacts.xml");

            foreach (XElement xContact in xdoc.Root.Elements())
            {
                xContact.Attribute("Id").Value = (++Id).ToString();
            }
            lastId = Id;
        }

        public LinkedList<Contact> GetContactsList()
        {
            LinkedList<Contact> list = new LinkedList<Contact>();
            foreach(XElement xContact in xdoc.Root.Elements())
            {
                Contact contact = GetContact(xContact);
                list.AddLast(contact);
            }
            return list;
        }

        private static Contact GetContact(XElement xContact)
        {
            Contact contact = new Contact(int.Parse(xContact.Attribute("Id").Value),
                                        xContact.Element("FirstName").Value,
                                        xContact.Element("SecondName").Value,
                                        xContact.Element("Number").Value,
                                        xContact.Element("EMail").Value);

            return contact;
        }

        public void AddContact(Contact contact)
        {
            xdoc.Root.Add(new XElement("contact",
                                        new XAttribute("Id", ++lastId),
                                        new XElement("FirstName", contact.FirstName1),
                                        new XElement("SecondName", contact.SecondName1),
                                        new XElement("Number", contact.Number1),
                                        new XElement("EMail", contact.EMail1)));
            xdoc.Save(FileName);
        }
        

        public bool RemoveContactById(string Id)
        {
            bool result = false;

            if (!int.TryParse(Id, out int ID)) return result;

            foreach (XElement xContact in xdoc.Root.Elements())
            {
                if (int.Parse(xContact.Attribute("Id").Value) == ID)
                {
                    xContact.Remove();
                    result = true;
                }
            }
            xdoc.Save(FileName);

            return result;
        }

        public LinkedList<Contact> FindContactByTagName(string tagName, string content)
        {
            if (tagName == null || content == null) return null;
            LinkedList<Contact> list = new LinkedList<Contact>();
            foreach (XElement xContact in xdoc.Root.Elements())
            {
                if (xContact.Element(tagName).Value.Contains(content))
                {
                    list.AddLast(GetContact(xContact));
                }
            }

            return list;
        }

        public Contact FindContactById(int Id)
        {
            string id = Id.ToString();

            foreach (XElement xContact in xdoc.Root.Elements())
            {
                if (xContact.Attribute("Id").Value == id)
                {
                    return GetContact(xContact);
                }
            }
            return null;
        }

        public LinkedList<Contact> FindContactByContent(string content)
        {
            LinkedList<Contact> list = new LinkedList<Contact>();

            foreach (XElement xContact in xdoc.Root.Elements())
            {
                foreach (XElement xContentUnit in xContact.Elements())
                {
                    if (xContentUnit.Value.Contains(content))
                    {
                        list.AddLast(GetContact(xContact));
                        break;
                    }
                }
            }
            return list;
        }

        public void SaveContactsTo(string directoryWithFileName)
        {
            xdoc.Save(directoryWithFileName);
            LoadContactsFile(directoryWithFileName);
        }

        private void LoadContactsFile(string directoryWithFileName)
        {
            xdoc = XDocument.Load(directoryWithFileName);
            FileName = directoryWithFileName;
        }
    }
}
