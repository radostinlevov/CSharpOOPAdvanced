using System;
using System.Collections.Generic;

namespace StrategyPattern
{
    public class NameComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            int result = x.Name.Length.CompareTo(y.Name.Length);

            if (result == 0)
            {
                char firstLetterX = x.Name[0];
                char firstLetterY = y.Name[0];

               result = string.Compare(firstLetterX.ToString(), firstLetterY.ToString(), StringComparison.OrdinalIgnoreCase);
            }

            return result;
        }
    }
}