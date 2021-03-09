//Game Class which is the backend for the Cake Clicker Game
//Created by Tyler, Yarra, Noah and Keagan
//Authored: 2/9/2021
using System;
using System.IO;
using System.Diagnostics;
using System.Threading;
using DataBaseManager;
using Cake_Clicker_Game;

public class Game
{
    ///Class Fields
    //GameData object for holding game information
    private GameData _gameInfo;

    private int _cakePerClick;
    private double _multiplierOnCakeClick;
    private Achievement achievements;
    private int _goldenCakes;
    private int _mostRecentClickEarnings;
    private DatabaseManager _databaseManager;
    public readonly bool _offlineMode = false;
    private int _gameMode;
    private string _stopWatchToString;
    private bool _isMostRecentGold;
    Stopwatch _stopwatch = new Stopwatch();


    //Cheat Detection & Click Analytics
    internal ClickAnalytics _clickData;

    ///Enums
    ///[0] == Vanilla , [1] == Choclate, [2] == Strawberry, [3] == Coffee, [4] == Red_Velvet, [5] == Carrot, [6] == Cheese
    public enum CakeType
    {
        Vanilla = 0, Chocolate = 1, Strawberry = 2, Coffee = 3, Red_Velvet = 4, Carrot = 5, Cheese = 6
    }

    ///Constructor
    public Game(int gameMode)
    {
        DatabaseManager.ConnectionInfo connectionInfo = new DatabaseManager.ConnectionInfo(
            "cake-clicker-server.database.windows.net",
            "CakeClicker",
            "DefaultUser",
            "CakeClicker123");
        _databaseManager = DatabaseManager.CreateDatabaseManager(connectionInfo, CakeClicker.GetUserInterfaceManager().SendUserMessage);
        if (_databaseManager != null)
        {
            _offlineMode = false;
        }

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
        _goldenCakes = 0;
        _mostRecentClickEarnings = 0;
        _gameMode = gameMode;
        _stopWatchToString = "null";
        _isMostRecentGold = false;

        if (_gameMode == 1)
        {
            _stopwatch.Start();
        }

        //Click Analytics & Cheat detection
        _clickData = new ClickAnalytics();
    }


    //Allows the UserInterface class to say a click was detected
    public void AddUserClick()
    {
        _clickData.AddUserClick();
    }


    /// <summary>
    /// Game Methods
    /// </summary>

    //This method is for adding cake to the total amount of cake based on the values held in the cake multiplier and cakePerClick 
    public void AddCake()
    {
        if(_gameMode == 0 || (_gameMode == 1 && _gameInfo.amountOfCake <= 1000000))
        {
            bool result = GoldenCakeRandomizer();
            _isMostRecentGold = result; 

            if (result == true)
            {
                _gameInfo.amountOfCake += (int)(_cakePerClick * _multiplierOnCakeClick);
                _gameInfo.amountOfCake += 500;
                _mostRecentClickEarnings = 500 + (int)(_cakePerClick * _multiplierOnCakeClick);
            }
            else
            {
                _gameInfo.amountOfCake += (int)(_cakePerClick * _multiplierOnCakeClick);
                _mostRecentClickEarnings = (int)(_cakePerClick * _multiplierOnCakeClick);
            }
            achievements.GetGameData(_gameInfo, _goldenCakes);
        }
        else
        {
            MillionCakesStopWatch();
        }
    }

    //This method adds a specified amount of cake manually
    public void AddCakeManually(int cakeAmount)
    {
        _gameInfo.amountOfCake += cakeAmount;
        achievements.GetGameData(_gameInfo, _goldenCakes);
    }

    //This method returns the amount of cake stored in _amountOfCake
    public int GetAmountOfCake()
    {
        return _gameInfo.amountOfCake;
    }

    public bool GetIsMostRecentGold()
    {
        return _isMostRecentGold;
    }

    public int GetGamemode()
    {
        return _gameMode;
    }
    public int[] GetUpgradeCount()
    {
        return _gameInfo.upgradeCount;
    }

    //This method returns the current multiplier as a double
    public double GetMultiplier()
    {
        return _multiplierOnCakeClick;
    }

    public int GetMostRecentEarnings()
    {
        return _mostRecentClickEarnings;
    }

    public int GetGoldenCakeCount()
    {
        return _goldenCakes;
    }

    public string GetStopWatchToString()
    {
        return _stopWatchToString;
    }
    public bool GoldenCakeRandomizer()
    {
        Random random = new System.Random();
        int value = random.Next(0, 1000); //returns integer of 0-100
        if (value == 500)
        {
            _goldenCakes += 1;
            return true;
        }
        return false;
    }

