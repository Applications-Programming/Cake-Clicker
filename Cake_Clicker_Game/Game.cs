using System;


//Please don't touch to avoid corruption issues
//Code will be contained to Cake branch 
public class Game
{
	//Fields
	private String _playerName;
	private int _amountOfCake;
	private int _cakePerClick;
	private double _multiplierOnCakeClick;

	//Enums
	private enum CakeType 
	{ 
		Vanilla = 0, Chochlate = 1, Strawberry = 2, Coffee = 3, Red_Velvet = 4, Carrot = 5, Cheese = 5
	}

	//Constructor
	public Game()
	{
	}

	//Methods
	public void AddCake()
    {

    }

	public int GetAmountOfCake()
	{

	}

	public void IncrementMultiplier() 
	{ 

	}

	public double GetMultiplier()
	{

	}

	//This is a ToString override which returns the name of the game
	public String override ToString()
    {
		return "Cake Clicker";
    }

	public void ResetGame()
    {

    }

	public bool SaveGameToFile() 
	{ 

	}

	public double GetMultiplier() 
	{ 

	}


	public void ChangeCakeType()
	{

	}

	CakeType AccessCakeType() 
	{ 
	
	}
}
