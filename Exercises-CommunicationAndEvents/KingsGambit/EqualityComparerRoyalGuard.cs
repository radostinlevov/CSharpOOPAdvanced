namespace KingsGambit
{
    using System.Collections.Generic;

    public class EqualityComparerRoyalGuard<T> : IEqualityComparer<RoyalGuard>
    {
        public bool Equals(RoyalGuard x, RoyalGuard y)
        {
            return x.Name.Equals(y.Name);
        }

        public int GetHashCode(RoyalGuard obj)
        {
            return obj.Name.GetHashCode();
        }
    }
}