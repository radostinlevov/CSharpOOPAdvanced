using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilitaryElite.Models;

namespace MilitaryElite
{
    class StartUp
    {
        static void Main()
        {
            List<Soldier> soldiers = new List<Soldier>();

            string inputLine = Console.ReadLine();
            while (inputLine != "End")
            {
                string[] inputTokens = inputLine.Split();

                string typeOfSoldier = inputTokens[0];
                uint id = uint.Parse(inputTokens[1]);
                string firstName = inputTokens[2];
                string lastName = inputTokens[3];

                switch (typeOfSoldier)
                {
                    case "Private":
                        double salary = double.Parse(inputTokens[4]);

                        var privateSoldier = new Private(typeOfSoldier, id, firstName, lastName, salary);
                        soldiers.Add(privateSoldier);
                        break;
                    case "LeutenantGeneral":

                        double salaryL = double.Parse(inputTokens[4]);

                        var leutenantGeneral = new LeutenantGeneral(typeOfSoldier, id, firstName, lastName, salaryL);

                        for (int i = 5; i < inputTokens.Length; i++)
                        {
                            leutenantGeneral.Ids.Add(int.Parse(inputTokens[i]));
                        }

                        foreach (var soldier in soldiers)
                        {
                            if (soldier.TypeOfSoldier == "Private")
                            {
                                leutenantGeneral.Privates.Add((Private)soldier);
                            }
                        }

                        soldiers.Add(leutenantGeneral);

                        break;
                    case "Engineer":
                        double salaryE = double.Parse(inputTokens[4]);
                        string corpsE = inputTokens[5];

                        switch (corpsE)
                        {
                            case "Airforces":
                                var engineer = new Engineer(typeOfSoldier, id, firstName, lastName, salaryE, Corps.Airforces);

                                AddRepair(inputTokens, engineer);
                                soldiers.Add(engineer);
                                break;
                            case "Marines":
                                engineer = new Engineer(typeOfSoldier, id, firstName, lastName, salaryE, Corps.Marines);

                                AddRepair(inputTokens, engineer);
                                soldiers.Add(engineer);
                                break;
                        }
                        break;
                    case "Commando":
                        double salaryC = double.Parse(inputTokens[4]);
                        string corps = inputTokens[5];

                        switch (corps)
                        {
                            case "Airforces":
                                var comando = new Commando(typeOfSoldier, id, firstName, lastName, salaryC, Corps.Airforces);
                                AddMission(inputTokens, comando);

                                soldiers.Add(comando);
                                break;
                            case "Marines":
                                comando = new Commando(typeOfSoldier, id, firstName, lastName, salaryC, Corps.Marines);
                                AddMission(inputTokens, comando);
                                soldiers.Add(comando);
                                break;
                        }
                        break;
                    case "Spy":
                        string codeNumber = inputTokens[4];

                        var spy = new Spy(typeOfSoldier, id, firstName, lastName, codeNumber);
                        soldiers.Add(spy);
                        break;

                }

                inputLine = Console.ReadLine();
            }

            foreach (var soldier in soldiers)
            {
                Console.WriteLine(soldier);
            }
        }

        private static void AddRepair(string[] inputTokens, Engineer engineer)
        {
            for (int i = 6; i < inputTokens.Length; i += 2)
            {
                string partName = inputTokens[i];
                int hoursWorked = int.Parse(inputTokens[i + 1]);

                var repair = new Repair(partName, hoursWorked);
                engineer.Repairs.Add(repair);
            }
        }

        private static void AddMission(string[] inputTokens, Commando comando)
        {
            for (int i = 6; i < inputTokens.Length; i += 2)
            {
                string codeName = inputTokens[i];
                string state = inputTokens[i + 1];

                if (state == "inProgress")
                {
                    var mission = new Mission(codeName, "inProgress");
                    comando.Missions.Add(mission);
                }
                else if (state == "Finished")
                {
                    var mission = new Mission(codeName, "Finished");
                    comando.Missions.Add(mission);
                }
            }
        }
    }
}
