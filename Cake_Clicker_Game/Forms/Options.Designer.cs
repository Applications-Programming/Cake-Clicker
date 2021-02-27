
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
            this.wipeDatabase = new System.Windows.Forms.Button();
            this.developerControls = new System.Windows.Forms.GroupBox();
            this.datebaseWipeConfirm = new System.Windows.Forms.CheckBox();
            this.addCookieUserInput = new System.Windows.Forms.TextBox();
            this.addCookies = new System.Windows.Forms.Button();
            this.developerAddCookieLabel = new System.Windows.Forms.Label();
            this.colorThemeBox.SuspendLayout();
            this.databaseControlBox.SuspendLayout();
            this.developerControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(166, 29);
            this.resetButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(112, 35);
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
            this.colorThemeBox.Location = new System.Drawing.Point(98, 18);
            this.colorThemeBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.colorThemeBox.Name = "colorThemeBox";
            this.colorThemeBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.colorThemeBox.Size = new System.Drawing.Size(150, 154);
            this.colorThemeBox.TabIndex = 1;
            this.colorThemeBox.TabStop = false;
            this.colorThemeBox.Text = "Theme";
            // 
            // greymodeButton
            // 
            this.greymodeButton.AutoSize = true;
            this.greymodeButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.greymodeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.greymodeButton.Location = new System.Drawing.Point(39, 100);
            this.greymodeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.greymodeButton.Name = "greymodeButton";
            this.greymodeButton.Size = new System.Drawing.Size(86, 24);
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
            this.darkmodeButton.Location = new System.Drawing.Point(40, 65);
            this.darkmodeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.darkmodeButton.Name = "darkmodeButton";
            this.darkmodeButton.Size = new System.Drawing.Size(68, 24);
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
            this.lightmodeButton.Location = new System.Drawing.Point(39, 29);
            this.lightmodeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lightmodeButton.Name = "lightmodeButton";
            this.lightmodeButton.Size = new System.Drawing.Size(69, 24);
            this.lightmodeButton.TabIndex = 0;
            this.lightmodeButton.TabStop = true;
            this.lightmodeButton.Text = "Light";
            this.lightmodeButton.UseVisualStyleBackColor = false;
            this.lightmodeButton.CheckedChanged += new System.EventHandler(this.lightmodeButton_CheckedChanged);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(17, 29);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(112, 35);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save Game";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // databaseControlBox
            // 
            this.databaseControlBox.Controls.Add(this.datebaseWipeConfirm);
            this.databaseControlBox.Controls.Add(this.wipeDatabase);
            this.databaseControlBox.Location = new System.Drawing.Point(273, 18);
            this.databaseControlBox.Name = "databaseControlBox";
            this.databaseControlBox.Size = new System.Drawing.Size(168, 154);
            this.databaseControlBox.TabIndex = 3;
            this.databaseControlBox.TabStop = false;
            this.databaseControlBox.Text = "Database Controls";
            // 
            // wipeDatabase
            // 
            this.wipeDatabase.BackColor = System.Drawing.Color.IndianRed;
            this.wipeDatabase.Location = new System.Drawing.Point(17, 38);
            this.wipeDatabase.Name = "wipeDatabase";
            this.wipeDatabase.Size = new System.Drawing.Size(141, 41);
            this.wipeDatabase.TabIndex = 0;
            this.wipeDatabase.Text = "Wipe Database";
            this.wipeDatabase.UseVisualStyleBackColor = false;
            // 
            // developerControls
            // 
            this.developerControls.Controls.Add(this.developerAddCookieLabel);
            this.developerControls.Controls.Add(this.addCookies);
            this.developerControls.Controls.Add(this.addCookieUserInput);
            this.developerControls.Controls.Add(this.saveButton);
            this.developerControls.Controls.Add(this.resetButton);
            this.developerControls.Location = new System.Drawing.Point(456, 18);
            this.developerControls.Name = "developerControls";
            this.developerControls.Size = new System.Drawing.Size(321, 154);
            this.developerControls.TabIndex = 4;
            this.developerControls.TabStop = false;
            this.developerControls.Text = "Developer Controls";
            // 
            // datebaseWipeConfirm
            // 
            this.datebaseWipeConfirm.AutoSize = true;
            this.datebaseWipeConfirm.ForeColor = System.Drawing.Color.Maroon;
            this.datebaseWipeConfirm.Location = new System.Drawing.Point(21, 100);
            this.datebaseWipeConfirm.Name = "datebaseWipeConfirm";
            this.datebaseWipeConfirm.Size = new System.Drawing.Size(137, 24);
            this.datebaseWipeConfirm.TabIndex = 1;
            this.datebaseWipeConfirm.Text = "Confirm Reset";
            this.datebaseWipeConfirm.UseVisualStyleBackColor = true;
            // 
            // addCookieUserInput
            // 
            this.addCookieUserInput.Location = new System.Drawing.Point(6, 110);
            this.addCookieUserInput.Name = "addCookieUserInput";
            this.addCookieUserInput.Size = new System.Drawing.Size(193, 26);
            this.addCookieUserInput.TabIndex = 0;
            // 
            // addCookies
            // 
            this.addCookies.Location = new System.Drawing.Point(206, 104);
            this.addCookies.Name = "addCookies";
            this.addCookies.Size = new System.Drawing.Size(109, 38);
            this.addCookies.TabIndex = 1;
            this.addCookies.Text = "Add Cookies";
            this.addCookies.UseVisualStyleBackColor = true;
            this.addCookies.Click += new System.EventHandler(this.addCookies_Click);
            // 
            // developerAddCookieLabel
            // 
            this.developerAddCookieLabel.AutoSize = true;
            this.developerAddCookieLabel.ForeColor = System.Drawing.Color.Black;
            this.developerAddCookieLabel.Location = new System.Drawing.Point(6, 87);
            this.developerAddCookieLabel.Name = "developerAddCookieLabel";
            this.developerAddCookieLabel.Size = new System.Drawing.Size(122, 20);
            this.developerAddCookieLabel.TabIndex = 3;
            this.developerAddCookieLabel.Text = "Generate Cake:";
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(801, 355);
            this.Controls.Add(this.developerControls);
            this.Controls.Add(this.databaseControlBox);
            this.Controls.Add(this.colorThemeBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Options";
            this.Text = "Options";
            this.colorThemeBox.ResumeLayout(false);
            this.colorThemeBox.PerformLayout();
            this.databaseControlBox.ResumeLayout(false);
            this.databaseControlBox.PerformLayout();
            this.developerControls.ResumeLayout(false);
            this.developerControls.PerformLayout();
            this.ResumeLayout(false);

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
    }
}