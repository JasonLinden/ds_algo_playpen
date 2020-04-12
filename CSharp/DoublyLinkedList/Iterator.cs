using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DoublyLinkedList
{
    public class Iterator : IEnumerable
    {
        private Link current;
        private Link pervious;
        private LinkedList ourList;

        public Iterator(LinkedList list)
        {
            ourList = list;
            Reset();
        }

        public IEnumerator<Link> GetEnumerator()
        {
            var current = this.current;

            while(current != null)
            {
                yield return current;
                current = current.next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            var current = this.current;

            while (current != null)
            {
                yield return current;
                current = current.next;
            }
        }

        private void Reset()
        {
            current = ourList.GetFirst();
            pervious = null;
        }
    }
}
