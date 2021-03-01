//Game Class which is the backend for the Cake Clicker Game
//Created by Tyler, Yarra, Noah and Keagan
//Authored: 2/9/2021
using System;
using System.IO;

public class Game
{
    ///Class Fields
    //GameData object for holding game information
    private GameData _gameInfo;

    private int _cakePerClick;
    private double _multiplierOnCakeClick;
    private Achievement achievements;
    //[0] == Vanilla , [1] == Choclate, [2] == Strawberry, [3] == Coffee, [4] == Red_Velvet, [5] == Carrot, [6] == Cheese

    private DatabaseManager _databaseManager;

    ///Enums
    public enum CakeType
    {
        Vanilla = 0, Chocolate = 1, Strawberry = 2, Coffee = 3, Red_Velvet = 4, Carrot = 5, Cheese = 6
    }

    ///Constructor
    public Game()
    {
        DatabaseManager.ConnectionInfo connectionInfo = new DatabaseManager.ConnectionInfo(
            "cake-clicker-server.database.windows.net",
            "CakeClicker",
            "DefaultUser",
            "CakeClicker123");
        _databaseManager = DatabaseManager.CreateDatabaseManager(connectionInfo);
        achievements = new Achievement();
        int[] temp = new int[7];
        for (int i = 0; i < 7; i++)
        {
            temp[i] = 0;
        }
        //GameData object for holding game information
        _gameInfo = new GameData(-1, "null", 0, temp);
        _cakePerClick = 1;
        _multiplierOnCakeClick = 1.0;
    }

    /// <summary>
    /// Game Methods
    /// </summary>

    //This method is for adding cake to the total amount of cake based on the values held in the cake multiplier and cakePerClick 
    public void AddCake()
    {
        _gameInfo.amountOfCake += (int)(_cakePerClick * _multiplierOnCakeClick);
        this.CheckAchivements();
    }

    //This method adds a specified amount of cake manually
    public void AddCakeManually(int cakeAmount)
    {
        _gameInfo.amountOfCake += cakeAmount;
    }

    //This method returns the amount of cake stored in _amountOfCake
    public int GetAmountOfCake()
    {
        return _gameInfo.amountOfCake;
    }

    public int[] GetUpgradeCount()
    {
        return _gameInfo.upgradeCount;
    }

    //This method increments the multiplier to the next tier
    public void IncrementMultiplier()
    {
        _multiplierOnCakeClick += 0.25;
    }

    //This method returns the current multiplier as a double
    public double GetMultiplier()
    {
        return _multiplierOnCakeClick;
    }

    //This is a ToString override which returns the name of the game
    public override String ToString()
    {
        return "Cake Clicker";
    }

    //This method resets the game state. This should set all game fields back to their starting values
    public void ResetGame()
    {
        _gameInfo.PlayerName = "null";
        _gameInfo.amountOfCake = 0;
        _cakePerClick = 1;
        _multiplierOnCakeClick = 1.0;

        int[] temp = new int[7];

        for (int i = 0; i < temp.Length; i++)
        {
            temp[i] = 0;
        }

        _gameInfo.upgradeCount = temp;
    }

    //This method does a simple save of the game settings to a text file
    public bool SaveGameToFile()
    {
        DateTime now = DateTime.Now;
        string text = _gameInfo.PlayerName + '\n' + _gameInfo.amountOfCake + '\n' + _cakePerClick + '\n' + _multiplierOnCakeClick + '\n' + now.ToString("F");
        string path = AppDomain.CurrentDomain.BaseDirectory + @"CakeGameData.txt";

        File.WriteAllText(path, text);

        return true;
    }

