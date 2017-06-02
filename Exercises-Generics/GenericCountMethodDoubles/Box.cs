using System.Collections.Generic;

namespace GenericCountMethodDoubles
{
    public class Box<T>
    {
        public Box(T value)
        {
            this.Value = value;
        }

        public T Value { get; }

        public static int CountGreaterElements(List<Box<double>> listOfData, double element)
        {
            int count = 0;

            foreach (var item in listOfData)
            {
                if (item.Value.CompareTo(element) > 0)
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
