using DataBaseManager;
using System;

namespace CakeClickerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseManager.ConnectionInfo connectionInfo = new DatabaseManager.ConnectionInfo(
                "cake-clicker-server.database.windows.net",
                "CakeClicker",
                "DefaultUser",
                "CakeClicker123");

            DatabaseManager database = DatabaseManager.CreateDatabaseManager(connectionInfo, Console.WriteLine);

            int id = database.SaveToDatabase(new GameData(2, "Yarra", 2000, null));

            Console.WriteLine(id);

            Console.ReadLine();
        }
    }
}
