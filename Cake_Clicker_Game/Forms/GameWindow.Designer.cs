
using System;

namespace Cake_Clicker_Game
{
    partial class GameWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindow));
            this.scoreLabel = new System.Windows.Forms.Label();
            this.addPointsTimer = new System.Windows.Forms.Timer(this.components);
            this.cakeButton = new System.Windows.Forms.Button();
            this.cakeLabel = new System.Windows.Forms.Label();
            this.optionsButton = new System.Windows.Forms.Button();
            this.CakeDataBox = new System.Windows.Forms.GroupBox();
            this.cheeseGroupBox = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addCheeseCakeButton = new System.Windows.Forms.Button();
            this.cheeseCakeInfoBox = new System.Windows.Forms.TextBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.carrotGroupBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addCarrotCakeButton = new System.Windows.Forms.Button();
            this.carrotCakeInfoBox = new System.Windows.Forms.TextBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.RedVelvetGroupBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addRedVelvetCakeButton = new System.Windows.Forms.Button();
            this.redVelvetCakeInfoBox = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.coffeeGroupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addCoffeeCakeButton = new System.Windows.Forms.Button();
            this.CoffeeCakeInfoBox = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.StrawberryGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addStrawberryCakeButton = new System.Windows.Forms.Button();
            this.strawberryCakeInfoBox = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ChocolateGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addChocolateCakeButton = new System.Windows.Forms.Button();
            this.ChocolateCakeInfoBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.VanillaCake = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addVanillaCakeButton = new System.Windows.Forms.Button();
            this.vanillaCakeInfoBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveAndQuitButton = new System.Windows.Forms.Button();
            this.CakeDataBox.SuspendLayout();
            this.cheeseGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.carrotGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.RedVelvetGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.coffeeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.StrawberryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.ChocolateGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.VanillaCake.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.Yellow;
            this.scoreLabel.Location = new System.Drawing.Point(797, 0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.scoreLabel.Size = new System.Drawing.Size(687, 63);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "9999999999999999999999";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addPointsTimer
            // 
            this.addPointsTimer.Tick += new System.EventHandler(this.AddPointsTimer_Tick);
            // 
            // cakeButton
            // 
            this.cakeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cakeButton.BackColor = System.Drawing.Color.Transparent;
            this.cakeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cakeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cakeButton.Image = global::Cake_Clicker_Game.Properties.Resources.Cake;
            this.cakeButton.Location = new System.Drawing.Point(488, 127);
            this.cakeButton.Name = "cakeButton";
            this.cakeButton.Size = new System.Drawing.Size(512, 512);
            this.cakeButton.TabIndex = 0;
            this.cakeButton.UseVisualStyleBackColor = false;
            this.cakeButton.Click += new System.EventHandler(this.cakeButton_Click);
            // 
            // cakeLabel
            // 
            this.cakeLabel.AutoSize = true;
            this.cakeLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.cakeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.cakeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.cakeLabel.Location = new System.Drawing.Point(0, 0);
            this.cakeLabel.Name = "cakeLabel";
            this.cakeLabel.Size = new System.Drawing.Size(649, 76);
            this.cakeLabel.TabIndex = 3;
            this.cakeLabel.Text = "[enterName]\'s CAKE";
            // 
            // optionsButton
            // 
            this.optionsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.optionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.optionsButton.Location = new System.Drawing.Point(1368, 645);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(104, 59);
            this.optionsButton.TabIndex = 4;
            this.optionsButton.Text = "Settings";
            this.optionsButton.UseVisualStyleBackColor = true;
            this.optionsButton.Click += new System.EventHandler(this.optionsButton_Click);
            // 
            // CakeDataBox
            // 
            this.CakeDataBox.Controls.Add(this.cheeseGroupBox);
            this.CakeDataBox.Controls.Add(this.carrotGroupBox);
            this.CakeDataBox.Controls.Add(this.RedVelvetGroupBox);
            this.CakeDataBox.Controls.Add(this.coffeeGroupBox);
            this.CakeDataBox.Controls.Add(this.StrawberryGroupBox);
            this.CakeDataBox.Controls.Add(this.ChocolateGroupBox);
            this.CakeDataBox.Controls.Add(this.VanillaCake);
            this.CakeDataBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CakeDataBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CakeDataBox.Location = new System.Drawing.Point(12, 97);
            this.CakeDataBox.Name = "CakeDataBox";
            this.CakeDataBox.Size = new System.Drawing.Size(273, 639);
            this.CakeDataBox.TabIndex = 6;
            this.CakeDataBox.TabStop = false;
            this.CakeDataBox.Text = "Cakes";
            // 
            // cheeseGroupBox
            // 
            this.cheeseGroupBox.Controls.Add(this.label7);
            this.cheeseGroupBox.Controls.Add(this.addCheeseCakeButton);
            this.cheeseGroupBox.Controls.Add(this.cheeseCakeInfoBox);
            this.cheeseGroupBox.Controls.Add(this.pictureBox7);
            this.cheeseGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cheeseGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cheeseGroupBox.Location = new System.Drawing.Point(6, 548);
            this.cheeseGroupBox.Name = "cheeseGroupBox";
            this.cheeseGroupBox.Size = new System.Drawing.Size(261, 83);
            this.cheeseGroupBox.TabIndex = 3;
            this.cheeseGroupBox.TabStop = false;
            this.cheeseGroupBox.Text = "Cheese";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(151, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "80000";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addCheeseCakeButton
            // 
            this.addCheeseCakeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.addCheeseCakeButton.ForeColor = System.Drawing.Color.Black;
            this.addCheeseCakeButton.Location = new System.Drawing.Point(215, 25);
            this.addCheeseCakeButton.Name = "addCheeseCakeButton";
            this.addCheeseCakeButton.Size = new System.Drawing.Size(40, 40);
            this.addCheeseCakeButton.TabIndex = 2;
            this.addCheeseCakeButton.Text = "+";
            this.addCheeseCakeButton.UseVisualStyleBackColor = true;
            this.addCheeseCakeButton.Click += new System.EventHandler(this.addCheeseCakeButton_Click);
            // 
            // cheeseCakeInfoBox
            // 
            this.cheeseCakeInfoBox.Location = new System.Drawing.Point(65, 37);
            this.cheeseCakeInfoBox.Name = "cheeseCakeInfoBox";
            this.cheeseCakeInfoBox.Size = new System.Drawing.Size(80, 26);
            this.cheeseCakeInfoBox.TabIndex = 1;
            this.cheeseCakeInfoBox.Text = "Count: 0";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.BackgroundImage = global::Cake_Clicker_Game.Properties.Resources.Cheese_Cake;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox7.Location = new System.Drawing.Point(6, 18);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(53, 59);
            this.pictureBox7.TabIndex = 0;
            this.pictureBox7.TabStop = false;
            // 
            // carrotGroupBox
            // 
            this.carrotGroupBox.Controls.Add(this.label6);
            this.carrotGroupBox.Controls.Add(this.addCarrotCakeButton);
            this.carrotGroupBox.Controls.Add(this.carrotCakeInfoBox);
            this.carrotGroupBox.Controls.Add(this.pictureBox6);
            this.carrotGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.carrotGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.carrotGroupBox.Location = new System.Drawing.Point(6, 459);
            this.carrotGroupBox.Name = "carrotGroupBox";
            this.carrotGroupBox.Size = new System.Drawing.Size(261, 83);
            this.carrotGroupBox.TabIndex = 3;
            this.carrotGroupBox.TabStop = false;
            this.carrotGroupBox.Text = "Carrot";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(151, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "20000";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addCarrotCakeButton
            // 
            this.addCarrotCakeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.addCarrotCakeButton.ForeColor = System.Drawing.Color.Black;
            this.addCarrotCakeButton.Location = new System.Drawing.Point(215, 25);
            this.addCarrotCakeButton.Name = "addCarrotCakeButton";
            this.addCarrotCakeButton.Size = new System.Drawing.Size(40, 40);
            this.addCarrotCakeButton.TabIndex = 2;
            this.addCarrotCakeButton.Text = "+";
            this.addCarrotCakeButton.UseVisualStyleBackColor = true;
            this.addCarrotCakeButton.Click += new System.EventHandler(this.addCarrotCakeButton_Click);
            // 
            // carrotCakeInfoBox
            // 
            this.carrotCakeInfoBox.Location = new System.Drawing.Point(65, 37);
            this.carrotCakeInfoBox.Name = "carrotCakeInfoBox";
            this.carrotCakeInfoBox.Size = new System.Drawing.Size(80, 26);
            this.carrotCakeInfoBox.TabIndex = 1;
            this.carrotCakeInfoBox.Text = "Count: 0";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImage = global::Cake_Clicker_Game.Properties.Resources.Carrot_Cake;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.Location = new System.Drawing.Point(6, 18);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(53, 59);
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // RedVelvetGroupBox
            // 
            this.RedVelvetGroupBox.Controls.Add(this.label5);
            this.RedVelvetGroupBox.Controls.Add(this.addRedVelvetCakeButton);
            this.RedVelvetGroupBox.Controls.Add(this.redVelvetCakeInfoBox);
            this.RedVelvetGroupBox.Controls.Add(this.pictureBox5);
            this.RedVelvetGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RedVelvetGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RedVelvetGroupBox.Location = new System.Drawing.Point(6, 370);
            this.RedVelvetGroupBox.Name = "RedVelvetGroupBox";
            this.RedVelvetGroupBox.Size = new System.Drawing.Size(261, 83);
            this.RedVelvetGroupBox.TabIndex = 3;
            this.RedVelvetGroupBox.TabStop = false;
            this.RedVelvetGroupBox.Text = "Red Velvet";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(151, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "4500";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addRedVelvetCakeButton
            // 
            this.addRedVelvetCakeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.addRedVelvetCakeButton.ForeColor = System.Drawing.Color.Black;
            this.addRedVelvetCakeButton.Location = new System.Drawing.Point(215, 25);
            this.addRedVelvetCakeButton.Name = "addRedVelvetCakeButton";
            this.addRedVelvetCakeButton.Size = new System.Drawing.Size(40, 40);
            this.addRedVelvetCakeButton.TabIndex = 2;
            this.addRedVelvetCakeButton.Text = "+";
            this.addRedVelvetCakeButton.UseVisualStyleBackColor = true;
            this.addRedVelvetCakeButton.Click += new System.EventHandler(this.addRedVelvetCakeButton_Click);
            // 
            // redVelvetCakeInfoBox
            // 
            this.redVelvetCakeInfoBox.Location = new System.Drawing.Point(65, 37);
            this.redVelvetCakeInfoBox.Name = "redVelvetCakeInfoBox";
            this.redVelvetCakeInfoBox.Size = new System.Drawing.Size(80, 26);
            this.redVelvetCakeInfoBox.TabIndex = 1;
            this.redVelvetCakeInfoBox.Text = "Count: 0";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = global::Cake_Clicker_Game.Properties.Resources.Red_Velvet_Cake;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Location = new System.Drawing.Point(6, 18);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(53, 59);
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // coffeeGroupBox
            // 
            this.coffeeGroupBox.Controls.Add(this.label4);
            this.coffeeGroupBox.Controls.Add(this.addCoffeeCakeButton);
            this.coffeeGroupBox.Controls.Add(this.CoffeeCakeInfoBox);
            this.coffeeGroupBox.Controls.Add(this.pictureBox4);
            this.coffeeGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.coffeeGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.coffeeGroupBox.Location = new System.Drawing.Point(6, 281);
            this.coffeeGroupBox.Name = "coffeeGroupBox";
            this.coffeeGroupBox.Size = new System.Drawing.Size(261, 83);
            this.coffeeGroupBox.TabIndex = 3;
            this.coffeeGroupBox.TabStop = false;
            this.coffeeGroupBox.Text = "Coffee";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(151, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "1000";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addCoffeeCakeButton
            // 
            this.addCoffeeCakeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.addCoffeeCakeButton.ForeColor = System.Drawing.Color.Black;
            this.addCoffeeCakeButton.Location = new System.Drawing.Point(215, 25);
            this.addCoffeeCakeButton.Name = "addCoffeeCakeButton";
            this.addCoffeeCakeButton.Size = new System.Drawing.Size(40, 40);
            this.addCoffeeCakeButton.TabIndex = 2;
            this.addCoffeeCakeButton.Text = "+";
            this.addCoffeeCakeButton.UseVisualStyleBackColor = true;
            this.addCoffeeCakeButton.Click += new System.EventHandler(this.addCoffeeCakeButton_Click);
            // 
            // CoffeeCakeInfoBox
            // 
            this.CoffeeCakeInfoBox.Location = new System.Drawing.Point(65, 37);
            this.CoffeeCakeInfoBox.Name = "CoffeeCakeInfoBox";
            this.CoffeeCakeInfoBox.Size = new System.Drawing.Size(80, 26);
            this.CoffeeCakeInfoBox.TabIndex = 1;
            this.CoffeeCakeInfoBox.Text = "Count: 0";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::Cake_Clicker_Game.Properties.Resources.Chocolate_Cake;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(6, 18);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(53, 59);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // StrawberryGroupBox
            // 
            this.StrawberryGroupBox.Controls.Add(this.label3);
            this.StrawberryGroupBox.Controls.Add(this.addStrawberryCakeButton);
            this.StrawberryGroupBox.Controls.Add(this.strawberryCakeInfoBox);
            this.StrawberryGroupBox.Controls.Add(this.pictureBox3);
            this.StrawberryGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.StrawberryGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.StrawberryGroupBox.Location = new System.Drawing.Point(6, 192);
            this.StrawberryGroupBox.Name = "StrawberryGroupBox";
            this.StrawberryGroupBox.Size = new System.Drawing.Size(261, 83);
            this.StrawberryGroupBox.TabIndex = 3;
            this.StrawberryGroupBox.TabStop = false;
            this.StrawberryGroupBox.Text = "Strawberry";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(151, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "500";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addStrawberryCakeButton
            // 
            this.addStrawberryCakeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.addStrawberryCakeButton.ForeColor = System.Drawing.Color.Black;
            this.addStrawberryCakeButton.Location = new System.Drawing.Point(215, 25);
            this.addStrawberryCakeButton.Name = "addStrawberryCakeButton";
            this.addStrawberryCakeButton.Size = new System.Drawing.Size(40, 40);
            this.addStrawberryCakeButton.TabIndex = 2;
            this.addStrawberryCakeButton.Text = "+";
            this.addStrawberryCakeButton.UseVisualStyleBackColor = true;
            this.addStrawberryCakeButton.Click += new System.EventHandler(this.addStrawberryCakeButton_Click);
            // 
            // strawberryCakeInfoBox
            // 
            this.strawberryCakeInfoBox.Location = new System.Drawing.Point(65, 37);
            this.strawberryCakeInfoBox.Name = "strawberryCakeInfoBox";
            this.strawberryCakeInfoBox.Size = new System.Drawing.Size(80, 26);
            this.strawberryCakeInfoBox.TabIndex = 1;
            this.strawberryCakeInfoBox.Text = "Count: 0";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::Cake_Clicker_Game.Properties.Resources.Strawberry_Cake;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(6, 18);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(53, 59);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // ChocolateGroupBox
            // 
            this.ChocolateGroupBox.Controls.Add(this.label2);
            this.ChocolateGroupBox.Controls.Add(this.addChocolateCakeButton);
            this.ChocolateGroupBox.Controls.Add(this.ChocolateCakeInfoBox);
            this.ChocolateGroupBox.Controls.Add(this.pictureBox2);
            this.ChocolateGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ChocolateGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ChocolateGroupBox.Location = new System.Drawing.Point(6, 109);
            this.ChocolateGroupBox.Name = "ChocolateGroupBox";
            this.ChocolateGroupBox.Size = new System.Drawing.Size(261, 83);
            this.ChocolateGroupBox.TabIndex = 3;
            this.ChocolateGroupBox.TabStop = false;
            this.ChocolateGroupBox.Text = "Chocolate";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(151, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "250";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addChocolateCakeButton
            // 
            this.addChocolateCakeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.addChocolateCakeButton.ForeColor = System.Drawing.Color.Black;
            this.addChocolateCakeButton.Location = new System.Drawing.Point(215, 25);
            this.addChocolateCakeButton.Name = "addChocolateCakeButton";
            this.addChocolateCakeButton.Size = new System.Drawing.Size(40, 40);
            this.addChocolateCakeButton.TabIndex = 2;
            this.addChocolateCakeButton.Text = "+";
            this.addChocolateCakeButton.UseVisualStyleBackColor = true;
            this.addChocolateCakeButton.Click += new System.EventHandler(this.addChocolateCakeButton_Click);
            // 
            // ChocolateCakeInfoBox
            // 
            this.ChocolateCakeInfoBox.Location = new System.Drawing.Point(65, 37);
            this.ChocolateCakeInfoBox.Name = "ChocolateCakeInfoBox";
            this.ChocolateCakeInfoBox.Size = new System.Drawing.Size(80, 26);
            this.ChocolateCakeInfoBox.TabIndex = 1;
            this.ChocolateCakeInfoBox.Text = "Count: 0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Cake_Clicker_Game.Properties.Resources.Chocolate_Cake;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(6, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 59);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // VanillaCake
            // 
            this.VanillaCake.Controls.Add(this.label1);
            this.VanillaCake.Controls.Add(this.addVanillaCakeButton);
            this.VanillaCake.Controls.Add(this.vanillaCakeInfoBox);
            this.VanillaCake.Controls.Add(this.pictureBox1);
            this.VanillaCake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.VanillaCake.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.VanillaCake.Location = new System.Drawing.Point(6, 26);
            this.VanillaCake.Name = "VanillaCake";
            this.VanillaCake.Size = new System.Drawing.Size(261, 83);
            this.VanillaCake.TabIndex = 0;
            this.VanillaCake.TabStop = false;
            this.VanillaCake.Text = "Vanilla";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(151, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "50";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addVanillaCakeButton
            // 
            this.addVanillaCakeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.addVanillaCakeButton.ForeColor = System.Drawing.Color.Black;
            this.addVanillaCakeButton.Location = new System.Drawing.Point(215, 30);
            this.addVanillaCakeButton.Name = "addVanillaCakeButton";
            this.addVanillaCakeButton.Size = new System.Drawing.Size(40, 40);
            this.addVanillaCakeButton.TabIndex = 2;
            this.addVanillaCakeButton.Text = "+";
            this.addVanillaCakeButton.UseVisualStyleBackColor = true;
            this.addVanillaCakeButton.Click += new System.EventHandler(this.addVanillaCakeButton_Click);
            // 
            // vanillaCakeInfoBox
            // 
            this.vanillaCakeInfoBox.Location = new System.Drawing.Point(65, 37);
            this.vanillaCakeInfoBox.Name = "vanillaCakeInfoBox";
            this.vanillaCakeInfoBox.Size = new System.Drawing.Size(80, 26);
            this.vanillaCakeInfoBox.TabIndex = 1;
            this.vanillaCakeInfoBox.Text = "Count: 0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Cake_Clicker_Game.Properties.Resources.Vanilla_Cake;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(6, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 59);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // saveAndQuitButton
            // 
            this.saveAndQuitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveAndQuitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveAndQuitButton.Location = new System.Drawing.Point(1337, 710);
            this.saveAndQuitButton.Name = "saveAndQuitButton";
            this.saveAndQuitButton.Size = new System.Drawing.Size(135, 63);
            this.saveAndQuitButton.TabIndex = 7;
            this.saveAndQuitButton.Text = "Save and Quit";
            this.saveAndQuitButton.UseVisualStyleBackColor = true;
            this.saveAndQuitButton.Click += new System.EventHandler(this.SaveAndQuitButton_Click);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1484, 785);
            this.Controls.Add(this.saveAndQuitButton);
            this.Controls.Add(this.CakeDataBox);
            this.Controls.Add(this.optionsButton);
            this.Controls.Add(this.cakeLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.cakeButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GameWindow";
            this.Text = "CakeClicker";
            this.CakeDataBox.ResumeLayout(false);
            this.cheeseGroupBox.ResumeLayout(false);
            this.cheeseGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.carrotGroupBox.ResumeLayout(false);
            this.carrotGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.RedVelvetGroupBox.ResumeLayout(false);
            this.RedVelvetGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.coffeeGroupBox.ResumeLayout(false);
            this.coffeeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.StrawberryGroupBox.ResumeLayout(false);
            this.StrawberryGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ChocolateGroupBox.ResumeLayout(false);
            this.ChocolateGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.VanillaCake.ResumeLayout(false);
            this.VanillaCake.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        } 

        #endregion

        private System.Windows.Forms.Button cakeButton;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Timer addPointsTimer;
        private System.Windows.Forms.Label cakeLabel;
        private System.Windows.Forms.Button optionsButton;
        private System.Windows.Forms.GroupBox CakeDataBox;
        private System.Windows.Forms.GroupBox VanillaCake;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox cheeseGroupBox;
        private System.Windows.Forms.Button addCheeseCakeButton;
        private System.Windows.Forms.TextBox cheeseCakeInfoBox;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.GroupBox carrotGroupBox;
        private System.Windows.Forms.Button addCarrotCakeButton;
        private System.Windows.Forms.TextBox carrotCakeInfoBox;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.GroupBox coffeeGroupBox;
        private System.Windows.Forms.Button addCoffeeCakeButton;
        private System.Windows.Forms.TextBox CoffeeCakeInfoBox;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.GroupBox StrawberryGroupBox;
        private System.Windows.Forms.Button addStrawberryCakeButton;
        private System.Windows.Forms.TextBox strawberryCakeInfoBox;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox ChocolateGroupBox;
        private System.Windows.Forms.Button addChocolateCakeButton;
        private System.Windows.Forms.TextBox ChocolateCakeInfoBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button addVanillaCakeButton;
        private System.Windows.Forms.TextBox vanillaCakeInfoBox;
        private System.Windows.Forms.Button saveAndQuitButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox RedVelvetGroupBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addRedVelvetCakeButton;
        private System.Windows.Forms.TextBox redVelvetCakeInfoBox;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

