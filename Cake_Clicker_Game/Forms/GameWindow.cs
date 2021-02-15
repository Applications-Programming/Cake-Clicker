using System;
using System.Windows.Forms;

namespace Cake_Clicker_Game
{
    public partial class GameWindow : Form
    {

        //cached Objects
        UserInterfaceManager _userInterfaceManager;

        public GameWindow(string playerName)
        {
            InitializeComponent();
            _userInterfaceManager = CakeClicker.GetUserInterfaceManager();
            cakeLabel.Text = playerName + "'s Cake";
            //refreshTimer.Interval = 100;
            //refreshTimer.Start();
        }

        public void UpdateScore(int score)
        {
            scoreLabel.Text = score.ToString();
        }

        public Button GetCakeButton() { return cakeButton; }

        private void cakeButton_Click(object sender, EventArgs e)
        {
           _userInterfaceManager.OnCakeClick();
            addPointsTimer.Interval = 1000;
            addPointsTimer.Start();
        }

        private void upgrade1Button_Click(object sender, EventArgs e)
        {
            _userInterfaceManager.SendUserMessage("Unimplemented Control: Please wait for future update");
        }

        private void upgrade2Button_Click(object sender, EventArgs e)
        {
            _userInterfaceManager.SendUserMessage("Unimplemented Control: Please wait for future update");
        }

        private void upgrade3Button_Click(object sender, EventArgs e)
        {
            _userInterfaceManager.SendUserMessage("Unimplemented Control: Please wait for future update");
        }

        private void upgrade4Button_Click(object sender, EventArgs e)
        {
            _userInterfaceManager.SendUserMessage("Unimplemented Control: Please wait for future update");
        }

        //Timer for adding points to the game
        private void AddPointsTimer_Tick(object sender, EventArgs e)
        {
        }

    }
}
