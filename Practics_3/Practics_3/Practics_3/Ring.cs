using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics_3
{
    class Ring<T> where T: Human
    {
        private List<T> list;
        private IEnumerator<T> enumerator;

        public Ring()
        {
            list = new List<T>();
        }

        public void addEnum()
        {
            enumerator = list.GetEnumerator();
        }

        public T moveNext()
        {
            enumerator.MoveNext();
            if (enumerator.Current == null)
            {
                enumerator.Reset();
            }
            return enumerator.Current;
        }

        public void removeElement(T element)
        {
            element.getId();
            list.Remove(element);
        }

        public T current()
        {
            return enumerator.Current;
        }

        public void reset()
        {
            enumerator.Reset();
        }

        public void add(T element)
        {
            list.Add(element);
        }
    }
}
