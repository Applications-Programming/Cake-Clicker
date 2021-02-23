using System.Windows.Forms;

namespace Cake_Clicker_Game
{
    class UserInterfaceManager
    {
        #region Fields

        Game _game;
        Game.CakeType _cakeType;

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
            _cakeType = _game.AccessCakeType();

            _gameWindow = new GameWindow(playerName);
            _gameWindow.UpdateScore(_game.GetAmountOfCake());
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
        /// Runs whenever the cake button is clicked
        /// </summary>
        public void OnCakeClick()
        {
            _game.ChangeCakeType();
            if (_cakeType != _game.AccessCakeType())
            {
                _cakeType = _game.AccessCakeType();
                //_gameWindow.GetNewCake().Visible = true;
                switch (_cakeType)
                {
                    case 0:
                        _gameWindow.GetCakeButton().Image = global::Cake_Clicker_Game.Properties.Resources.Vanilla_Cake;
                        break;
                    case (Game.CakeType)1:
                        _gameWindow.GetCakeButton().Image = global::Cake_Clicker_Game.Properties.Resources.Chocolate_Cake;
                        break;
                    case (Game.CakeType)2:
                        _gameWindow.GetCakeButton().Image = global::Cake_Clicker_Game.Properties.Resources.Strawberry_Cake;
                        break;
                    case (Game.CakeType)3:
                        //_gameWindow.GetCakeButton().Image = global::Cake_Clicker_Game.Properties.Resources.Coffee_Cake;
                        _gameWindow.GetCakeButton().Image = global::Cake_Clicker_Game.Properties.Resources.Vanilla_Cake;
                        break;
                    case (Game.CakeType)4:
                        _gameWindow.GetCakeButton().Image = global::Cake_Clicker_Game.Properties.Resources.Red_Velvet_Cake;
                        break;
                    case (Game.CakeType)5:
                        _gameWindow.GetCakeButton().Image = global::Cake_Clicker_Game.Properties.Resources.Carrot_Cake;
                        break;
                    case (Game.CakeType)6:
                        _gameWindow.GetCakeButton().Image = global::Cake_Clicker_Game.Properties.Resources.Cheese_Cake;
                        break;
                }
            }
            AddToScore();
        }

        /// <summary>
        /// Adds the default value to the score 
        /// </summary>
        public void AddToScore()
        {
            _game.AddCake();
            _gameWindow.UpdateScore(_game.GetAmountOfCake());
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
