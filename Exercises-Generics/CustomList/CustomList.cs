using System.Collections;

namespace CustomList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class CustomList<T> : IEnumerable<T>
        where T : IComparable<T>
    {
        public CustomList()
        {
            this.ListOfData = new List<T>();
        }

        public List<T> ListOfData { get; internal set; }

        public int Count => ListOfData.Count;

        public void Add(T element)
        {
            this.ListOfData.Add(element);
        }

        public T Remove(int index)
        {
            T element = this.ListOfData[index];
            this.ListOfData.RemoveAt(index);
            return element;
        }

        public bool Contains(T element)
        {
            return this.ListOfData.Contains(element);
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            T firstElement = this.ListOfData[firstIndex];
            T secondElement = this.ListOfData[secondIndex];

            this.ListOfData.RemoveAt(firstIndex);
            this.ListOfData.Insert(firstIndex, secondElement);
            this.ListOfData.RemoveAt(secondIndex);
            this.ListOfData.Insert(secondIndex, firstElement);
        }

        public int CountGreaterThan(T element)
        {
            int count = 0;

            foreach (var item in this.ListOfData)
            {
                if (string.Compare(item.ToString(), element.ToString()) > 0)
                {
                    count++;
                }
            }

            return count;
        }

        public T Max()
        {
            return this.ListOfData.Max();
        }

        public T Min()
        {
            return this.ListOfData.Min();
        }

        //public string Print()
        //{
        //    StringBuilder sb = new StringBuilder();

        //    foreach (var element in ListOfData)
        //    {
        //        sb.AppendLine(element.ToString());
        //    }

        //    return sb.ToString().Trim();
        //}

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this.ListOfData.GetEnumerator();
        }
    }
}