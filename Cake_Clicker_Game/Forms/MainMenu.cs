using System;
using System.Windows.Forms;

namespace Cake_Clicker_Game
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Text = "Loading...";
            this.Update();
            if (NameTextBox.Text.Length == 0)
            {
                CakeClicker.GetUserInterfaceManager().IntitializeGame("Alex", 0);
            }
            else
            {
                //Prevents excessively user input
                if (NameTextBox.Text.Length < 15)
                {
                    CakeClicker.GetUserInterfaceManager().IntitializeGame(NameTextBox.Text, 0);

                }
                else
                {
                    CakeClicker.GetUserInterfaceManager().IntitializeGame("Alex", 0);
                }

            }

            Hide();
            CakeClicker.GetUserInterfaceManager().OpenNewWindow(CakeClicker.GetUserInterfaceManager().GetGameWindow());
            this.Dispose();

        }

        //Adds functionality to begin the game by hitting enter in the name box
        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                startButton.Text = "Loading...";
                this.Update();
                if (NameTextBox.Text.Length == 0)
                {
                    CakeClicker.GetUserInterfaceManager().IntitializeGame("Johny", 0);
                }
                else
                {
                    //Prevents excessively user input
                    if (NameTextBox.Text.Length < 15)
                    {
                        CakeClicker.GetUserInterfaceManager().IntitializeGame(NameTextBox.Text, 0);

                    }
                    else
                    {
                        CakeClicker.GetUserInterfaceManager().IntitializeGame("Johny", 0);
                    }

                }

                Hide();
                CakeClicker.GetUserInterfaceManager().OpenNewWindow(CakeClicker.GetUserInterfaceManager().GetGameWindow());
                this.Dispose();
            }
        }

        private void MasterMode_Click(object sender, EventArgs e)
        {
            masterModeStartButton.Text = "Loading...";
            this.Update();
            if (NameTextBox.Text.Length == 0)
            {
                CakeClicker.GetUserInterfaceManager().IntitializeGame("Alex", 1);
            }
            else
            {
                //Prevents excessively user input
                if (NameTextBox.Text.Length < 15)
                {
                    CakeClicker.GetUserInterfaceManager().IntitializeGame(NameTextBox.Text, 1);

                }
                else
                {
                    CakeClicker.GetUserInterfaceManager().IntitializeGame("Alex", 1);
                }

            }

            Hide();
            CakeClicker.GetUserInterfaceManager().OpenNewWindow(CakeClicker.GetUserInterfaceManager().GetGameWindow());
            this.Dispose();
        }
    }
}
