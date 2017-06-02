using System;
using System.Collections.Generic;

namespace GenericCountMethodStrings
{
    public class Box<T>
       
    {
        public Box(T value)
        {
            this.Value = value;
        }

        public T Value { get; }

        public static int CountGreaterElements(List<Box<string>> listOfData, string element)
        {
            int count = 0;

            foreach (var item in listOfData)
            {
                if (string.Compare(item.Value, element) > 0)
                {
                    count++;
                }
            }

            return count;
        }

        public override string ToString()
        {
            return $"{this.Value.GetType().FullName}: {this.Value}";
        }
    }
}
