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
            this.Hide();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            _userInterfaceManager.Save();
            UUID_Label.Text = "ID:" + _userInterfaceManager.GetGame().GetPlayerId().ToString();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            _userInterfaceManager.Reset();
        }

        private void addCookies_Click(object sender, EventArgs e)
        {
            //Checks to make sure excessively large values aren't being put in to prevent overflow issues
            if (addCookieUserInput.Text.Length > 0 && addCookieUserInput.Text.Length < 10)
            {
                string text = addCookieUserInput.Text;
                int cake = 0;
                bool validInput = Int32.TryParse(text, out cake);

                //If the input is valid then it will add the cake otherwise it will give an error to the user
                if (validInput) {
                    cake = int.Parse(text);
                    _userInterfaceManager.AddCakeManuallyToGame(cake);
                    _userInterfaceManager.RefreshScore();
                } else {
                    Console.WriteLine("Error: invalid amount of cake added or invalid user input" + "\n");
                    MessageBox.Show("Couldn't add cake, make sure input is valid.");
                }
            }
            else 
            {
                MessageBox.Show("Unable to add that much cake, sorry!");
            }
           
        }

        private void addCookieUserInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') {
                //Checks to make sure excessively large values aren't being put in to prevent overflow issues
                if (addCookieUserInput.Text.Length > 0 && addCookieUserInput.Text.Length < 10)
                {
                    string text = addCookieUserInput.Text;
                    int cake = 0;
                    bool validInput = Int32.TryParse(text, out cake);

                    //If the input is valid then it will add the cake otherwise it will give an error to the user
                    if (validInput)
                    {
                        cake = int.Parse(text);
                        _userInterfaceManager.AddCakeManuallyToGame(cake);
                        _userInterfaceManager.RefreshScore();
                    }
                    else
                    {
                        Console.WriteLine("Error: invalid amount of cake added or invalid user input" + "\n");
                        MessageBox.Show("Couldn't add cake, make sure input is valid.");
                    }
                }
                else
                {
                    MessageBox.Show("Unable to add that much cake, sorry!");
                }
            }
        }


        private void loadGameUserInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                LoadGame();
            }
        }

        private void loadGameButton_Click(object sender, EventArgs e)
        {
            LoadGame();
        }

        private void LoadGame()
        {
            //Checks to make sure username is valid length
            if (loadGameUserInput.Text.Length < 15 && loadGameUserInput.Text.Length > 0)
            {
                if (!_userInterfaceManager.loadGame(loadGameUserInput.Text))
                {
                    MessageBox.Show("Invalid Name/UUID");
                    loadGameUserInput.Text = "";
                    UUID_Label.Text = "ID:" + _userInterfaceManager.GetGame().GetPlayerId().ToString();
                }
            }
            else
            {
                MessageBox.Show("Invalid Name/UUID");
                loadGameUserInput.Text = "";
                UUID_Label.Text = "";
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
