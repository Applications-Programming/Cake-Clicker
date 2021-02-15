using System;
using System.Windows.Forms;

namespace Cake_Clicker_Game
{
    static class CakeClicker
    {

        static UserInterfaceManager _userInterfaceManager;
        static Form _currWindow;

        static public UserInterfaceManager GetUserInterfaceManager() { return _userInterfaceManager; }
        static public Form GetCurrentWindow() { return _currWindow; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainMenu mainMenu = new MainMenu();
            _currWindow = mainMenu;
            _userInterfaceManager = new UserInterfaceManager(mainMenu);
            Application.Run(mainMenu);
        }
    }
}
