using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cake_Clicker_Game.Forms
{
    public partial class Options : Form
    {

        //cached Objects
        UserInterfaceManager _userInterfaceManager;

        public Options()
        {
            InitializeComponent();
            AutoSetLocation();
            _userInterfaceManager = CakeClicker.GetUserInterfaceManager();
        }

        private void AutoSetLocation()
        {
            Form currWindow = CakeClicker.GetCurrentWindow();
            Point Center = new Point(currWindow.DesktopLocation.X + (currWindow.Size.Width / 2), currWindow.DesktopLocation.Y + (currWindow.Size.Height / 2));
            Point newLocation = new Point(Center.X - (this.Size.Width / 2), Center.Y - (this.Size.Height / 2));
            this.DesktopLocation = newLocation;
        }



        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lightmodeButton_CheckedChanged(object sender, EventArgs e)
        {
            _userInterfaceManager.GetGameWindow().BackColor = Color.LightGray;
        }

        private void darkmodeButton_CheckedChanged(object sender, EventArgs e)
        {
            _userInterfaceManager.GetGameWindow().BackColor = Color.Black;
        }

        private void greymodeButton_CheckedChanged(object sender, EventArgs e)
        {
            _userInterfaceManager.GetGameWindow().BackColor = Color.Gray;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            _userInterfaceManager.Save();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            _userInterfaceManager.Reset();
        }
    }
}
