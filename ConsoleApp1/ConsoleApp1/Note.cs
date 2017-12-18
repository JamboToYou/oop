using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Note
    {
        private int ID;
        private string FirstName;

        public Note(int iD, string firstName)
        {
            ID1 = iD;
            FirstName1 = firstName;
        }

        public int ID1 { get => ID; set => ID = value; }
        public string FirstName1 { get => FirstName; set => FirstName = value; }

        public override string ToString()
        {
            return $"Contact : \n {ID}, {FirstName}";
        }
    }
}
