
namespace Cake_Clicker_Game
{
    partial class Form1
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
            this.cakeButton = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.upgrade1Button = new System.Windows.Forms.Button();
            this.upgrade2Button = new System.Windows.Forms.Button();
            this.upgrade3Button = new System.Windows.Forms.Button();
            this.upgrade4Button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cakeButton
            // 
            this.cakeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cakeButton.Font = new System.Drawing.Font("Old English Text MT", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cakeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cakeButton.Location = new System.Drawing.Point(477, 175);
            this.cakeButton.Name = "cakeButton";
            this.cakeButton.Size = new System.Drawing.Size(504, 398);
            this.cakeButton.TabIndex = 0;
            this.cakeButton.Text = "CAKE!!!";
            this.cakeButton.UseVisualStyleBackColor = false;
            this.cakeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.Font = new System.Drawing.Font("Rockwell", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.Yellow;
            this.scoreLabel.Location = new System.Drawing.Point(1164, 9);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.scoreLabel.Size = new System.Drawing.Size(308, 32);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "9999999999999999999999";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.scoreLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.upgrade4Button);
            this.groupBox1.Controls.Add(this.upgrade3Button);
            this.groupBox1.Controls.Add(this.upgrade2Button);
            this.groupBox1.Controls.Add(this.upgrade1Button);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Location = new System.Drawing.Point(155, 547);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 180);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "UPGRADES";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1484, 785);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.cakeButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cakeButton;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button upgrade1Button;
        private System.Windows.Forms.Button upgrade4Button;
        private System.Windows.Forms.Button upgrade3Button;
        private System.Windows.Forms.Button upgrade2Button;
    }
}

