namespace Formula_One_Quiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.RestartButton = new System.Windows.Forms.Button();
            this.DoneButton = new System.Windows.Forms.Button();
            this.InstructButton = new System.Windows.Forms.Button();
            this.MusicButton = new System.Windows.Forms.Button();
            this.SFXButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RestartButton
            // 
            this.RestartButton.BackColor = System.Drawing.Color.White;
            this.RestartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RestartButton.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestartButton.Location = new System.Drawing.Point(39, 105);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(111, 23);
            this.RestartButton.TabIndex = 4;
            this.RestartButton.Text = "Change Users";
            this.RestartButton.UseVisualStyleBackColor = false;
            this.RestartButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // DoneButton
            // 
            this.DoneButton.BackColor = System.Drawing.Color.White;
            this.DoneButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DoneButton.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoneButton.Location = new System.Drawing.Point(65, 151);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(58, 23);
            this.DoneButton.TabIndex = 0;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = false;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // InstructButton
            // 
            this.InstructButton.BackColor = System.Drawing.Color.White;
            this.InstructButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InstructButton.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructButton.Location = new System.Drawing.Point(58, 18);
            this.InstructButton.Name = "InstructButton";
            this.InstructButton.Size = new System.Drawing.Size(75, 23);
            this.InstructButton.TabIndex = 1;
            this.InstructButton.Text = "Help";
            this.InstructButton.UseVisualStyleBackColor = false;
            this.InstructButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // MusicButton
            // 
            this.MusicButton.BackColor = System.Drawing.Color.White;
            this.MusicButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MusicButton.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MusicButton.Location = new System.Drawing.Point(39, 47);
            this.MusicButton.Name = "MusicButton";
            this.MusicButton.Size = new System.Drawing.Size(111, 23);
            this.MusicButton.TabIndex = 2;
            this.MusicButton.Text = "Music Off";
            this.MusicButton.UseVisualStyleBackColor = false;
            this.MusicButton.Click += new System.EventHandler(this.MusicButton_Click);
            // 
            // SFXButton
            // 
            this.SFXButton.BackColor = System.Drawing.Color.White;
            this.SFXButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SFXButton.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SFXButton.Location = new System.Drawing.Point(39, 76);
            this.SFXButton.Name = "SFXButton";
            this.SFXButton.Size = new System.Drawing.Size(111, 23);
            this.SFXButton.TabIndex = 3;
            this.SFXButton.Text = "SFX Off";
            this.SFXButton.UseVisualStyleBackColor = false;
            this.SFXButton.Click += new System.EventHandler(this.SFXButton_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.CancelButton = this.DoneButton;
            this.ClientSize = new System.Drawing.Size(189, 194);
            this.ControlBox = false;
            this.Controls.Add(this.SFXButton);
            this.Controls.Add(this.MusicButton);
            this.Controls.Add(this.InstructButton);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.RestartButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Button InstructButton;
        private System.Windows.Forms.Button MusicButton;
        private System.Windows.Forms.Button SFXButton;
    }
}