using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics_51
{
    class Person
    {
        private string fstName;
        private string lstName;
        private string phone;
        private string eMail;

        public Person(string fstName, string sndName, string phone, string eMail)
        {
            FstName = fstName;
            LstName = sndName;
            Phone = phone;
            EMail = eMail;
        }

        public string FstName { get => fstName; set => fstName = value; }
        public string LstName { get => lstName; set => lstName = value; }
        public string Phone { get => phone; set => phone = value; }
        public string EMail { get => eMail; set => eMail = value; }

        public override string ToString()
        {
            return "PERSON :" + Environment.NewLine +
                $" Имя : {fstName}" + Environment.NewLine +
                $" Фамилия: {lstName}" + Environment.NewLine +
                $" Номер : {phone}" + Environment.NewLine +
                $" E-Mail : {eMail}";
        }
    }
}
