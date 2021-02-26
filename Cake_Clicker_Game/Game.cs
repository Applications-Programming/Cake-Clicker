//Game Class which is the backend for the Cake Clicker Game
//Created by Tyler, Yarra, Noah and Keagan
//Authored: 2/9/2021
using System;
using System.IO;

public class Game
{
    ///Class Fields
    private String _playerName;
    private int _amountOfCake;
    private int _cakePerClick;
    private double _multiplierOnCakeClick;
    private CakeType _currentCakeTier;
    //[0] == Vanilla , [1] == Choclate, [2] == Strawberry, [3] == Coffee, [4] == Red_Velvet, [5] == Carrot, [6] == Cheese
    private int[] _upgradeCount = new int[7];

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

        _playerName = "null";
        _amountOfCake = 0;
        _cakePerClick = 1;
        _multiplierOnCakeClick = 1.0;
        _currentCakeTier = 0;
        for (int i = 0; i < 7; i++)
        {
            _upgradeCount[i] = 0;
        }
    }

    /// <summary>
    /// Game Methods
    /// </summary>

    //This method is for adding cake to the total amount of cake based on the values held in the cake multiplier and cakePerClick 
    public void AddCake()
    {
        _amountOfCake += (int)(_cakePerClick * _multiplierOnCakeClick);
    }

    //This method returns the amount of cake stored in _amountOfCake
    public int GetAmountOfCake()
    {
        return _amountOfCake;
    }

    public int[] GetUpgradeCount()
    {
        return _upgradeCount;
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
        _playerName = "null";
        _amountOfCake = 0;
        _cakePerClick = 1;
        _multiplierOnCakeClick = 1.0;
        _currentCakeTier = 0;

        for (int i = 0; i < _upgradeCount.Length; i++)
        {
            _upgradeCount[i] = 0;
        }
    }

    //This method does a simple save of the game settings to a text file
    //This method does a simple save of the game settings to a text file
    public bool SaveGameToFile()
    {
        DateTime now = DateTime.Now;
        string text = _playerName + '\n' + _amountOfCake + '\n' + _cakePerClick + '\n' + _multiplierOnCakeClick + '\n' + _currentCakeTier + '\n' + now.ToString("F");
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
            _playerName = text[0];
            _amountOfCake = Int32.Parse(text[1]);
            _cakePerClick = Int32.Parse(text[2]);
            _multiplierOnCakeClick = double.Parse(text[3]);

            string cc = text[4];
            if (cc == "Vanilla")
            {
                _currentCakeTier = CakeType.Vanilla;
            }
            else if (cc == "Chocolate")
            {
                _currentCakeTier = CakeType.Chocolate;
            }
            else if (cc == "Strawberry")
            {
                _currentCakeTier = CakeType.Strawberry;
            }
            else if (cc == "Coffee")
            {
                _currentCakeTier = CakeType.Coffee;
            }
            else if (cc == "Red_Velvet")
            {
                _currentCakeTier = CakeType.Red_Velvet;
            }
            else if (cc == "Carrot")
            {
                _currentCakeTier = CakeType.Carrot;
            }
            else if (cc == "Cheese")
            {
                _currentCakeTier = CakeType.Cheese;
            }

            return true;
        }
        catch (Exception e)
        {
            _playerName = "null";
            _amountOfCake = 0;
            _cakePerClick = 1;
            _multiplierOnCakeClick = 1.0;
            _currentCakeTier = 0;

            return false;
        }
    }


    //This takes in a parameter CakeType which is what type of cake is being added to the clicking system.
    //Returns true if the cake was successfully added and returns false if the player doesn't have enough cake for the transaction
    public bool AddCakeUpgrade(CakeType addedCake)
    {
        if (addedCake == CakeType.Vanilla && _amountOfCake >= 50)
        {
            _cakePerClick += 5;
            _amountOfCake -= 50;
            _upgradeCount[0] += 1;
            return true;
        }
        else if (addedCake == CakeType.Chocolate && _amountOfCake >= 250)
        {
            _cakePerClick += 10;
            _amountOfCake -= 250;
            _upgradeCount[1] += 1;
            return true;
        }
        else if (addedCake == CakeType.Strawberry && _amountOfCake >= 500)
        {
            _cakePerClick += 25;
            _amountOfCake -= 500;
            _upgradeCount[2] += 1;
            return true;
        }
        else if (addedCake == CakeType.Coffee && _amountOfCake >= 1000)
        {
            _cakePerClick += 50;
            _amountOfCake -= 1000;
            _upgradeCount[3] += 1;
            return true;
        }
        else if (addedCake == CakeType.Red_Velvet && _amountOfCake >= 4500)
        {
            _cakePerClick += 150;
            _amountOfCake -= 4500;
            _upgradeCount[4] += 1;
            return true;
        }
        else if (addedCake == CakeType.Carrot && _amountOfCake >= 20000)
        {
            _cakePerClick += 250;
            _amountOfCake -= 20000;
            _upgradeCount[5] += 1;
            return true;
        }
        else if (addedCake == CakeType.Cheese && _amountOfCake >= 80000)
        {
            _cakePerClick += 400;
            _amountOfCake -= 80000;
            _upgradeCount[6] += 1;
            return true;
        }
        return false;
    }

    //Sets the player name
    public void SetPlayerName(string playerName)
    {
        _playerName = playerName;
    }

    //Returns the player name
    public string GetPlayerName()
    {
        return _playerName;
    }

    public struct GameData
    {
        public int Id;
        public string PlayerName;
        public int _amountOfCake;
        public int[] _upgradeCount;

        public GameData(int id, string playerName, int amountOfCake, int[] upgradeCount)
        {
            Id = id;
            PlayerName = playerName;
            _amountOfCake = amountOfCake;
            _upgradeCount = upgradeCount;
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

