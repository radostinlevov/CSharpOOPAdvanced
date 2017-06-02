namespace KingsGambit
{
    using System.Collections.Generic;

    public class EqualityComparerFootman<T> : IEqualityComparer<Footman> 
    {
        public bool Equals(Footman x, Footman y)
        {
            return x.Name.Equals(y.Name);
        }

        public int GetHashCode(Footman obj)
        {
            return obj.Name.GetHashCode();
        }
    }
}