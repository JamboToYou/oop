using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Example
    {
        private string str;

        public Example() { }

        public Example(string str)
        {
            this.str = str;
        }

        public override string ToString()
        {
            return str;
        }
    }
}
