using System;
using System.Collections.Generic;

namespace EnumerableExtentionMethod
{
    public static class EnumerableExtention
    {
        public static IEnumerable<T> ForeEach<T>
            (this IEnumerable<T> collection, Action<T> action)
        {
            foreach (var element in collection)
            {
                action(element);
            }

            return collection;
        }
    }
}
