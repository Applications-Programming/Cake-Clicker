using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cake_Clicker_Game
{
    public partial class MessageWindow : Form
    {
        GameWindow _gameWindow;
        public MessageWindow(GameWindow form, string message)
        {
            InitializeComponent();
            _gameWindow = form;
            this.messageLabel.Text = message;
            AutoSetLocation();
        }


        private void AutoSetLocation()
        {
            Point Center = new Point(_gameWindow.Location.X + (_gameWindow.Size.Width / 2), _gameWindow.Location.Y + (_gameWindow.Size.Height / 2));
            Point newLocation = new Point(Center.X - (this.Size.Width / 2), Center.Y - (this.Size.Height / 2));
            this.Location = newLocation;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.DestroyHandle();
            //this.Dispose();
        }

    }
}
