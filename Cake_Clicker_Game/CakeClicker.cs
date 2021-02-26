using System;
using System.Windows.Forms;

namespace Cake_Clicker_Game
{
    static class CakeClicker
    {

        static UserInterfaceManager _userInterfaceManager;
        static DatabaseManager _databaseManager;
        static Form _currWindow;

        static string _dataSource = "cake-clicker-server.database.windows.net";
        static string _database = "CakeClicker";
        static string _userId = "DefaultUser";
        static string _password = "CakeClicker123";


        static public UserInterfaceManager GetUserInterfaceManager() { return _userInterfaceManager; }

        static public DatabaseManager GetDatabaseManager() { return _databaseManager; }
        static public Form GetCurrentWindow() { return _currWindow; }
        static public void SetCurrentWindow(Form currWindow)
        {
            if (currWindow == null)
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
            _databaseManager = DatabaseManager.CreateDatabaseManager(_dataSource, _database, _userId, _password);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            _userInterfaceManager = new UserInterfaceManager();
            _currWindow = _userInterfaceManager.GetMainMenu();
            Application.Run(_currWindow);
        }
    }
}
