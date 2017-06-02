namespace KingsGambit
{
    using System;
    using System.Collections.Generic;

    public class Kingdom
    {
        private King king;

        static Kingdom()
        {
            RoyalGuardSet = new HashSet<RoyalGuard>(new EqualityComparerRoyalGuard<RoyalGuard>());
            FootmanSet = new HashSet<Footman>(new EqualityComparerFootman<Footman>());
        }

        public Kingdom(King king)
        {
            this.king = king;          
        }

        public static HashSet<RoyalGuard> RoyalGuardSet { get; private set; }

        public static HashSet<Footman> FootmanSet { get; private set; }

        public static void AddRoyalGuard(RoyalGuard royalGuard)
        {
            RoyalGuardSet.Add(royalGuard);
        }

        public static void AddFootman(Footman footman)
        {
            FootmanSet.Add(footman);
        }

        public static void KillRoyalGuar(RoyalGuard royalGuard)
        {
            RoyalGuardSet.Remove(royalGuard);
        }

        public static void KillFootman(Footman footman)
        {
            FootmanSet.Remove(footman);
        }

        public void AttakKing()
        {
            Console.WriteLine($"King {this.king.Name} is under attack!");
        }       
    }
}
