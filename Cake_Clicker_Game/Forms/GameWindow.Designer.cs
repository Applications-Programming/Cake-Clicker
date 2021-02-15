
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
            this.upgradeButtonGroupBox = new System.Windows.Forms.GroupBox();
            this.upgrade4Button = new System.Windows.Forms.Button();
            this.upgrade3Button = new System.Windows.Forms.Button();
            this.upgrade2Button = new System.Windows.Forms.Button();
            this.upgrade1Button = new System.Windows.Forms.Button();
            this.addPointsTimer = new System.Windows.Forms.Timer(this.components);
            this.cakeButton = new System.Windows.Forms.Button();
            this.cakeLabel = new System.Windows.Forms.Label();
            this.upgradeButtonGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.scoreLabel.Font = new System.Drawing.Font("Rockwell", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.Yellow;
            this.scoreLabel.Location = new System.Drawing.Point(821, 0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.scoreLabel.Size = new System.Drawing.Size(663, 60);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "9999999999999999999999";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // upgradeButtonGroupBox
            // 
            this.upgradeButtonGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.upgradeButtonGroupBox.Controls.Add(this.upgrade4Button);
            this.upgradeButtonGroupBox.Controls.Add(this.upgrade3Button);
            this.upgradeButtonGroupBox.Controls.Add(this.upgrade2Button);
            this.upgradeButtonGroupBox.Controls.Add(this.upgrade1Button);
            this.upgradeButtonGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.upgradeButtonGroupBox.Location = new System.Drawing.Point(1310, 466);
            this.upgradeButtonGroupBox.Name = "upgradeButtonGroupBox";
            this.upgradeButtonGroupBox.Size = new System.Drawing.Size(162, 180);
            this.upgradeButtonGroupBox.TabIndex = 2;
            this.upgradeButtonGroupBox.TabStop = false;
            this.upgradeButtonGroupBox.Text = "UPGRADES";
            // 
            // upgrade4Button
            // 
            this.upgrade4Button.AutoSize = true;
            this.upgrade4Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upgrade4Button.ForeColor = System.Drawing.Color.Black;
            this.upgrade4Button.Location = new System.Drawing.Point(6, 139);
            this.upgrade4Button.Name = "upgrade4Button";
            this.upgrade4Button.Size = new System.Drawing.Size(148, 34);
            this.upgrade4Button.TabIndex = 3;
            this.upgrade4Button.Text = "Upgrade 4: $99";
            this.upgrade4Button.UseVisualStyleBackColor = true;
            this.upgrade4Button.Click += new System.EventHandler(this.upgrade4Button_Click);
            // 
            // upgrade3Button
            // 
            this.upgrade3Button.AutoSize = true;
            this.upgrade3Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upgrade3Button.ForeColor = System.Drawing.Color.Black;
            this.upgrade3Button.Location = new System.Drawing.Point(6, 99);
            this.upgrade3Button.Name = "upgrade3Button";
            this.upgrade3Button.Size = new System.Drawing.Size(148, 34);
            this.upgrade3Button.TabIndex = 2;
            this.upgrade3Button.Text = "Upgrade 3: $99";
            this.upgrade3Button.UseVisualStyleBackColor = true;
            this.upgrade3Button.Click += new System.EventHandler(this.upgrade3Button_Click);
            // 
            // upgrade2Button
            // 
            this.upgrade2Button.AutoSize = true;
            this.upgrade2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upgrade2Button.ForeColor = System.Drawing.Color.Black;
            this.upgrade2Button.Location = new System.Drawing.Point(6, 59);
            this.upgrade2Button.Name = "upgrade2Button";
            this.upgrade2Button.Size = new System.Drawing.Size(148, 34);
            this.upgrade2Button.TabIndex = 1;
            this.upgrade2Button.Text = "Upgrade 2: $99";
            this.upgrade2Button.UseVisualStyleBackColor = true;
            this.upgrade2Button.Click += new System.EventHandler(this.upgrade2Button_Click);
            // 
            // upgrade1Button
            // 
            this.upgrade1Button.AutoSize = true;
            this.upgrade1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upgrade1Button.ForeColor = System.Drawing.Color.Black;
            this.upgrade1Button.Location = new System.Drawing.Point(6, 19);
            this.upgrade1Button.Name = "upgrade1Button";
            this.upgrade1Button.Size = new System.Drawing.Size(148, 34);
            this.upgrade1Button.TabIndex = 0;
            this.upgrade1Button.Text = "Upgrade 1: $99";
            this.upgrade1Button.UseVisualStyleBackColor = true;
            this.upgrade1Button.Click += new System.EventHandler(this.upgrade1Button_Click);
            // 
            // addPointsTimer
            // 
            this.addPointsTimer.Tick += new System.EventHandler(this.AddPointsTimer_Tick);
            // 
            // cakeButton
            // 
            this.cakeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cakeButton.BackColor = System.Drawing.Color.Transparent;
            this.cakeButton.Font = new System.Drawing.Font("Old English Text MT", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cakeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cakeButton.Image = global::Cake_Clicker_Game.Properties.Resources.Vanilla_Cake;
            this.cakeButton.Location = new System.Drawing.Point(217, 134);
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
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1484, 785);
            this.Controls.Add(this.cakeLabel);
            this.Controls.Add(this.upgradeButtonGroupBox);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.cakeButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GameWindow";
            this.Text = "CakeClicker";
            this.upgradeButtonGroupBox.ResumeLayout(false);
            this.upgradeButtonGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        } 

        #endregion

        private System.Windows.Forms.Button cakeButton;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.GroupBox upgradeButtonGroupBox;
        private System.Windows.Forms.Button upgrade1Button;
        private System.Windows.Forms.Button upgrade4Button;
        private System.Windows.Forms.Button upgrade3Button;
        private System.Windows.Forms.Button upgrade2Button;
        private System.Windows.Forms.Timer addPointsTimer;
        private System.Windows.Forms.Label cakeLabel;
    }
}

