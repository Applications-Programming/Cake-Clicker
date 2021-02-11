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
		Vanilla = 0, Chochlate = 1, Strawberry = 2, Coffee = 3, Red_Velvet = 4, Carrot = 5, Cheese = 5
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
		_amountOfCake += (_cakePerClick * _multiplierOnCakeClick);
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
		string text = _playerName + " " + _amountOfCake + " " + _cakePerClick + " " + _multiplierOnCakeClick + " " + _currentCakeTier;
		string path = AppDomain.CurrentDomain.BaseDirectory + @"c:\CakeGameData.txt";

		File.WriteAllText(path, text);

		return true;
	}

	//This changes the current cake type stored in _currentCakeTier
	public void ChangeCakeType()
	{
		if (_amountOfCake >= 20)
		{
			_currentCakeTier = CakeType.Chochlate;
		}
		else if (_amountOfCake >= 40)
		{
			_currentCakeTier = CakeType.Strawberry;
		}
		else if (_amountOfCake >= 60)
		{
			_currentCakeTier = CakeType.Coffee;
		}
		else if (_amountOfCake >= 80)
		{
			_currentCakeTier = CakeType.Red_Velvet;
		}
		else if (_amountOfCake >= 100)
		{
			_currentCakeTier = CakeType.Carrot;
		}
		else
		{
			_currentCakeTier = CakeType.Cheese;
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
