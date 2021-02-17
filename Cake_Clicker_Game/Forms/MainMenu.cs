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
            if (NameTextBox.Text.Length == 0)
            {
                CakeClicker.GetUserInterfaceManager().SendUserMessage("Please enter you name.");
                return;
            }
            else
            {
                CakeClicker.GetUserInterfaceManager().IntitializeGame(NameTextBox.Text);
                Hide();
                CakeClicker.GetUserInterfaceManager().OpenNewWindow(CakeClicker.GetUserInterfaceManager().GetGameWindow());
                this.Dispose();
            }

        }
    }
}
