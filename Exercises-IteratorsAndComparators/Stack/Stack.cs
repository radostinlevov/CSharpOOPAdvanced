using System;
using System.Collections;
using System.Collections.Generic;

namespace Stack
{
    public class Stack<T> : IEnumerable<T>
    {
        private List<T> collection;

        public Stack()
        {
            this.collection = new List<T>();
        }

        public List<T> Collection => this.collection;


        public void Push(T element)
        {
            this.collection.Add(element);
        }

        public void Pop()
        {
            if (this.collection.Count == 0)
            {
                throw new ArgumentException("No elements");
            }

            T lastElement = this.collection[this.Collection.Count - 1];
            int index = this.collection.IndexOf(lastElement);
            this.collection.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.collection.Count - 1; i >= 0; i--)
            {
                yield return this.collection[i];
            }
        }
    }
}
