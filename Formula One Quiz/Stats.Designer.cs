namespace Formula_One_Quiz
{
    partial class Stats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stats));
            this.SwitchButton = new System.Windows.Forms.Button();
            this.DoneButton = new System.Windows.Forms.Button();
            this.CarBox = new System.Windows.Forms.PictureBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GPLabel = new System.Windows.Forms.Label();
            this.GWLabel = new System.Windows.Forms.Label();
            this.WLLabel = new System.Windows.Forms.Label();
            this.TPQLabel = new System.Windows.Forms.Label();
            this.BTLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CarBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SwitchButton
            // 
            this.SwitchButton.BackColor = System.Drawing.Color.White;
            this.SwitchButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.SwitchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SwitchButton.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwitchButton.Location = new System.Drawing.Point(12, 197);
            this.SwitchButton.Name = "SwitchButton";
            this.SwitchButton.Size = new System.Drawing.Size(75, 23);
            this.SwitchButton.TabIndex = 0;
            this.SwitchButton.Text = "Switch User";
            this.SwitchButton.UseVisualStyleBackColor = false;
            this.SwitchButton.Click += new System.EventHandler(this.SwitchButton_Click);
            // 
            // DoneButton
            // 
            this.DoneButton.BackColor = System.Drawing.Color.White;
            this.DoneButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoneButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DoneButton.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoneButton.Location = new System.Drawing.Point(205, 197);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(75, 23);
            this.DoneButton.TabIndex = 1;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = false;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // CarBox
            // 
            this.CarBox.Location = new System.Drawing.Point(12, 36);
            this.CarBox.Name = "CarBox";
            this.CarBox.Size = new System.Drawing.Size(111, 48);
            this.CarBox.TabIndex = 2;
            this.CarBox.TabStop = false;
            this.CarBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PicBox_Paint);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.Black;
            this.NameLabel.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.White;
            this.NameLabel.Location = new System.Drawing.Point(12, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(189, 18);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Username should be here";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(141, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Games Played";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(141, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Games Won";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Win/Loss Ratio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Average Time/Question";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(9, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Best Time";
            // 
            // GPLabel
            // 
            this.GPLabel.AutoSize = true;
            this.GPLabel.ForeColor = System.Drawing.Color.White;
            this.GPLabel.Location = new System.Drawing.Point(246, 36);
            this.GPLabel.Name = "GPLabel";
            this.GPLabel.Size = new System.Drawing.Size(22, 13);
            this.GPLabel.TabIndex = 9;
            this.GPLabel.Text = "GP";
            this.GPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GWLabel
            // 
            this.GWLabel.AutoSize = true;
            this.GWLabel.ForeColor = System.Drawing.Color.White;
            this.GWLabel.Location = new System.Drawing.Point(246, 71);
            this.GWLabel.Name = "GWLabel";
            this.GWLabel.Size = new System.Drawing.Size(26, 13);
            this.GWLabel.TabIndex = 10;
            this.GWLabel.Text = "GW";
            this.GWLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WLLabel
            // 
            this.WLLabel.AutoSize = true;
            this.WLLabel.ForeColor = System.Drawing.Color.White;
            this.WLLabel.Location = new System.Drawing.Point(128, 102);
            this.WLLabel.Name = "WLLabel";
            this.WLLabel.Size = new System.Drawing.Size(24, 13);
            this.WLLabel.TabIndex = 11;
            this.WLLabel.Text = "WL";
            this.WLLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TPQLabel
            // 
            this.TPQLabel.AutoSize = true;
            this.TPQLabel.ForeColor = System.Drawing.Color.White;
            this.TPQLabel.Location = new System.Drawing.Point(156, 131);
            this.TPQLabel.Name = "TPQLabel";
            this.TPQLabel.Size = new System.Drawing.Size(29, 13);
            this.TPQLabel.TabIndex = 12;
            this.TPQLabel.Text = "TPQ";
            this.TPQLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BTLabel
            // 
            this.BTLabel.AutoSize = true;
            this.BTLabel.ForeColor = System.Drawing.Color.White;
            this.BTLabel.Location = new System.Drawing.Point(80, 162);
            this.BTLabel.Name = "BTLabel";
            this.BTLabel.Size = new System.Drawing.Size(21, 13);
            this.BTLabel.TabIndex = 13;
            this.BTLabel.Text = "BT";
            this.BTLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.CancelButton = this.DoneButton;
            this.ClientSize = new System.Drawing.Size(292, 232);
            this.Controls.Add(this.BTLabel);
            this.Controls.Add(this.TPQLabel);
            this.Controls.Add(this.WLLabel);
            this.Controls.Add(this.GWLabel);
            this.Controls.Add(this.GPLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.CarBox);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.SwitchButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Stats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAN\'T FIND USERNAME";
            ((System.ComponentModel.ISupportInitialize)(this.CarBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SwitchButton;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.PictureBox CarBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label GPLabel;
        private System.Windows.Forms.Label GWLabel;
        private System.Windows.Forms.Label WLLabel;
        private System.Windows.Forms.Label TPQLabel;
        private System.Windows.Forms.Label BTLabel;
    }
}