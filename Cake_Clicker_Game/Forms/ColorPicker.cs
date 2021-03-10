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
    public partial class ColorPicker: Form
    {
        //cached Objects
        UserInterfaceManager _userInterfaceManager;

        public ColorPicker()
        {
            InitializeComponent();
            _userInterfaceManager = CakeClicker.GetUserInterfaceManager();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            int r = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
            int g = Convert.ToInt32(Math.Round(numericUpDown2.Value, 0));
            int b = Convert.ToInt32(Math.Round(numericUpDown3.Value, 0));
            _userInterfaceManager.bgColor = Color.FromArgb(r, g, b);
            _userInterfaceManager.ChangeBG();
            this.Hide();
        }
    }
}
