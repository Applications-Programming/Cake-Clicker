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
    public partial class GameWindow : Form
    {
        int _score;
        public GameWindow()
        {
            InitializeComponent();

            _score = 0;
            scoreLabel.Text = "0";
            refreshTimer.Interval = 100;
            refreshTimer.Start();
        }

        private void cakeButton_Click(object sender, EventArgs e)
        {
            _score++;
            scoreLabel.Text = _score.ToString();
            addPointsTimer.Interval = 1000;
            addPointsTimer.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void upgradeButtonGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void upgrade1Button_Click(object sender, EventArgs e)
        {

        }

        private void upgrade2Button_Click(object sender, EventArgs e)
        {

        }

        private void upgrade3Button_Click(object sender, EventArgs e)
        {

        }

        private void upgrade4Button_Click(object sender, EventArgs e)
        {
            
        }

        //Timer for adding points to the game
        private void AddPointsTimer_Tick(object sender, EventArgs e)
        {
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            //scoreLabel.Text = _score.ToString();
        }
    }
}
