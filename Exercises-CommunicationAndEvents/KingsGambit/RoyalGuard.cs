namespace KingsGambit
{
    using System;

    public class RoyalGuard
    {
        public RoyalGuard(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }     
    }
}