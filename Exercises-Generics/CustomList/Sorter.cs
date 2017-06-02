using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class Sorter<T>
         where T : IComparable<T>
    {
        public static List<T> Sort(CustomList<T> collection)
        {
            List<T> orderedList = collection.ListOfData.OrderBy(e => e).ToList();
            return orderedList;
        }
    }
}
