﻿namespace MilitaryElite.Models
{
    public class Mission : Commando
    {
        public Mission(string codeName, string state)
        {
            this.CodeName = codeName;
            this.State = state;
        }

        public string CodeName { get; protected set; }

        public string State { get; protected set; }

        public void CompleteMission()
        {
            this.State = "Finished";
        }
    }
}
