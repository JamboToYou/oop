using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics_3
{
    class Human
    {
        private int id;

        public Human(int id)
        {
            this.id = id;
        }

        public int getId()
        {
            return id;
        }

        public override string ToString()
        {
            return id.ToString();
        }
    }
}