    public bool LoadFile()
    {
        try
        {
            File.Exists("CakeGameData.txt");
            string[] text = System.IO.File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + @"CakeGameData.txt");
            _gameInfo.PlayerName = text[0];
            _gameInfo.amountOfCake = Int32.Parse(text[1]);
            _cakePerClick = Int32.Parse(text[2]);
            _multiplierOnCakeClick = double.Parse(text[3]);

            return true;
        }
        catch (Exception e)
        {
            ResetGame();

            return false;
        }
    }


    //This takes in a parameter CakeType which is what type of cake is being added to the clicking system.
    //Returns true if the cake was successfully added and returns false if the player doesn't have enough cake for the transaction
    public bool AddCakeUpgrade(CakeType addedCake)
    {

        if (addedCake == CakeType.Vanilla && _gameInfo.amountOfCake >= 50)
        {
            _cakePerClick += 5;
            _gameInfo.amountOfCake -= 50;
            _gameInfo.upgradeCount[0] += 1;
            this.CheckAchivements();
            return true;
        }
        else if (addedCake == CakeType.Chocolate && _gameInfo.amountOfCake >= 250)
        {
            _cakePerClick += 10;
            _gameInfo.amountOfCake -= 250;
            _gameInfo.upgradeCount[1] += 1;
            this.CheckAchivements();
            return true;
        }
        else if (addedCake == CakeType.Strawberry && _gameInfo.amountOfCake >= 500)
        {
            _cakePerClick += 25;
            _gameInfo.amountOfCake -= 500;
            _gameInfo.upgradeCount[2] += 1;
            this.CheckAchivements();
            return true;
        }
        else if (addedCake == CakeType.Coffee && _gameInfo.amountOfCake >= 1000)
        {
            _cakePerClick += 50;
            _gameInfo.amountOfCake -= 1000;
            _gameInfo.upgradeCount[3] += 1;
            this.CheckAchivements();
            return true;
        }
        else if (addedCake == CakeType.Red_Velvet && _gameInfo.amountOfCake >= 4500)
        {
            _cakePerClick += 150;
            _gameInfo.amountOfCake -= 4500;
            _gameInfo.upgradeCount[4] += 1;
            this.CheckAchivements();
            return true;
        }
        else if (addedCake == CakeType.Carrot && _gameInfo.amountOfCake >= 20000)
        {
            _cakePerClick += 250;
            _gameInfo.amountOfCake -= 20000;
            _gameInfo.upgradeCount[5] += 1;
            this.CheckAchivements();
            return true;
        }
        else if (addedCake == CakeType.Cheese && _gameInfo.amountOfCake >= 80000)
        {
            _cakePerClick += 400;
            _gameInfo.amountOfCake -= 80000;
            _gameInfo.upgradeCount[6] += 1;
            this.CheckAchivements();
            return true;
        }
        return false;
    }

    public void CheckAchivements()
    {
        achievements.GetGameData(_gameInfo);
    }

    //Sets the player name
    public void SetPlayerName(string playerName)
    {
        _gameInfo.PlayerName = playerName;
    }

    //Returns the player name
    public string GetPlayerName()
    {
        return _gameInfo.PlayerName;
    }

    public struct GameData
    {
        public int Id;
        public string PlayerName;
        public int amountOfCake;
        public int[] upgradeCount;

        public GameData(int id, string playerName, int amountOfCake, int[] upgradeCount)
        {
            Id = id;
            PlayerName = playerName;
            this.amountOfCake = amountOfCake;
            this.upgradeCount = upgradeCount;
        }
    }
}

public class Achievement
{
    public struct AchievementInfo
    {
        public string Name;
        public bool Active; 
    }

    static private int achievementCount = 4;
    public AchievementInfo[] achievements = new AchievementInfo[achievementCount];

    public Achievement()
    {
        achievements[0].Name = "Cake Novice";
        achievements[0].Active = false;

        achievements[1].Name = "Cake Master";
        achievements[1].Active = false;

        achievements[2].Name = "Bakery Legend";
        achievements[2].Active = false;

        achievements[3].Name = "Recipe Book";
        achievements[3].Active = false;
    }

    public void GetGameData(Game.GameData data)
    {
        if(data.amountOfCake == 100)
        {
            achievements[0].Active = true;
        }

        if (data.amountOfCake == 1000)
        {
            achievements[1].Active = true;
        }

        if (data.amountOfCake == 10000)
        {
            achievements[2].Active = true;
        }

        if (achievements[3].Active == false)
        {
            for(int i = 0; i < 7; i++)
            {
                if(data.upgradeCount[i] == 0)
                {
                    achievements[3].Active = false;
                    break;
                }
                achievements[3].Active = true;
            }
        }
    }

    public bool IsAchievementActive(string achievementName)
    {
        for (int i = 0; i < achievementCount; i++)
        {
            if(achievements[i].Name == achievementName)
            {
                return true;
            }
        }
        return false;
    }

    public void ResetAchievements()
    {
        for (int i = 0; i < achievementCount; i++)
        {
            achievements[i].Active = false;
        }
    }

    public void ActivateAll()
    {
        for (int i = 0; i < achievementCount; i++)
        {
            achievements[i].Active = true;
        }
    }
}

public class Test
{
    static void MainTesting()
    {
        Console.WriteLine("Testing game clicks, multiplier, and caketype...");
        Game game = new Game();
        for (int i = 0; i < 200; i++)
        {
            game.AddCake();
            if (i % 20 == 0)
            {
                game.IncrementMultiplier();
            }
            //game.ChangeCakeType();
            //Console.WriteLine("CURRENT CAKE TYPE: " + game.AccessCakeType());
        }
        Console.WriteLine("Testing game ToString...");
        Console.WriteLine(game.ToString());

        Console.WriteLine("Testing Get Methods...");
        game.GetMultiplier();
        game.GetAmountOfCake();

        Console.WriteLine("Testing SaveGameToFile...");
        game.SaveGameToFile();
        game.ResetGame();
        Console.WriteLine("Clicks" + game.GetAmountOfCake());
        game.LoadFile();
        Console.WriteLine("Clicks Loaded" + game.GetAmountOfCake());

        /**
         * 
         * try
        {
            File.Exists("CakeGameData.txt");
            Console.WriteLine("The File Exists IN THIS DIRECTORY");
        }
        catch
        {
            Console.WriteLine("The File Does NOT exist");
        }
         */

        Console.WriteLine("Testing Game Reset...");
        game.ResetGame();
        //****Changed this test case, please double check****
        if (game.GetAmountOfCake() == 0)
        {
            Console.WriteLine("All tests passed!");
        }

    }

}

