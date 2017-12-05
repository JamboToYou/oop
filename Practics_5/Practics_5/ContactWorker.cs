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

        public ContactWorker(string fileName)
        {
            int Id = -1;
            xdoc = XDocument.Load(fileName);
            FileName = fileName;

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
                                        new XElement("FirstName", contact.GetFirstName()),
                                        new XElement("SecondName", contact.GetSecondName()),
                                        new XElement("Number", contact.GetNumber()),
                                        new XElement("EMail", contact.GetEMail())));
            xdoc.Save(FileName);
        }
        

        public void RemoveContactById(int Id)
        {
            foreach (XElement xContact in xdoc.Root.Elements())
            {
                if (int.Parse(xContact.Attribute("Id").Value) == Id)
                {
                    xContact.Remove();
                }
            }

            xdoc.Save(FileName);
        }

        public LinkedList<Contact> FindByTagName(string tagName, string content)
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

        public int GetLastId()
        {
            return lastId;
        }
    }
}
