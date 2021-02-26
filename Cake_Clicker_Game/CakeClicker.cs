using System;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Cake_Clicker_Game
{
    static class CakeClicker
    {

        static UserInterfaceManager _userInterfaceManager;
        static Form _currWindow;

        static string _logName = "Log";


        static public UserInterfaceManager GetUserInterfaceManager() { return _userInterfaceManager; }

        static public Form GetCurrentWindow() { return _currWindow; }
        static public void SetCurrentWindow(Form currWindow)
        {
            if (currWindow == null)
            {
                return;
            }
            _currWindow = currWindow;
        }

        static void SetupLog()
        {
            FileStream file = new FileStream(_logName + ".txt", FileMode.Create);
            StreamWriter streamWriter = new StreamWriter(file);
            Console.SetOut(streamWriter);
            DateTime now = DateTime.Now;
            Console.WriteLine("CakeClicker - Log:" + now.ToString());
        }

        public static void EndApplication()
        {
            Console.Out.Close();
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SetupLog();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            _userInterfaceManager = new UserInterfaceManager();
            _currWindow = _userInterfaceManager.GetMainMenu();
            Application.Run(_currWindow);

            EndApplication();
        }
    }
}
