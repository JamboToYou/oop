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

        public int Id1 { get => Id; set { if (value >= 0) Id = value; else { throw new ArgumentException(); } } }
        public string FirstName1
        {
            get
            {
                return FirstName;
            }
            set
            {
                if (value == null) throw new ArgumentException(nameof(FirstName));
                else FirstName = value;
            }
        }
        public string SecondName1
        {
            get => SecondName;
            set
            {
                if (value == null) throw new ArgumentException(nameof(SecondName));
                else SecondName = value;
            }
        }
        public string Number1
        {
            get => Number;
            set
            {
                if (value == null) throw new ArgumentException(nameof(Number));
                else Number = value;
            }
        }
        public string EMail1 { get => EMail; set => EMail = value; }

        public Contact(int id1, string firstName1, string secondName1, string number1, string eMail1)
            :this(firstName1, secondName1, number1, eMail1)
        {
            Id1 = id1;
        }

        public Contact(string firstName1, string secondName1, string number1, string eMail1)
        {
            FirstName1 = firstName1;
            SecondName1 = secondName1;
            Number1 = number1;
            EMail1 = eMail1;
        }

        public override string ToString()
        {
            return $"Contact[ID = {Id1}]:" + Environment.NewLine +
                $" First name : {FirstName1}" + Environment.NewLine +
                $" Second name : {SecondName1}" + Environment.NewLine +
                $" Number : {Number1}" + Environment.NewLine +
                $" EMail : {EMail1}";
        }
    }
}
