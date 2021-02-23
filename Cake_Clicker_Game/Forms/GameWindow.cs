using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cake_Clicker_Game
{
    public partial class GameWindow : Form
    {

        Image[] images = new Image[7];

        //cached Objects
        UserInterfaceManager _userInterfaceManager;

        public GameWindow(string playerName)
        {
            InitializeComponent();
            _userInterfaceManager = CakeClicker.GetUserInterfaceManager();
            cakeLabel.Text = playerName + "'s Bakery";
            //refreshTimer.Interval = 100;
            //refreshTimer.Start();
            cakeButton.MouseDown += new MouseEventHandler(Shrink);
            cakeButton.MouseUp += new MouseEventHandler(Grow);
        }

        /// <summary>
        /// Updates the score
        /// </summary>
        /// <param name="score">The new score</param>
        public void UpdateScore(int score)
        {
            scoreLabel.Text = score.ToString();
        }

        public void UpdateCakeCounts()
        {
            int[] cakeCounts = _userInterfaceManager.GetGame().GetUpgradeCount();

            vanillaCakeInfoBox.Text = "Count: " + cakeCounts[0].ToString();
            ChocolateCakeInfoBox.Text = "Count: " + cakeCounts[1].ToString();
            strawberryCakeInfoBox.Text = "Count: " + cakeCounts[2].ToString();
            CoffeeCakeInfoBox.Text = "Count: " + cakeCounts[3].ToString();
            redVelvetCakeInfoBox.Text = "Count: " + cakeCounts[4].ToString();
            carrotCakeInfoBox.Text = "Count: " + cakeCounts[5].ToString();
            cheeseCakeInfoBox.Text = "Count: " + cakeCounts[6].ToString();

        }

        public Button GetCakeButton() { return cakeButton; }
        private void cakeButton_Click(object sender, EventArgs e)
        {
            _userInterfaceManager.OnCakeClick();
            //addPointsTimer.Interval = 1000;
            //addPointsTimer.Start();
        }

        private void Shrink(object sender, MouseEventArgs e)
        {
            cakeButton.Size = new System.Drawing.Size(500, 500);
            cakeButton.Location = new System.Drawing.Point(488, 127);
        }

        private void Grow(object sender, MouseEventArgs e)
        {
            cakeButton.Size = new System.Drawing.Size(512, 512);
            cakeButton.Location = new System.Drawing.Point(488, 127);
        }

        //Timer for adding points to the game
        private void AddPointsTimer_Tick(object sender, EventArgs e)
        {
        }

        private void optionsButton_Click(object sender, EventArgs e)
        {

        }

        #region AddCakeTypeButtons
        private void addVanillaCakeButton_Click(object sender, EventArgs e)
        {
            _userInterfaceManager.AddCake(Game.CakeType.Vanilla);
        }

        private void addChocolateCakeButton_Click(object sender, EventArgs e)
        {
            _userInterfaceManager.AddCake(Game.CakeType.Chocolate);
        }

        private void addStrawberryCakeButton_Click(object sender, EventArgs e)
        {
            _userInterfaceManager.AddCake(Game.CakeType.Strawberry);
        }

        private void addCoffeeCakeButton_Click(object sender, EventArgs e)
        {
            _userInterfaceManager.AddCake(Game.CakeType.Coffee);

        }

        private void addRedVelvetCakeButton_Click(object sender, EventArgs e)
        {
            _userInterfaceManager.AddCake(Game.CakeType.Red_Velvet);

        }

        private void addCarrotCakeButton_Click(object sender, EventArgs e)
        {
            _userInterfaceManager.AddCake(Game.CakeType.Carrot);

        }

        private void addCheeseCakeButton_Click(object sender, EventArgs e)
        {
            _userInterfaceManager.AddCake(Game.CakeType.Cheese);

        }

        #endregion

        private void SaveAndQuitButton_Click(object sender, EventArgs e)
        {
            _userInterfaceManager.GetGame().SaveGameToFile();
            Application.Exit();
        }


    }
}
