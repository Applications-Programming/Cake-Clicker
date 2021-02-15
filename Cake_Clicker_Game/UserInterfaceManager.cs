using System;
using System.Windows.Forms;

namespace Cake_Clicker_Game
{
    class UserInterfaceManager
    {

        MainMenu _mainMenu;
        GameWindow _gameWindow;
        Game _game;
        Game.CakeType _cakeType;

        public UserInterfaceManager(MainMenu mainMenu)
        {
            _mainMenu = mainMenu;
        }

        public GameWindow GetGameWindow() { return _gameWindow; }
        public Game GetGame() { return _game; }

        public void IntitializeGame(string playerName)
        {
            _game = new Game();
            _game.SetPlayerName(playerName);
            _cakeType = _game.AccessCakeType();

            _gameWindow = new GameWindow(playerName);
            _gameWindow.UpdateScore(_game.GetAmountOfCake());
        }

        public void SaveAndClose()
        {
            _game.SaveGameToFile();
        }

        public void SendUserMessage(string message)
        {
            MessageWindow messageWindow = new MessageWindow(message);
            messageWindow.ShowDialog();
            
        }

        public void OnCakeClick()
        {
            _game.ChangeCakeType();
            if(_cakeType != _game.AccessCakeType())
            {
                _cakeType = _game.AccessCakeType();
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

        public void AddToScore()
        {
            _game.AddCake();
            _gameWindow.UpdateScore(_game.GetAmountOfCake());
        }


        public void ChangeWindows(Form oldWindow, Form newWindow)
        {
            oldWindow.Hide();
            newWindow.ShowDialog();
        }

    }
}
