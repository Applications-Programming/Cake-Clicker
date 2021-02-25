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
                CakeClicker.GetUserInterfaceManager().IntitializeGame("Johny");
            }
            else
            {
                //Prevents excessively user input
                if (NameTextBox.Text.Length < 15)
                {
                    CakeClicker.GetUserInterfaceManager().IntitializeGame(NameTextBox.Text);

                } else {
                    CakeClicker.GetUserInterfaceManager().IntitializeGame("Johny");
                }

            }

            Hide();
            CakeClicker.GetUserInterfaceManager().OpenNewWindow(CakeClicker.GetUserInterfaceManager().GetGameWindow());
            this.Dispose();

        }
    }
}
