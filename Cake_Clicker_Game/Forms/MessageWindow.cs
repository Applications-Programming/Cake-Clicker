using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cake_Clicker_Game
{
    public partial class MessageWindow : Form
    {
        public MessageWindow(string message)
        {
            InitializeComponent();
            AutoSetLocation();
            this.messageLabel.Text = message;
            
        }

        /// <summary>
        /// Automatically calculates where the message window should be displayed
        /// </summary>
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

    }
}
