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
    public partial class Analytics : Form
    {

        private UserInterfaceManager _userInterfaceManager;
        public Analytics()
        {
            InitializeComponent();
            _userInterfaceManager = CakeClicker.GetUserInterfaceManager();

            //Profile name and UUID
            profileLabel.Text = "Profile: " + _userInterfaceManager.GetGame().GetPlayerName();
            uuidLabel.Text = "Profile UUID: " + _userInterfaceManager.GetGame().GetPlayerId();

            //Autoclicker detection status
            if (_userInterfaceManager.AutoclickerDetectionStatus()){
                cheatLabel.Text = "Autoclicker detected: True";
            }
            else
            {
                cheatLabel.Text = "Autoclicker detected: False";
            }

            //Offline mode status
            if (_userInterfaceManager.GetGame()._offlineMode == false)
            {
                uuidLabel.Text = "Profile UUID: " + _userInterfaceManager.GetGame().GetPlayerId() + " (due to offline mode)";
                offlineModeLabel.Text = "Database Mode: Offline";
            } else
            {
                uuidLabel.Text = "Profile UUID: " + _userInterfaceManager.GetGame().GetPlayerId();
                offlineModeLabel.Text = "Database Mode: Online";
            }

            //Progress bars
            generateMaxCPSBar();
            generateAverageCPSBar();
        }

        //loads the Max CPS bar
        public void generateMaxCPSBar()
        {
            int maxCPS = _userInterfaceManager.MaxCPSDetected();
            maxCPSLabel.Text = "Max CPS Reached (" + maxCPS + "):";

            if (maxCPS < 7) {
                maxCPSBar.BackColor = Color.DarkGreen;
            } else if (maxCPS < 16) {
                maxCPSBar.BackColor = Color.Yellow;
            } else {
                maxCPSBar.BackColor = Color.DarkRed;
            }

            //Progress bar doesn't break if someone has an insane autoclicker lol
            if(maxCPS > 30)
            {
                maxCPS = 30;
            }

            //Shifts the int to a double
            double maxCPSCast = maxCPS * 1.0;

            //Progress bar range is (0,100)
            maxCPSBar.Value = Convert.ToInt32((maxCPSCast/30.0)*100);
        }

        //loads the Average CPS bar
        public void generateAverageCPSBar()
        {
            double averageCPS = _userInterfaceManager.AverageCPSDetected();
            averageCPSLabel.Text = "Average CPS (" + averageCPS + "):";

            if (averageCPS < 7)
            {
                averageCPSBar.ForeColor = Color.DarkGreen;
            }
            else if (averageCPS < 16)
            {
                averageCPSBar.ForeColor = Color.Yellow;
            }
            else
            {
                averageCPSBar.ForeColor = Color.DarkRed;
            }

            //Progress bar doesn't break if someone has an insane autoclicker lol
            if (averageCPS > 30)
            {
                averageCPS = 30;
            }

            //Shifts the int to a double
            double averageCPSCast = averageCPS * 1.0;

            //Progress bar range is (0,100)
            averageCPSBar.Value = Convert.ToInt32((averageCPSCast / 30.0) * 100);
        }

        private void closeTabButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
