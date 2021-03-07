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
    public partial class Achievements : Form
    {
        //cached Objects
        UserInterfaceManager _userInterfaceManager;

        public Achievements()
        {
            InitializeComponent();
            _userInterfaceManager = CakeClicker.GetUserInterfaceManager();

            //Mask the Achievement descriptions
            Achievement_One_Description.Text = "????????????????";
            Achievement_Two_Description.Text = "????????????????";
            Achievement_Three_Description.Text = "????????????????";
            Achievement_Four_Description.Text = "????????????????";

            CheckAchievements();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CheckAchievements()
        {
            //Calls game class method to get the array of achievement status's
            bool[] values = _userInterfaceManager.CheckAchievements();
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
