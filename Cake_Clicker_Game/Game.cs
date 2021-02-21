//Game Class which is the backend for the Cake Clicker Game
//Created by Tyler, Yarra, Noah and Keagan
//Authored: 2/9/2021
using System;
using System.Diagnostics;
using System.IO;

public class Game
{
	///Class Fields
	private String _playerName;
	private int _amountOfCake;
	private int _cakePerClick;
	private double _multiplierOnCakeClick;
	private CakeType _currentCakeTier;

	///Enums
	public enum CakeType
	{
		Vanilla = 0, Chochlate = 1, Strawberry = 2, Coffee = 3, Red_Velvet = 4, Carrot = 5, Cheese = 6
	}

	///Constructor
	public Game()
	{
		_playerName = "null";
		_amountOfCake = 0;
		_cakePerClick = 1;
		_multiplierOnCakeClick = 1.0;
		_currentCakeTier = 0;
	}

	/// <summary>
	/// Game Methods
	/// </summary>

	//This method is for adding cake to the total amount of cake based on the values held in the cake multiplier and cakePerClick 
	public void AddCake()
	{
		_amountOfCake += (int)(_cakePerClick * _multiplierOnCakeClick);
	}

	public void AddCakeUpgrade(CakeType cake)
	{
		// FIXME:
		// Change bool AddCakeUpgrade to A AddCakeUpgrade(enum cake#) which adds the according cake and subtracts the cake amount.
		// Returns true if it was successful and false if the player doesn't have enough cake to make the purchase.

	}

	//This method returns the amount of cake stored in _amountOfCake
	public int GetAmountOfCake()
	{
		return _amountOfCake;
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
	}

	//This method does a simple save of the game settings to a text file
	public bool SaveGameToFile()
	{
		DateTime now = DateTime.Now;
		string text = _playerName + '\n' + _amountOfCake + '\n' + _cakePerClick + '\n' + _multiplierOnCakeClick + '\n' + _currentCakeTier + '\n' + now.ToString("F");
		string path = AppDomain.CurrentDomain.BaseDirectory + @"\CakeGameData.txt";

		File.WriteAllText(path, text);

		return true;
	}

	public bool LoadFile()
	{
		try
		{
			File.Exists("CakeGameData.txt");
			string[] text = System.IO.File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + @"\CakeGameData.txt");
			_playerName = text[0];
			_amountOfCake = text[1];
			_cakePerClick = text[2];
			_multiplierOnCakeClick = text[3];
			_currentCakeTier = text[4];

			return false;
		}
		catch (Exception e)
		{
			_playerName = "null";
			_amountOfCake = 0;
			_cakePerClick = 1;
			_multiplierOnCakeClick = 1.0;
			_currentCakeTier = 0;

			return true;
		}
	}

	//This changes the current cake type stored in _currentCakeTier
	public void ChangeCakeType()
	{
		if (_amountOfCake > 80000)
		{
			_currentCakeTier = CakeType.Cheese;
			_cakePerClick = 400;
		}
		else if (_amountOfCake <= 80000 && _amountOfCake > 20000)
		{
			_currentCakeTier = CakeType.Carrot;
			_cakePerClick = 250;
		}
		else if (_amountOfCake <= 20000 && _amountOfCake > 1000)
		{
			_currentCakeTier = CakeType.Red_Velvet;
			_cakePerClick = 150;
		}
		else if (_amountOfCake <= 1000 && _amountOfCake > 500)
		{
			_currentCakeTier = CakeType.Coffee;
			_cakePerClick = 50;
		}
		else if (_amountOfCake <= 500 && _amountOfCake > 250)
		{
			_currentCakeTier = CakeType.Strawberry;
			_cakePerClick = 25;
		}
		else if (_amountOfCake <= 250 && _amountOfCake > 50)
		{
			_currentCakeTier = CakeType.Chochlate;
			_cakePerClick = 10;
		}
		else
		{
			_currentCakeTier = CakeType.Vanilla;
			_cakePerClick = 5;
		}
	}

	//This method returns the current CakeType stored in _currentCakeTier
	public CakeType AccessCakeType()
	{
		return _currentCakeTier;
	}
}

public class Test
{
	static void Main(string[] args)
	{
		Console.WriteLine("Testing game clicks, multiplier, and caketype...");
		Game game = new Game();
		for (int i = 0; i < 100; i++)
		{
			game.AddCake();
			if (i % 20 == 0)
			{
				game.IncrementMultiplier();
			}
			game.ChangeCakeType();
			Console.WriteLine("CURRENT CAKE TYPE: " + game.AccessCakeType());
		}
		Console.WriteLine("Testing game ToString...");
		Console.WriteLine(game.ToString());

		Console.WriteLine("Testing Get Methods...");
		game.GetMultiplier();
		game.GetAmountOfCake();

		Console.WriteLine("Testing SaveGameToFile...");
		game.SaveGameToFile();
		try
		{
			File.Exists("CakeGameData.txt");
			Console.WriteLine("The File Exists IN THIS DIRECTORY");
		}
		catch
		{
			Console.WriteLine("The File Does NOT exist");
		}

		Console.WriteLine("Tetsing Game Rest...");
		game.ResetGame();
		if (game.AccessCakeType() == 0)
		{
			Console.WriteLine("All tests passed!");
		}

	}
}
