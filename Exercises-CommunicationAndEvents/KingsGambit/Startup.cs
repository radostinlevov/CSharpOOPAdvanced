namespace KingsGambit
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            string kingName = Console.ReadLine();
            string[] royalGuardNames = Console.ReadLine().Split();
            string[] footmansNames = Console.ReadLine().Split();

            King king = new King(kingName);
            Kingdom kingdom = new Kingdom(king);

            foreach (var name in royalGuardNames)
            {
                RoyalGuard royalGuard = new RoyalGuard(name);
                Kingdom.AddRoyalGuard(royalGuard);
            }

            foreach (var name in footmansNames)
            {
                Footman footman = new Footman(name);
                Kingdom.AddFootman(footman);
            }

            string commandLine = Console.ReadLine();

            while (commandLine != "End")
            {
                string[] commandArgs = commandLine.Split();
                string command = commandArgs[0];

                switch (command)
                {
                    case "Attack":
                        kingdom.AttakKing();

                        foreach (var royalGuard in Kingdom.RoyalGuardSet)
                        {
                            Console.WriteLine($"Royal Guard {royalGuard.Name} is defending!");
                        }

                        foreach (var footman in Kingdom.FootmanSet)
                        {
                            Console.WriteLine($"Footman {footman.Name} is panicking!");
                        }
                        break;
                    case "Kill":
                        string name = commandArgs[1];

                        var royalGuardForKill = Kingdom.RoyalGuardSet.FirstOrDefault(r => r.Name == name);
                        var footmanForKill = Kingdom.FootmanSet.FirstOrDefault(f => f.Name == name);

                        if (footmanForKill == null)
                        {
                            Kingdom.KillRoyalGuar(royalGuardForKill);                            
                        }
                        else if (royalGuardForKill == null)
                        {
                            Kingdom.KillFootman(footmanForKill);                                                       
                        }

                        break;
                }

                commandLine = Console.ReadLine();
            }           
        }
    }
}
