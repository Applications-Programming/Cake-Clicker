using DataBaseManager;
using System;
using System.Collections.Generic;

namespace CakeClickerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ConnectionInfo connectionInfo = new ConnectionInfo(
                "cake-clicker-server.database.windows.net",
                "CakeClicker",
                "DefaultUser",
                "CakeClicker123");

            DatabaseManager database = DatabaseManager.CreateDatabaseManager(connectionInfo, Console.WriteLine);

            List<GameData> gameData = database.GetHighScores(10);

            foreach(GameData game in gameData)
            {
                game.Print(Console.WriteLine);
            }

            Console.ReadLine();
        }
    }
}
