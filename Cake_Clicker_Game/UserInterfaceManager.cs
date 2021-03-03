﻿using System.Windows.Forms;

namespace Cake_Clicker_Game
{
    class UserInterfaceManager
    {
        #region Fields

        Game _game;

        //Cached Windows
        MainMenu _mainMenu;
        GameWindow _gameWindow;
        Forms.Options _options;



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
            _gameWindow.BackColor = System.Drawing.Color.Gray;


            _options = new Forms.Options();

        }

        //Create InitializeGameFromSaveFile

        /// <summary>
        /// Saves the game to a file
        /// </summary>
        public void Save()
        {
            if (!_game._offlineMode)
                _game.SaveGameToCloud();
            else
                _game.SaveGameToFile();
        }

        //Loads the game using the name or UUID of the profile being passed in by the parameter
        //If load is successful then it will return true, otherwise it will return false
        public bool loadGame(string id)
        {
            int _id;
            if (int.TryParse(id, out _id))
            {
                bool ret = _game.LoadFromCloud(_id);
                _gameWindow.UpdateGameInfo();
                return ret;
            }
            else
            {
                SendUserMessage("ID format invalid. (Make sure its just a number)");
                return false;
            }
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
            if(!_options.Visible)
                _options.Show();
        }

        //Gets the bool array of achievement status from the game class
        public bool[] CheckAcheivements() 
        {
            return _game.GetAchivements();
        }

        /// <summary>
        /// Runs whenever the cake button is clicked
        /// </summary>
        public void OnCakeClick()
        {
            AddToScore();
        }

        //Force updates cake score
        public void RefreshScore() 
        {
            _gameWindow.UpdateScore();
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

        //Manually adds cookies to game
        public void AddCakeManuallyToGame(int amount) 
        {
            _game.AddCakeManually(amount);
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
