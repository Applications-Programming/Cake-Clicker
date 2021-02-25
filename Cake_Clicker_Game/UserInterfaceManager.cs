﻿using System.Drawing;
using System.Windows.Forms;

namespace Cake_Clicker_Game
{
    class UserInterfaceManager
    {
        #region Fields

        Game _game;

        //Cached Windows
        MainMenu _mainMenu;
        GameWindow _gameWindow;


        #endregion


        #region Methods

        /// <summary>
        /// Initializes the game startpoint. 
        /// </summary>
        /// <param name="playerName"></param>
        public void IntitializeGame(string playerName)
        {
            _game = new Game();
            _game.SetPlayerName(playerName);

            _gameWindow = new GameWindow(playerName);
            _gameWindow.UpdateScore();
            _gameWindow.UpdateCakeCounts();

        }

        //Create InitializeGameFromSaveFile

        /// <summary>
        /// Saves the game to a file
        /// </summary>
        public void Save()
        {
            _game.SaveGameToFile();
        }

        /// <summary>
        /// Creates a message window and displays it to the user
        /// </summary>
        /// <param name="message">The message to be displayed</param>
        public void SendUserMessage(string message)
        {
            MessageWindow messageWindow = new MessageWindow(message);
            messageWindow.ShowDialog();

        }

        /// <summary>
        /// Opens the options menu
        /// </summary>
        public void OpenOptions()
        {
            Forms.Options options = new Forms.Options();
            options.ShowDialog();
        }

        /// <summary>
        /// Runs whenever the cake button is clicked
        /// </summary>
        public void OnCakeClick()
        {
            AddToScore();
        }

        public void AddCake(Game.CakeType type)
        {
            _game.AddCakeUpgrade(type);
            _gameWindow.UpdateCakeCounts();
            _gameWindow.UpdateScore();
        }

        public void Reset()
        {
            _game.ResetGame();
            _gameWindow.UpdateCakeCounts();
            _gameWindow.UpdateScore();
        }

        /// <summary>
        /// Adds the default value to the score 
        /// </summary>
        public void AddToScore()
        {
            _game.AddCake();
            _gameWindow.UpdateScore();
        }

        //Create AddSpecificScore function

        /// <summary>
        /// Opens a new window
        /// </summary>
        /// <param name="newWindow"></param>
        public void OpenNewWindow(Form newWindow)
        {
            newWindow.ShowDialog();
            CakeClicker.SetCurrentWindow(newWindow);
        }

        //Getter and setters
        public GameWindow GetGameWindow() { return _gameWindow; }
        public Game GetGame() { return _game; }
        public MainMenu GetMainMenu()
        {
            if (_mainMenu == null)
            {
                _mainMenu = new MainMenu();
            }
            return _mainMenu;
        }

        #endregion

    }


}
