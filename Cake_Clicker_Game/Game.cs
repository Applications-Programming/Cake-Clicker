//Game Class which is the backend for the Cake Clicker Game
//Created by Tyler, Yarra, Noah and Keagan
//Authored: 2/9/2021
using System;

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
		//_amountOfCake += (_cakePerClick * _multiplierOnCakeClick);
    }

	//This method returns the amount of cake stored in _amountOfCake
	public int GetAmountOfCake()
	{
		return _amountOfCake;
	}

	//This method increments the multiplier to the next tier
	public void IncrementMultiplier() 
	{ 

	}

	//This method returns the current multiplier as a double
	public double GetMultiplier()
	{
		return _multiplierOnCakeClick;
	}

	//This is a ToString override which returns the name of the game
	/**Modified to allow compilation 
	 * OLD: public String overrise ToString()**/
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
	/**Modified to allow compilation 
	* OLD: missing return statement**/
	public bool SaveGameToFile() 
	{
		return false;
	}
	
	//This changes the current cake type stored in _currentCakeTier
	public void ChangeCakeType()
	{

	}

	//This method returns the current CakeType stored in _currentCakeTier
	public CakeType AccessCakeType() 
	{
		return _currentCakeTier;
	}
}
