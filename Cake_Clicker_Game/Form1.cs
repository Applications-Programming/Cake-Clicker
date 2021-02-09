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
    public partial class Form1 : Form
    {
        int _score;
        public Form1()
        {
            InitializeComponent();

            _score = 0;
            scoreLabel.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _score++;
            scoreLabel.Text = _score.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
