using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics_5
{
    class Contact
    {
        private int Id;
        private string FirstName;
        private string SecondName;
        private string Number;
        private string EMail;


        public Contact(int id, string firstName, string secondName, string number, string eMail)
        {
            pId = id;
            pFirstName = firstName;
            pSecondName = secondName;
            pNumber = number;
            pEMail = eMail;
        }

        public int pId
        {
            set
            {
                if ((value > 0) && (value < 999999))
                {
                    Id = value;
                }
            }
        }

        public string pFirstName
        {
            set
            {
                if (value != null)
                {
                    pFirstName = value;
                }
                else throw new ArgumentNullException("This value is null");
            }
        }

        public string pSecondName
        {
            set
            {
                if (value != null)
                {
                    pSecondName = value;
                }
                else throw new ArgumentNullException("This value is null");
            }
        }

        public string pNumber
        {
            set
            {
                if (int.TryParse(value, out int buf));
                else throw new ArgumentNullException("This value is null");
               
            }
        }

        public string pEMail
        {
            set { }
        }


        public override string ToString()
        {
            return $"Contact[ID = {Id}]:" + Environment.NewLine +
                $" First name : {FirstName}" + Environment.NewLine +
                $" Second name : {SecondName}" + Environment.NewLine +
                $" Number : {Number}" + Environment.NewLine + 
                $" EMail : {EMail}";
        }

        internal int GetId()
        {
            return Id;
        }

        internal string GetEMail()
        {
            return EMail;
        }

        internal string GetFirstName()
        {
            return FirstName;
        }

        internal string GetSecondName()
        {
            return SecondName;
        }

        internal string GetNumber()
        {
            return Number;
        }
    }
}