    public string MillionCakesStopWatch()
    {
        if (_gameInfo.amountOfCake == 1000000)
        {
            _stopwatch.Stop();
            TimeSpan ts = _stopwatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            _stopWatchToString = elapsedTime;
            return elapsedTime;
        }
        return "null";
    }

    //This method increments the multiplier to the next tier
    public void IncrementMultiplier()
    {
        _multiplierOnCakeClick += 0.25;
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

        //Resets analytics
        _clickData = new ClickAnalytics();

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

    public void SaveGameToCloud()
    {
        if (_databaseManager != null)
        {
            _gameInfo.Id = _databaseManager.SaveToDatabase(_gameInfo);
        }
        else
        {
            return;
        }
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

    public bool LoadFromCloud(int id)
    {
        if (_databaseManager != null)
        {
            //online mode is enabled
            GameData gameData = _databaseManager.GetUserInfo(id);
            if (gameData == null)
            {
                return false;
            }

            _gameInfo = gameData;
        }
        else
        {
            //returns false because offline mode is activated
            return false;
        }

        return true;
    }


    //This takes in a parameter CakeType which is what type of cake is being added to the clicking system.
    //Returns true if the cake was successfully added and returns false if the player doesn't have enough cake for the transaction
    public bool AddCakeUpgrade(CakeType addedCake)
    {
        //adds the upgrade to the game based off the cake type passed in
        if (addedCake == CakeType.Vanilla && _gameInfo.amountOfCake >= 50)
        {
            _cakePerClick += 5;
            _gameInfo.amountOfCake -= 50;
            _gameInfo.upgradeCount[0] += 1;
            achievements.GetGameData(_gameInfo, _goldenCakes);
            return true;
        }
        else if (addedCake == CakeType.Chocolate && _gameInfo.amountOfCake >= 250)
        {
            _cakePerClick += 10;
            _gameInfo.amountOfCake -= 250;
            _gameInfo.upgradeCount[1] += 1;
            achievements.GetGameData(_gameInfo, _goldenCakes);
            return true;
        }
        else if (addedCake == CakeType.Strawberry && _gameInfo.amountOfCake >= 500)
        {
            _cakePerClick += 25;
            _gameInfo.amountOfCake -= 500;
            _gameInfo.upgradeCount[2] += 1;
            achievements.GetGameData(_gameInfo, _goldenCakes);
            return true;
        }
        else if (addedCake == CakeType.Coffee && _gameInfo.amountOfCake >= 1000)
        {
            _cakePerClick += 50;
            _gameInfo.amountOfCake -= 1000;
            _gameInfo.upgradeCount[3] += 1;
            achievements.GetGameData(_gameInfo, _goldenCakes);
            return true;
        }
        else if (addedCake == CakeType.Red_Velvet && _gameInfo.amountOfCake >= 4500)
        {
            _cakePerClick += 150;
            _gameInfo.amountOfCake -= 4500;
            _gameInfo.upgradeCount[4] += 1;
            achievements.GetGameData(_gameInfo, _goldenCakes);
            return true;
        }
        else if (addedCake == CakeType.Carrot && _gameInfo.amountOfCake >= 20000)
        {
            _cakePerClick += 250;
            _gameInfo.amountOfCake -= 20000;
            _gameInfo.upgradeCount[5] += 1;
            achievements.GetGameData(_gameInfo, _goldenCakes);
            return true;
        }
        else if (addedCake == CakeType.Cheese && _gameInfo.amountOfCake >= 80000)
        {
            _cakePerClick += 400;
            _gameInfo.amountOfCake -= 80000;
            _gameInfo.upgradeCount[6] += 1;
            achievements.GetGameData(_gameInfo, _goldenCakes);
            return true;
        }
        return false;
    }

    //Gets the max cps from the click analytics object
    public int GetMaxCPS()
    {
        return _clickData.GetMaxCPS();
    }

    //Gets the average cps from the click analytics object
    public double GetAverageCPS()
    {
        return _clickData.AverageCPS();
    }

    //Returns a bool that shows where the player is cheating or not
    public bool GetCheatStatus()
    {
        return _clickData.GetCheatStatus();
    }

    public void CheckAchivements()
    {
        achievements.GetGameData(_gameInfo, _goldenCakes);
    }

    public bool[] GetAchivements()
    {
        return achievements.GetAchivementsInfo();
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

    public int GetPlayerId()
    {
        return _gameInfo.Id;
    }


}


public class Test
{
    static void MainTesting()
    {
        Console.WriteLine("Testing game clicks, multiplier, and caketype...");
        Game game = new Game(1);
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

