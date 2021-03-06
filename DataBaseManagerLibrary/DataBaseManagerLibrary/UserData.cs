using System;
using System.Text;
using System.Collections.Generic;
using System.Text;

namespace DataBaseManagerLibrary
{
    public class UserData
    {
        //the UUID of the user. -1 infers that the person has no Id
        public int Id;
        public string PlayerName;
        public int amountOfCake;
        public int[] upgradeCount;

        public UserData()
        {
            Id = -1;
            upgradeCount = new int[7];
        }

        public UserData(int id, string playerName, int amountOfCake, int[] upgradeCount)
        {
            Id = id;
            PlayerName = playerName;
            this.amountOfCake = amountOfCake;
            this.upgradeCount = upgradeCount;
        }

        public void Print(Action<string> writer)
        {
            writer(Id + "\n" + PlayerName + "\n" + amountOfCake);
            StringBuilder upgrades = new StringBuilder();
            foreach(int i in upgradeCount)
            {
                upgrades.Append(i.ToString() + " ");
            }
            writer(upgrades.ToString());
        }
    }
}
