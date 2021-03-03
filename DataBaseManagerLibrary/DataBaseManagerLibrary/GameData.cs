using System;
using System.Text;
using System.Collections.Generic;
using System.Text;

namespace DataBaseManager
{
    public class GameData
    {
        //the UUID of the user. -1 infers that the person has no Id
        public int Id;
        public string PlayerName;
        public int amountOfCake;
        public int[] upgradeCount;

        public GameData()
        {
            Id = -1;
            upgradeCount = new int[7];
        }

        public GameData(int id, string playerName, int amountOfCake, int[] upgradeCount)
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
