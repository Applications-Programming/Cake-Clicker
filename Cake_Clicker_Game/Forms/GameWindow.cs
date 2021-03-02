﻿using System;
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

            //Mask the Achievement descriptions
            Achievement_One_Description.Text = "????????????????";
            Achievement_Two_Description.Text = "????????????????";
            Achievement_Three_Description.Text = "????????????????";
            Achievement_Four_Description.Text = "????????????????";
        }

        /// <summary>
        /// Updates the score
        /// </summary>
        /// <param name="score">The new score</param>
        public void UpdateScore()
        {
            int score = _userInterfaceManager.GetGame().GetAmountOfCake();
            scoreLabel.Text = score + " Cake";
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
            CheckAchievements();
            //addPointsTimer.Interval = 1000;
            //addPointsTimer.Start();
        }

        private void Shrink(object sender, MouseEventArgs e)
        {
            cakeButton.Size = new Size(500, 500);
            cakeButton.Location = new Point(cakeButton.Location.X + 6, cakeButton.Location.Y + 6);
        }

        private void Grow(object sender, MouseEventArgs e)
        {
            cakeButton.Size = new Size(512, 512);
            cakeButton.Location = new Point(cakeButton.Location.X - 6, cakeButton.Location.Y - 6);
        }

        //Timer for adding points to the game
        private void AddPointsTimer_Tick(object sender, EventArgs e)
        {
        }

        private void optionsButton_Click(object sender, EventArgs e)
        {
            _userInterfaceManager.OpenOptions();
        }

        #region AddCakeTypeButtons
        private void addVanillaCakeButton_Click(object sender, EventArgs e)
        {
            _userInterfaceManager.AddCake(Game.CakeType.Vanilla);
            CheckAchievements();
        }

        private void addChocolateCakeButton_Click(object sender, EventArgs e)
        {
            _userInterfaceManager.AddCake(Game.CakeType.Chocolate);
            CheckAchievements();
        }

        private void addStrawberryCakeButton_Click(object sender, EventArgs e)
        {
            _userInterfaceManager.AddCake(Game.CakeType.Strawberry);
            CheckAchievements();
        }

        private void addCoffeeCakeButton_Click(object sender, EventArgs e)
        {
            _userInterfaceManager.AddCake(Game.CakeType.Coffee);
            CheckAchievements();
        }

        private void addRedVelvetCakeButton_Click(object sender, EventArgs e)
        {
            _userInterfaceManager.AddCake(Game.CakeType.Red_Velvet);
            CheckAchievements();
        }

        private void addCarrotCakeButton_Click(object sender, EventArgs e)
        {
            _userInterfaceManager.AddCake(Game.CakeType.Carrot);
            CheckAchievements();
        }

        private void addCheeseCakeButton_Click(object sender, EventArgs e)
        {
            _userInterfaceManager.AddCake(Game.CakeType.Cheese);
            CheckAchievements();
        }

        #endregion

        private void SaveAndQuitButton_Click(object sender, EventArgs e)
        {
            _userInterfaceManager.Save();
            Application.Exit();
        }

        //This method is called when an achievement has the potential of being unlocked
        //For example, when the user buys an upgrade or clicks to get more cake
        private void CheckAchievements() 
        {
            //Calls game class method to get the array of achievement status's
            bool[] values = _userInterfaceManager.CheckAcheivements();

            //If an achievement is true then it makes the achievement known to the user
            if (values[0] == true) 
            {
                Achievement_One_Groupbox.Text = "Cake Novice";
                Achievement_One_Description.Text = "Reached 100 Cakes!";
                Achievement_One_Description.ForeColor = Color.Gold;
                Achievement_One_Question_Mark.Visible = false;
                Achievement_One_Star.Visible = true;
            } 
            if (values[1] == true)
            {
                Achievement_Two_Groupbox.Text = "Cake Master";
                Achievement_Two_Description.Text = "Reached 1000 Cakes!";
                Achievement_Two_Description.ForeColor = Color.Gold;
                Achievement_Two_Question_Mark.Visible = false;
                Achievement_Two_Star.Visible = true;
            }
            if (values[2] == true)
            {
                Achievement_Three_Groupbox.Text = "Bakery Legend";
                Achievement_Three_Description.Text = "Reached 10000 Cakes!";
                Achievement_Three_Description.ForeColor = Color.Gold;
                Achievement_Three_Question_Mark.Visible = false;
                Achievement_Three_Star.Visible = true;
            }
            if (values[3] == true)
            {
                Achievement_Four_Groupbox.Text = "Recipe Book";
                Achievement_Four_Description.Text = "Unlocked all upgrades!";
                Achievement_Four_Description.ForeColor = Color.Gold;
                Achievement_Four_Question_Mark.Visible = false;
                Achievement_Four_Star.Visible = true;
            }
        }

    }
}
