using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake_Clicker_Game
{
    class UserInterfaceManager
    {
        GameWindow _gameWindow;

        UserInterfaceManager(GameWindow gameWindow)
        {
            _gameWindow = gameWindow;
        }

        public void SendUserMessage(string message)
        {
            MessageWindow messageWindow = new MessageWindow(_gameWindow, message);
            messageWindow.ShowDialog();
        }

    }
}
