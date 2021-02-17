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
        static public void SetCurrentWindow(Form currWindow)
        {
            if(currWindow == null)
            {
                return;
            }
            _currWindow = currWindow;
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            _userInterfaceManager = new UserInterfaceManager();
            _currWindow = _userInterfaceManager.GetMainMenu();
            Application.Run(_currWindow);
        }
    }
}
