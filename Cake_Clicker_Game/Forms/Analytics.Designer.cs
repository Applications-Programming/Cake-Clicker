
namespace Cake_Clicker_Game.Forms
{
    partial class Analytics
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
            this.pageTitle = new System.Windows.Forms.Label();
            this.uuidLabel = new System.Windows.Forms.Label();
            this.gameStateBox = new System.Windows.Forms.GroupBox();
            this.cheatLabel = new System.Windows.Forms.Label();
            this.gamemodeType = new System.Windows.Forms.Label();
            this.offlineModeLabel = new System.Windows.Forms.Label();
            this.profileLabel = new System.Windows.Forms.Label();
            this.maxCPSBar = new System.Windows.Forms.ProgressBar();
            this.maxCPSLabel = new System.Windows.Forms.Label();
            this.averageCPSLabel = new System.Windows.Forms.Label();
            this.averageCPSBar = new System.Windows.Forms.ProgressBar();
            this.closeTabButton = new System.Windows.Forms.Button();
            this.gameStateBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pageTitle
            // 
            this.pageTitle.AutoSize = true;
            this.pageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageTitle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.pageTitle.Location = new System.Drawing.Point(174, 6);
            this.pageTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pageTitle.Name = "pageTitle";
            this.pageTitle.Size = new System.Drawing.Size(333, 36);
            this.pageTitle.TabIndex = 0;
            this.pageTitle.Text = "Cake Clicker Analytics";
            // 
            // uuidLabel
            // 
            this.uuidLabel.AutoSize = true;
            this.uuidLabel.Location = new System.Drawing.Point(7, 30);
            this.uuidLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uuidLabel.Name = "uuidLabel";
            this.uuidLabel.Size = new System.Drawing.Size(104, 13);
            this.uuidLabel.TabIndex = 2;
            this.uuidLabel.Text = "Profile UUID: <uuid>";
            // 
            // gameStateBox
            // 
            this.gameStateBox.Controls.Add(this.cheatLabel);
            this.gameStateBox.Controls.Add(this.gamemodeType);
            this.gameStateBox.Controls.Add(this.offlineModeLabel);
            this.gameStateBox.Controls.Add(this.profileLabel);
            this.gameStateBox.Controls.Add(this.uuidLabel);
            this.gameStateBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gameStateBox.Location = new System.Drawing.Point(31, 57);
            this.gameStateBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gameStateBox.Name = "gameStateBox";
            this.gameStateBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gameStateBox.Size = new System.Drawing.Size(185, 94);
            this.gameStateBox.TabIndex = 3;
            this.gameStateBox.TabStop = false;
            this.gameStateBox.Text = "Game State";
            // 
            // cheatLabel
            // 
            this.cheatLabel.AutoSize = true;
            this.cheatLabel.Location = new System.Drawing.Point(7, 69);
            this.cheatLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cheatLabel.Name = "cheatLabel";
            this.cheatLabel.Size = new System.Drawing.Size(170, 13);
            this.cheatLabel.TabIndex = 6;
            this.cheatLabel.Text = "Autoclicker Detected: <true/false>";
            // 
            // gamemodeType
            // 
            this.gamemodeType.AutoSize = true;
            this.gamemodeType.Location = new System.Drawing.Point(7, 56);
            this.gamemodeType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gamemodeType.Name = "gamemodeType";
            this.gamemodeType.Size = new System.Drawing.Size(136, 13);
            this.gamemodeType.TabIndex = 5;
            this.gamemodeType.Text = "Current Gamemode: <type>";
            // 
            // offlineModeLabel
            // 
            this.offlineModeLabel.AutoSize = true;
            this.offlineModeLabel.Location = new System.Drawing.Point(7, 43);
            this.offlineModeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.offlineModeLabel.Name = "offlineModeLabel";
            this.offlineModeLabel.Size = new System.Drawing.Size(113, 13);
            this.offlineModeLabel.TabIndex = 4;
            this.offlineModeLabel.Text = "Offline Mode: <status>";
            // 
            // profileLabel
            // 
            this.profileLabel.AutoSize = true;
            this.profileLabel.Location = new System.Drawing.Point(7, 17);
            this.profileLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.profileLabel.Name = "profileLabel";
            this.profileLabel.Size = new System.Drawing.Size(80, 13);
            this.profileLabel.TabIndex = 3;
            this.profileLabel.Text = "Profile: <name>";
            // 
            // maxCPSBar
            // 
            this.maxCPSBar.Location = new System.Drawing.Point(383, 68);
            this.maxCPSBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maxCPSBar.Name = "maxCPSBar";
            this.maxCPSBar.Size = new System.Drawing.Size(183, 28);
            this.maxCPSBar.TabIndex = 4;
            // 
            // maxCPSLabel
            // 
            this.maxCPSLabel.AutoSize = true;
            this.maxCPSLabel.Location = new System.Drawing.Point(252, 74);
            this.maxCPSLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxCPSLabel.Name = "maxCPSLabel";
            this.maxCPSLabel.Size = new System.Drawing.Size(97, 13);
            this.maxCPSLabel.TabIndex = 5;
            this.maxCPSLabel.Text = "Top CPS Reached";
            // 
            // averageCPSLabel
            // 
            this.averageCPSLabel.AutoSize = true;
            this.averageCPSLabel.Location = new System.Drawing.Point(277, 106);
            this.averageCPSLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.averageCPSLabel.Name = "averageCPSLabel";
            this.averageCPSLabel.Size = new System.Drawing.Size(71, 13);
            this.averageCPSLabel.TabIndex = 6;
            this.averageCPSLabel.Text = "Average CPS";
            // 
            // averageCPSBar
            // 
            this.averageCPSBar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.averageCPSBar.Location = new System.Drawing.Point(383, 100);
            this.averageCPSBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.averageCPSBar.Name = "averageCPSBar";
            this.averageCPSBar.Size = new System.Drawing.Size(183, 26);
            this.averageCPSBar.TabIndex = 7;
            // 
            // closeTabButton
            // 
            this.closeTabButton.Location = new System.Drawing.Point(571, 151);
            this.closeTabButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closeTabButton.Name = "closeTabButton";
            this.closeTabButton.Size = new System.Drawing.Size(58, 42);
            this.closeTabButton.TabIndex = 8;
            this.closeTabButton.Text = "Close";
            this.closeTabButton.UseVisualStyleBackColor = true;
            this.closeTabButton.Click += new System.EventHandler(this.closeTabButton_Click);
            // 
            // Analytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 201);
            this.ControlBox = false;
            this.Controls.Add(this.closeTabButton);
            this.Controls.Add(this.averageCPSBar);
            this.Controls.Add(this.averageCPSLabel);
            this.Controls.Add(this.maxCPSLabel);
            this.Controls.Add(this.maxCPSBar);
            this.Controls.Add(this.gameStateBox);
            this.Controls.Add(this.pageTitle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Analytics";
            this.Text = "Analytics";
            this.gameStateBox.ResumeLayout(false);
            this.gameStateBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pageTitle;
        private System.Windows.Forms.Label uuidLabel;
        private System.Windows.Forms.GroupBox gameStateBox;
        private System.Windows.Forms.Label cheatLabel;
        private System.Windows.Forms.Label gamemodeType;
        private System.Windows.Forms.Label offlineModeLabel;
        private System.Windows.Forms.Label profileLabel;
        private System.Windows.Forms.ProgressBar maxCPSBar;
        private System.Windows.Forms.Label maxCPSLabel;
        private System.Windows.Forms.Label averageCPSLabel;
        private System.Windows.Forms.ProgressBar averageCPSBar;
        private System.Windows.Forms.Button closeTabButton;
    }
}