using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerableExtentionMethod
{
    class Startup
    {
        static void Main()
        {
            HashSet<int> set = new HashSet<int>();

            set.Add(1);
            set.Add(2);
            set.Add(3);
            set.Add(4);

           set.ForeEach()
        }
    }
}
