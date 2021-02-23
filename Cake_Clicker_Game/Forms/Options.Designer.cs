
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.lightmodeButton = new System.Windows.Forms.RadioButton();
            this.darkmodeButton = new System.Windows.Forms.RadioButton();
            this.greymodeButton = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(75, 179);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 0;
            this.resetButton.Text = "Reset Game";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.greymodeButton);
            this.groupBox2.Controls.Add(this.darkmodeButton);
            this.groupBox2.Controls.Add(this.lightmodeButton);
            this.groupBox2.Location = new System.Drawing.Point(65, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(100, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Theme";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(75, 130);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save Game";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // lightmodeButton
            // 
            this.lightmodeButton.AutoSize = true;
            this.lightmodeButton.Location = new System.Drawing.Point(27, 19);
            this.lightmodeButton.Name = "lightmodeButton";
            this.lightmodeButton.Size = new System.Drawing.Size(48, 17);
            this.lightmodeButton.TabIndex = 0;
            this.lightmodeButton.TabStop = true;
            this.lightmodeButton.Text = "Light";
            this.lightmodeButton.UseVisualStyleBackColor = true;
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
            // 
            // greymodeButton
            // 
            this.greymodeButton.AutoSize = true;
            this.greymodeButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.greymodeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.greymodeButton.Location = new System.Drawing.Point(27, 65);
            this.greymodeButton.Name = "greymodeButton";
            this.greymodeButton.Size = new System.Drawing.Size(47, 17);
            this.greymodeButton.TabIndex = 2;
            this.greymodeButton.TabStop = true;
            this.greymodeButton.Text = "Grey";
            this.greymodeButton.UseVisualStyleBackColor = false;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 258);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.resetButton);
            this.Name = "Options";
            this.Text = "Options";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.RadioButton greymodeButton;
        private System.Windows.Forms.RadioButton darkmodeButton;
        private System.Windows.Forms.RadioButton lightmodeButton;
    }
}