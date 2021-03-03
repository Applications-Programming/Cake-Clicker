
namespace Cake_Clicker_Game.Forms
{
    partial class Options
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
            this.resetButton = new System.Windows.Forms.Button();
            this.colorThemeBox = new System.Windows.Forms.GroupBox();
            this.greymodeButton = new System.Windows.Forms.RadioButton();
            this.darkmodeButton = new System.Windows.Forms.RadioButton();
            this.lightmodeButton = new System.Windows.Forms.RadioButton();
            this.saveButton = new System.Windows.Forms.Button();
            this.databaseControlBox = new System.Windows.Forms.GroupBox();
            this.datebaseWipeConfirm = new System.Windows.Forms.CheckBox();
            this.wipeDatabase = new System.Windows.Forms.Button();
            this.developerControls = new System.Windows.Forms.GroupBox();
            this.loadGameUserInput = new System.Windows.Forms.TextBox();
            this.loadGameButton = new System.Windows.Forms.Button();
            this.loadGameLabel = new System.Windows.Forms.Label();
            this.developerAddCookieLabel = new System.Windows.Forms.Label();
            this.addCookies = new System.Windows.Forms.Button();
            this.addCookieUserInput = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.UUID_Label = new System.Windows.Forms.Label();
            this.colorThemeBox.SuspendLayout();
            this.databaseControlBox.SuspendLayout();
            this.developerControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(111, 25);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 0;
            this.resetButton.Text = "Reset Game";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // colorThemeBox
            // 
            this.colorThemeBox.Controls.Add(this.greymodeButton);
            this.colorThemeBox.Controls.Add(this.darkmodeButton);
            this.colorThemeBox.Controls.Add(this.lightmodeButton);
            this.colorThemeBox.Location = new System.Drawing.Point(65, 12);
            this.colorThemeBox.Name = "colorThemeBox";
            this.colorThemeBox.Size = new System.Drawing.Size(100, 100);
            this.colorThemeBox.TabIndex = 1;
            this.colorThemeBox.TabStop = false;
            this.colorThemeBox.Text = "Theme";
            // 
            // greymodeButton
            // 
            this.greymodeButton.AutoSize = true;
            this.greymodeButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.greymodeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.greymodeButton.Location = new System.Drawing.Point(26, 65);
            this.greymodeButton.Name = "greymodeButton";
            this.greymodeButton.Size = new System.Drawing.Size(59, 17);
            this.greymodeButton.TabIndex = 2;
            this.greymodeButton.Text = "Default";
            this.greymodeButton.UseVisualStyleBackColor = false;
            this.greymodeButton.CheckedChanged += new System.EventHandler(this.greymodeButton_CheckedChanged);
            // 
            // darkmodeButton
            // 
            this.darkmodeButton.AutoSize = true;
            this.darkmodeButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.darkmodeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.darkmodeButton.Location = new System.Drawing.Point(27, 42);
            this.darkmodeButton.Name = "darkmodeButton";
            this.darkmodeButton.Size = new System.Drawing.Size(48, 17);
            this.darkmodeButton.TabIndex = 1;
            this.darkmodeButton.TabStop = true;
            this.darkmodeButton.Text = "Dark";
            this.darkmodeButton.UseVisualStyleBackColor = false;
            this.darkmodeButton.CheckedChanged += new System.EventHandler(this.darkmodeButton_CheckedChanged);
            // 
            // lightmodeButton
            // 
            this.lightmodeButton.AutoSize = true;
            this.lightmodeButton.BackColor = System.Drawing.Color.White;
            this.lightmodeButton.Location = new System.Drawing.Point(26, 19);
            this.lightmodeButton.Name = "lightmodeButton";
            this.lightmodeButton.Size = new System.Drawing.Size(48, 17);
            this.lightmodeButton.TabIndex = 0;
            this.lightmodeButton.TabStop = true;
            this.lightmodeButton.Text = "Light";
            this.lightmodeButton.UseVisualStyleBackColor = false;
            this.lightmodeButton.CheckedChanged += new System.EventHandler(this.lightmodeButton_CheckedChanged);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(11, 27);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save Game";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // databaseControlBox
            // 
            this.databaseControlBox.Controls.Add(this.datebaseWipeConfirm);
            this.databaseControlBox.Controls.Add(this.wipeDatabase);
            this.databaseControlBox.Location = new System.Drawing.Point(182, 12);
            this.databaseControlBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.databaseControlBox.Name = "databaseControlBox";
            this.databaseControlBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.databaseControlBox.Size = new System.Drawing.Size(112, 100);
            this.databaseControlBox.TabIndex = 3;
            this.databaseControlBox.TabStop = false;
            this.databaseControlBox.Text = "Database Controls";
            // 
            // datebaseWipeConfirm
            // 
            this.datebaseWipeConfirm.AutoSize = true;
            this.datebaseWipeConfirm.ForeColor = System.Drawing.Color.Maroon;
            this.datebaseWipeConfirm.Location = new System.Drawing.Point(14, 65);
            this.datebaseWipeConfirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datebaseWipeConfirm.Name = "datebaseWipeConfirm";
            this.datebaseWipeConfirm.Size = new System.Drawing.Size(92, 17);
            this.datebaseWipeConfirm.TabIndex = 1;
            this.datebaseWipeConfirm.Text = "Confirm Reset";
            this.datebaseWipeConfirm.UseVisualStyleBackColor = true;
            // 
            // wipeDatabase
            // 
            this.wipeDatabase.BackColor = System.Drawing.Color.IndianRed;
            this.wipeDatabase.Location = new System.Drawing.Point(11, 25);
            this.wipeDatabase.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.wipeDatabase.Name = "wipeDatabase";
            this.wipeDatabase.Size = new System.Drawing.Size(94, 27);
            this.wipeDatabase.TabIndex = 0;
            this.wipeDatabase.Text = "Wipe Database";
            this.wipeDatabase.UseVisualStyleBackColor = false;
            // 
            // developerControls
            // 
            this.developerControls.Controls.Add(this.loadGameUserInput);
            this.developerControls.Controls.Add(this.loadGameButton);
            this.developerControls.Controls.Add(this.loadGameLabel);
            this.developerControls.Controls.Add(this.developerAddCookieLabel);
            this.developerControls.Controls.Add(this.addCookies);
            this.developerControls.Controls.Add(this.addCookieUserInput);
            this.developerControls.Controls.Add(this.saveButton);
            this.developerControls.Controls.Add(this.resetButton);
            this.developerControls.Location = new System.Drawing.Point(304, 12);
            this.developerControls.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.developerControls.Name = "developerControls";
            this.developerControls.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.developerControls.Size = new System.Drawing.Size(214, 162);
            this.developerControls.TabIndex = 4;
            this.developerControls.TabStop = false;
            this.developerControls.Text = "Developer Controls";
            // 
            // loadGameUserInput
            // 
            this.loadGameUserInput.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.loadGameUserInput.Location = new System.Drawing.Point(7, 88);
            this.loadGameUserInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loadGameUserInput.Name = "loadGameUserInput";
            this.loadGameUserInput.Size = new System.Drawing.Size(122, 20);
            this.loadGameUserInput.TabIndex = 6;
            this.loadGameUserInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loadGameUserInput_KeyPress);
            // 
            // loadGameButton
            // 
            this.loadGameButton.Location = new System.Drawing.Point(137, 84);
            this.loadGameButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loadGameButton.Name = "loadGameButton";
            this.loadGameButton.Size = new System.Drawing.Size(73, 23);
            this.loadGameButton.TabIndex = 5;
            this.loadGameButton.Text = "Load Profile";
            this.loadGameButton.UseVisualStyleBackColor = true;
            this.loadGameButton.Click += new System.EventHandler(this.loadGameButton_Click);
            // 
            // loadGameLabel
            // 
            this.loadGameLabel.AutoSize = true;
            this.loadGameLabel.Location = new System.Drawing.Point(5, 66);
            this.loadGameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loadGameLabel.Name = "loadGameLabel";
            this.loadGameLabel.Size = new System.Drawing.Size(165, 13);
            this.loadGameLabel.TabIndex = 4;
            this.loadGameLabel.Text = "Load Profile (UUID or Username):";
            // 
            // developerAddCookieLabel
            // 
            this.developerAddCookieLabel.AutoSize = true;
            this.developerAddCookieLabel.ForeColor = System.Drawing.Color.Black;
            this.developerAddCookieLabel.Location = new System.Drawing.Point(5, 109);
            this.developerAddCookieLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.developerAddCookieLabel.Name = "developerAddCookieLabel";
            this.developerAddCookieLabel.Size = new System.Drawing.Size(82, 13);
            this.developerAddCookieLabel.TabIndex = 3;
            this.developerAddCookieLabel.Text = "Generate Cake:";
            // 
            // addCookies
            // 
            this.addCookies.Location = new System.Drawing.Point(137, 128);
            this.addCookies.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addCookies.Name = "addCookies";
            this.addCookies.Size = new System.Drawing.Size(73, 25);
            this.addCookies.TabIndex = 1;
            this.addCookies.Text = "Add Cookies";
            this.addCookies.UseVisualStyleBackColor = true;
            this.addCookies.Click += new System.EventHandler(this.addCookies_Click);
            // 
            // addCookieUserInput
            // 
            this.addCookieUserInput.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.addCookieUserInput.Location = new System.Drawing.Point(7, 132);
            this.addCookieUserInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addCookieUserInput.Name = "addCookieUserInput";
            this.addCookieUserInput.Size = new System.Drawing.Size(122, 20);
            this.addCookieUserInput.TabIndex = 0;
            this.addCookieUserInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addCookieUserInput_KeyPress);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(447, 196);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Close";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // UUID_Label
            // 
            this.UUID_Label.AutoSize = true;
            this.UUID_Label.BackColor = System.Drawing.Color.White;
            this.UUID_Label.Location = new System.Drawing.Point(12, 209);
            this.UUID_Label.Name = "UUID_Label";
            this.UUID_Label.Size = new System.Drawing.Size(0, 13);
            this.UUID_Label.TabIndex = 6;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(534, 231);
            this.ControlBox = false;
            this.Controls.Add(this.UUID_Label);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.developerControls);
            this.Controls.Add(this.databaseControlBox);
            this.Controls.Add(this.colorThemeBox);
            this.Name = "Options";
            this.Text = " ";
            this.colorThemeBox.ResumeLayout(false);
            this.colorThemeBox.PerformLayout();
            this.databaseControlBox.ResumeLayout(false);
            this.databaseControlBox.PerformLayout();
            this.developerControls.ResumeLayout(false);
            this.developerControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.GroupBox colorThemeBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.RadioButton greymodeButton;
        private System.Windows.Forms.RadioButton darkmodeButton;
        private System.Windows.Forms.RadioButton lightmodeButton;
        private System.Windows.Forms.GroupBox databaseControlBox;
        private System.Windows.Forms.Button wipeDatabase;
        private System.Windows.Forms.CheckBox datebaseWipeConfirm;
        private System.Windows.Forms.GroupBox developerControls;
        private System.Windows.Forms.Label developerAddCookieLabel;
        private System.Windows.Forms.Button addCookies;
        private System.Windows.Forms.TextBox addCookieUserInput;
        private System.Windows.Forms.Label loadGameLabel;
        private System.Windows.Forms.TextBox loadGameUserInput;
        private System.Windows.Forms.Button loadGameButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label UUID_Label;
    }
}