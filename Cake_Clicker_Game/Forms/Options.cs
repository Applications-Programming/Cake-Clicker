using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
